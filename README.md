# MineCalc

## The Problem

In Minecraft, resource management can be difficult. Some items can be found in the wild, but many items need to be crafted from other items. 

Sometimes to build something complex, you need a variety of crafted and primitive items, and so you must go into the wild and gather the primitive resources required for all the crafting.

The problem is that calculating the exact required raw items can be very difficult for several reasons:
 1. Recipes can require other crafted items, sometimes to about 5 levels of recursion (or even more with mods)
 2. Recipes sometimes yield multiple copies of items
 3. Recipes don't take into account the required amount of fuel

## The Solution

MineCalc lets you calculate the exact raw item requirements to craft a set of items. You give it a list of items and quantities that you want, and it will tell you the amount of Wood, Coal, Iron, etc. required.

## How to use

To see what items and recipes are loaded, check the _Database_ tab.

![alt text](https://github.com/GamesFaix/MineCalc/Screenshot_Database.png)

To perform a calculation, use the _Query_ tab. Enter the items and quantities you want in the _Desired Result_ section on the left, click _Calculate_ and the required raw items will appear in the _Calculated Requirements_ section on the right.

![alt text](https://github.com/GamesFaix/MineCalc/Screenshot_Query.png)

## How it works

Any recipes you want to be able to use in your calculations must be encoded in JSON files. There are two types of files: item files and recipe files.

Item files just list the names of items you want to work with, and look like this:

```
[
  { "Name": "Coal" },
  { "Name": "Iron Ingot" },
  { "Name": "Iron Ore" },
  { "Name": "Iron Shovel" },
  { "Name": "Plank" },
  { "Name": "Stick" },
  { "Name": "Wood" }
]
```

Recipe files list the details of each recipe you want to be able to calculate with, and look like this:

```
[
  {
    "Result": {
      "Type": { "Name": "Iron Ingot" },
      "Count": 1
    },
    "Ingredients": [
      {
        "Type": { "Name": "Iron Ore" },
        "Count": 1
      },
      {
        "Type": { "Name": "Coal" },
        "Count": 0.125
      }
    ],
    "Equipment": [
      { "Name": "Furnace" }
    ]
  },
  {
    "Result": {
      "Type": { "Name": "Iron Shovel" },
      "Count": 1
    },
    "Ingredients": [
      {
        "Type": { "Name": "Iron Ingot" },
        "Count": 1
      },
      {
        "Type": { "Name": "Stick" },
        "Count": 2
      }
    ],
    "Equipment": [
      { "Name": "Crafting Table" }
    ]
  }
]
```

Each recipe element has several parts:
- `Result` declares the yieled item type and quantity.
- `Ingredients` lists the required items and quantities, and should include the required fuel as one element.
- `Equipment` lists the required "tools", if any. _(Ex. Crafting Table, Furnace, etc.)_

If a recipe file mentions an item that is not in a loaded item file, the program will error.

If an item in an item file does not have any associated recipe, it is treated as a primitive item. In the example above, since we have not listed a Stick recipe, the calculation will treat Stick as primitive.

Ultimately, it would be great to parse this data from Minecraft or mod files. The challenge with that is that items and recipes are not treated as data, and instead are "hardcoded" into source. (At least in the Java version.) Because of this, mods do not need to represent items and recipes in a uniform way.

## Issues
- If you make a typo in the _Desired Result_ section, the program will error.  It would be nicer if the cells were drop-down lists, not text fields.
- You must manually create the required JSON files. 
    - If you add an item to a recipe file without adding to an item file, the program will error.
    - If you forget to add a recipe for an item, it will be treated as primitive.
- Circular recipes are not supported _(Ex. 1 Glowstone -> 3 Glowstone Dust and 4 Glowstone Dust -> 1 Glowstone)_. In cases like this you must only add whichever recipe is more important to you.
