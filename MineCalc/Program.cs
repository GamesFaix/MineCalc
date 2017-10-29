using System;
using System.Windows.Forms;
using MineCalc.Data;
using MineCalc.Model;

namespace MineCalc
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var repo = new Repository();
            var book = repo.LoadRecipeBook();
            var calc = new Calculator(book);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new MainForm();
            form.RecipeBook = book;
            form.Calculator = calc;

            Application.Run(form);
        }
    }
}
