using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
    public class WatertiteOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Assembled from the blood of Poseidon.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
        }
    }
}
