using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MineCalc.Model;
using MineCalc.ViewModel;
using MoreLinq;

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
                .Select(Extensions.ToViewModel)
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
        
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            var query = GetQuery().ToList();
            if (!ValidateQuery(query)) return;

            grid_Calculated.DataSource = 
                Calculator.GetRequirements(query)
                .Select(Extensions.ToViewModel)
                .ToList();
        }
    }
}
