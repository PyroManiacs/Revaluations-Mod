using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
    public class CursedMetal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Forged from the waters of Poisidon.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(null, "CursedDust", 3);
            recipe.AddTile(null, "CursedForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}
