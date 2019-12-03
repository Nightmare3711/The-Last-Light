using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresMod.Items.Placeables.WorkStations
{
	public class NightmareWorkStation : ModItem
	{
		public override void SetDefaults()
        {
			item.width = 22;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 10;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.createTile = mod.TileType("NightmareWorkStation");
		}

		/*public override void AddRecipes() 
         * {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("VoidMonolith"));
			recipe.AddIngredient(mod.ItemType("ElementResidue"));
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
	}
}