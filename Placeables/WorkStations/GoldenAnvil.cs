using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace NightmaresMod.Items.Placeables.WorkStations
{
	public class GoldenAnvil : ModItem
	{
		public override void SetStaticDefaults()
        {
			//Tooltip.SetDefault("This is a modded workbench.");
		}

		public override void SetDefaults()
        {
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 15000;
			item.createTile = mod.TileType("GoldenAnvilTile");
		}

		public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(mod.ItemType("NightmariumBar"), 7);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}