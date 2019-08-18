using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresMod.Items.Weapons.Melee
{
	public class Shatter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shatter");
			Tooltip.SetDefault("'A sword capable of breaking equipment apart");
		}
		public override void SetDefaults()
		{
			item.damage = 172;
            item.crit = 13;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 1;
			item.knockBack = 12f;
			item.value = 500000; //50 gold
			item.rare = 8; //Yellow(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.scale = 1.3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BreakerBlade, 1);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
