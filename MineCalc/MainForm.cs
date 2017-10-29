using System;
using System.Windows.Forms;
using MineCalc.Model;
using System.ComponentModel;
using System.Linq;
using MineCalc.ViewModel;
using MoreLinq;
using System.Collections.Generic;

namespace MineCalc
{
    public partial class MainForm : Form
    {
        internal Calculator Calculator { get; set; }
        internal RecipeBook RecipeBook { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            grid_Recipes.DataSource = RecipeBook.Recipes
                .Select(r => new RecipeViewModel
                {
                    Result = r.Result.ToString(),
                    Requirements = r.Requirements
                        .Select(req => req.ToString())
                        .ToDelimitedString(", ")
                })
                .ToList();

            grid_Blocks.DataSource = RecipeBook.BlockTypes;
        }

        private IEnumerable<BlockStack> GetQuery()
        {
            foreach (DataGridViewRow r in grid_Query.Rows)
            {
                var name = r.Cells[0].Value?.ToString();

                if (name != null)
                {
                    var count = int.Parse(r.Cells[1].Value.ToString());
                    yield return new BlockStack(new BlockType(name), count);
                }
            }
        }

        private bool ValidateQuery(List<BlockStack> query)
        {
            string errorMsg = "";

            var missing = query
                .Select(bs => bs.Type)
                .Except(RecipeBook.BlockTypes)
                .ToList();

            if (missing.Any())
            {
                var missingList = missing
                    .Select(t => $"'{t.Name}'")
                    .ToDelimitedString(", ");

                errorMsg += $"Could not find blocks: {missingList}";
            }

            if (errorMsg != "")
            {
                MessageBox.Show(errorMsg);
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<BlockStackViewModel> CalculateRequirements(List<BlockStack> query)
        {
            var requirements = query
                .Select(bs => Calculator.Expand(bs, RecipeBook))
                .SelectMany(rec => rec.Requirements);

            return Calculator.Merge(null, requirements)
                .Requirements
                .Select(req => new BlockStackViewModel
                {
                    BlockType = req.Type.Name,
                    Count = req.Count
                })
                .ToList();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            var query = GetQuery().ToList();
            if (!ValidateQuery(query))
            {
                return;
            }

            var requirements = CalculateRequirements(query);
            grid_Calculated.DataSource = requirements;
        }
    }
}
