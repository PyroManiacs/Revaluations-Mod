using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class WatertiteHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Forged in the blood of the Demons");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 5;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("RadioactiveRubyBreastplate") && legs.type == mod.ItemType("RadioactiveRubyLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage *= 0.8f;
            player.thrownDamage *= 0.8f;
            player.rangedDamage *= 0.8f;
            player.magicDamage *= 0.8f;
            player.minionDamage *= 0.8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "WatertiteBar" , 15);
            recipe.AddTile(null, "CrystalForge");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}