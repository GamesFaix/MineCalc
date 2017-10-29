using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MineCalc.Model;
using MoreLinq;
using Newtonsoft.Json;

namespace MineCalc.Data
{
    class Repository
    {
        public RecipeBook LoadRecipeBook()
        {
            var blockTypes = Load<BlockType>("BlockTypes");
            var recipes = Load<Recipe>("Recipes");
            var book = new RecipeBook(blockTypes, recipes);
            ValidateRecipeBook(book);
            return book;
        }

        private IEnumerable<T> Load<T>(string folder)
        {
            var currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.Combine(currentDir, "Data", folder);
            var files = Directory.GetFiles(path);

            var result = new List<T>();
            foreach (var f in files)
            {
                var json = File.ReadAllText(f);
                var seq = JsonConvert.DeserializeObject<IEnumerable<T>>(json);
                result.AddRange(seq);
            }
            return result;
        }

        private void ValidateRecipeBook(RecipeBook book)
        {
            var requiredBlocks = book.Recipes
                .SelectMany(r => r.Requirements.Select(req => req.Type))
                .Distinct()
                .ToList();

            var missingBlocks = requiredBlocks.Except(book.BlockTypes);

            if (missingBlocks.Any())
            {
                var missingBlocksList = missingBlocks
                    .Select(b => $"'{b.Name}'")
                    .ToDelimitedString(", ");

                throw new Exception($"Could not find blocks {missingBlocksList}");
            }

            if (book.BlockTypes.Any(b => b.Name == null)
                || requiredBlocks.Any(b => b.Name == null))
                throw new Exception("Block types cannot have null names.");

            if (book.Recipes.Any(r => r.Requirements.Any(req => req.Count == 0)))
                throw new Exception("Recipe cannot require 0 of a block.");
        }
    }
}
