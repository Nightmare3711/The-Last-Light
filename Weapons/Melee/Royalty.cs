using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Weapons.Melee
{
	public class Royalty : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royalty");
			Tooltip.SetDefault("'The ancient blade of a long-lost kingdom'");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
            item.crit = 2;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 3f;
			item.value = 120000; //12 gold
			item.rare = 9; //Cyan(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType("ReditdeBar"), 14);
            recipe.AddIngredient(ItemID.IronBroadsword, 1);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
