using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Weapons.Melee
{
	public class Soulrapier : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul Rapier");
			Tooltip.SetDefault("'The blade of the ancients'");
		}
		public override void SetDefaults()
		{
			item.damage = 213;
            item.crit = 2;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 5;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 732000; // 73 Gold, 20 Silver
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 13);
            recipe.AddIngredient(ItemID.Ectoplasm, 4);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
