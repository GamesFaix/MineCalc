using System;
using System.Windows.Forms;
using MineCalc.Model;
using System.ComponentModel;

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
            grid_Recipes.DataSource = RecipeBook.Recipes;
            grid_Blocks.DataSource = RecipeBook.BlockTypes;
        }
    }
}
