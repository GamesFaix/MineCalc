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
                .Select(ViewModelExtensions.ToViewModel)
                .ToList();

            grid_Items.DataSource = RecipeBook.Items;
        }
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            var query = GetQuery().ToList();
            if (!ValidateQuery(query)) return;

            grid_Calculated.DataSource =
                Calculator.GetIngredients(query)
                .Select(ViewModelExtensions.ToViewModel)
                .ToList();
        }

        private IEnumerable<ItemStack> GetQuery()
        {
            foreach (DataGridViewRow row in grid_Query.Rows)
            {
                var name = row.Cells[0].Value?.ToString();

                if (name != null)
                {
                    var count = int.Parse(row.Cells[1].Value.ToString());
                    yield return new ItemStack(new ItemType(name), count);
                }
            }
        }

        private bool ValidateQuery(List<ItemStack> query)
        {
            string errorMsg = "";

            var missing = query
                .Select(stack => stack.Type)
                .Except(RecipeBook.Items)
                .ToList();

            if (missing.Any())
            {
                var missingList = missing
                    .Select(item => $"'{item.Name}'")
                    .ToDelimitedString(", ");

                errorMsg += $"Could not find items: {missingList}";
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
    }
}
