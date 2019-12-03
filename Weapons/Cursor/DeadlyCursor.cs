using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Weapons.Cursor
{
	public class DeadlyCursor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Deadly Cursor");
            Tooltip.SetDefault("Allows the cursor to do damage");
		}
		public override void SetDefaults()
		{
			item.damage = 1000;
            item.crit = 2;
			item.melee = true;
			item.width =20;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 6;
			item.knockBack = 7f;
			item.value = 600000; //60 Gold
			item.rare = 10; //Red rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 2f;
            item.shoot = mod.ProjectileType("DeadlyCursorProjectile");
            item.noUseGraphic = true;
            item.channel = true;
            item.noMelee = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType("NightmariumBar"), 23);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
