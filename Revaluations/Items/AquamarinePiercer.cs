using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
	public class AquamarinePiercer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquamarine Piercer");
			Tooltip.SetDefault("This sword held the power of the Light and Dark concealed from human hands for decades until now...");
		}
		public override void SetDefaults()
		{
			item.damage = 297;
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
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "WatertiteBar", 90);
            recipe.AddIngredient(null, "WatertiteSword", 1);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
