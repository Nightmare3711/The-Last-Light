using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Weapons.Melee
{
	public class Shrike : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shrike");
			Tooltip.SetDefault("'A large blade of immense strength'");
		}
		public override void SetDefaults()
		{
			item.damage = 172;
            item.crit = 7;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 500000; //50 gold
			item.rare = 8; //Yellow(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.scale = 1.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BreakerBlade, 1);
            recipe.AddIngredient(ItemID.IronBar, 13);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
