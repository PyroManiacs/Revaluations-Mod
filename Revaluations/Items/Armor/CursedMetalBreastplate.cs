using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class CursedMetalBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Cursed Metal Chestplate");
            Tooltip.SetDefault("Forge in the fires of Hades."
                + "\n+300 max health");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 300;
            player.lavaImmune = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CursedMetal", 16);
            recipe.AddIngredient(null, "CursedDust", 20);
            recipe.AddTile(null, "CursedForge");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
