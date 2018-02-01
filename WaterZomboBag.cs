using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
    public class WaterZomboBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Water Zombo Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 11;
            item.expert = false;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            if (Main.rand.Next(7) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("WatertiteBar"), 8);
            }
            if (Main.rand.Next(10) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("WatertiteSword"), 1);
            }
            if (Main.rand.Next(16) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("WatertitePickaxe"));
            }
            if (Main.rand.Next(20) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("WatertiteWings"));
            }
            player.QuickSpawnItem(mod.ItemType("WatertiteOre"), 5);
        }
    }
}
