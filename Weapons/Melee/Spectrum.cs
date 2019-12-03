using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Weapons.Melee
{
	public class Spectrum : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectrum");
            Tooltip.SetDefault("'A powerful beam sword'");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
            item.crit = 1;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 7f;
            item.value = 2; //2 copper
			item.rare = 10; //Red rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.3f;
            item.shoot = mod.ProjectileType("SpectrumRainbowProjectile");
            item.shootSpeed = 50f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
