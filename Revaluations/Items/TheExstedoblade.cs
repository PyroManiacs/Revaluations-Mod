using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
    public class TheExstedoblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Exstedoblade");
            Tooltip.SetDefault("This sword was the first sword to ever be forged in the avnvils of the Gods...");
        }
        public override void SetDefaults()
        {
            item.damage = 1583;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 60;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 60);
            recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddIngredient(ItemID.TrueExcalibur, 1);
            recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
            recipe.AddIngredient(ItemID.FieryGreatsword, 1);
            recipe.AddIngredient(ItemID.LightsBane, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
