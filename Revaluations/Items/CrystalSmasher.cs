using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
    public class CrystalSmasher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Smasher");
            Tooltip.SetDefault("Holds the power of all elements.");
        }
        public override void SetDefaults()
        {
            item.damage = 591;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Dave");
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Topaz, 10);
            recipe.AddIngredient(ItemID.Diamond, 10);
            recipe.AddIngredient(ItemID.Sapphire, 10);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddIngredient(ItemID.Emerald, 10);
            recipe.AddIngredient(ItemID.Amethyst, 10);
            recipe.AddIngredient(ItemID.HallowedBar, 45);
            recipe.AddIngredient(ItemID.MythrilBar, 10);
            recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
            recipe.AddIngredient(ItemID.TrueExcalibur, 1);
            recipe.AddTile(null, "CrystalForge");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
