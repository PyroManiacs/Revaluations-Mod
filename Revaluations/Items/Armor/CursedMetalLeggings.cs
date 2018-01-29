using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class CursedMetalLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Forged in the Blood of the Gods."
                + "\n5% increased movement speed"
                + "\nImmunity to lava");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05f;
            player.lavaImmune = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CursedMetal", 45);
            recipe.AddIngredient(null, "CursedDust", 40);
            recipe.AddTile(null, "CursedForge");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}