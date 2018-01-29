using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
	public class TheFuryOfTheNight : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Fury Of The Night");
			Tooltip.SetDefault("Forged in the fire of Hades.");
		}
		public override void SetDefaults()
		{
			item.damage = 39;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 9;
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
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.WoodenSword, 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
