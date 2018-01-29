using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
    public class NightmareRed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nigthmare Red");
            Tooltip.SetDefault("This sword was forged in the fires of hell...");
        }
        public override void SetDefaults()
        {
            item.damage = 2583;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 80;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 15;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddIngredient(ItemID.FieryGreatsword, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
