using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Weapons.Melee
{
	public class Bloodbath : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloodbath");
			Tooltip.SetDefault("'When spun, it shoots out light versions of itself'");
		}
		public override void SetDefaults()
		{
			item.damage = 211;
            item.crit = 2;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 600000; //60 Gold
			item.rare = 10; //Red rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 2f;
            item.shoot = mod.ProjectileType("BloodbathProjectile");
            item.noUseGraphic = true;
            item.channel = true;
            item.noMelee = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 13);
            recipe.AddIngredient(ModContent.ItemType("NightmariumBar"), 1);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
