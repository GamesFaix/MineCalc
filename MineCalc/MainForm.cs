using System;
using System.Windows.Forms;
using MineCalc.Model;
using System.ComponentModel;
using System.Linq;
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
    }
}
