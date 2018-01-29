using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class WatertiteLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Forged in the Blood of the Gods."
                + "\nWater walking!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage *= 0.8f;
            player.waterWalk = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "WatertiteBar", 12);
            recipe.AddTile(null, "CrystalForge");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}