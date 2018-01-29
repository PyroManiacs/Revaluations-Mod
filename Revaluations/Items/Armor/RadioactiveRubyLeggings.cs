using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class RadioactiveRubyLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Forged in the Blood of the Gods."
                + "\n5% increased movement speed"
                + "\n increased health by 400");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 65;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05f;
            player.statLifeMax2 += 400;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 45);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}