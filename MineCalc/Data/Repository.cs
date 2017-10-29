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
            var blockTypes = Load<ItemType>("*Blocks.json").OrderBy(item => item.Name);
            var recipes = Load<Recipe>("*Recipes.json").OrderBy(rec => rec.Result.Type.Name);
            var book = new RecipeBook(blockTypes, recipes);
            ValidateRecipeBook(book);
            return book;
        }

        private IEnumerable<T> Load<T>(string filePattern)
        {
            var currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.Combine(currentDir, "Data");
            var files = Directory.GetFiles(path, filePattern, SearchOption.AllDirectories);

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
                .SelectMany(rec => rec.Ingredients.Select(stack => stack.Type))
                .Distinct()
                .ToList();

            var missingBlocks = requiredBlocks.Except(book.Items);

            if (missingBlocks.Any())
            {
                var missingBlocksList = missingBlocks
                    .Select(item => $"'{item.Name}'")
                    .ToDelimitedString(", ");

                throw new Exception($"Could not find blocks {missingBlocksList}");
            }

            if (book.Items.Any(item => item.Name == null)
                || requiredBlocks.Any(item => item.Name == null))
                throw new Exception("Block types cannot have null names.");

            if (book.Recipes.Any(rec => rec.Ingredients.Any(stack => stack.Count == 0)))
                throw new Exception("Recipe cannot require 0 of a block.");

            var duplicates = book.Items
                .GroupBy(item => item.Name)
                .Where(group => group.Count() > 1)
                .ToList();

            if (duplicates.Any())
            {
                var duplicatesList = duplicates
                    .Select(group => $"'{group.Key}'")
                    .ToDelimitedString(", ");

                throw new Exception($"Duplicate blocks {duplicatesList}");
            }
        }
    }
}
