using System;
using System.Windows.Forms;
using MineCalc.Data;
using MineCalc.Model;
using Newtonsoft.Json;
using static System.Console;

namespace MineCalc
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        static void Test()
        { 
            var repo = new Repository();
            var book = repo.LoadRecipeBook();
            var calc = new Calculator();

            var desiredStack = new BlockStack(new BlockType("Rail"), 1);
            WriteLine("Desired item");
            WriteLine(desiredStack);
            WriteLine();

            var recipe = calc.GetRecipe(book, desiredStack);
            WriteLine("Recipe");
            WriteLine(recipe);
            WriteLine();

            var recipe2 = calc.Expand(recipe, book);
            WriteLine("Normalized");
            WriteLine(recipe2);
            WriteLine();

            Read();
        }

        static void WriteObject(object obj)
        {
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            WriteLine(json);
        }
    }
}
