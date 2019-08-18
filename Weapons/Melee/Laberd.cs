using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresMod.Items.Weapons.Melee
{
	public class Laberd : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Laberd");
			Tooltip.SetDefault("'The sword of an epic hero'");
		}
		public override void SetDefaults()
		{
			item.damage = 210;
            item.crit = 5;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 500000; //50 gold
			item.rare = 9; //Cyan(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.scale = 1.7f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumSword, 1);
            recipe.AddIngredient(ItemID.AdamantiteSword, 1);
            recipe.AddIngredient(ItemID.Meowmere, 1);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
