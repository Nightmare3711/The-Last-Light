using NightmaresMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresMod.Items.Weapons.Magic
{
	public class VoidLaser : ModItem
	{
		public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("Shoot a laser beam that can eliminate anything");
		}

		public override void SetDefaults()
        {
			item.damage = 513;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("VoidLaser");
			item.value = Item.sellPrice(silver: 3);
		}

		public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "NightmariumBar", 10);
			recipe.AddTile(mod, "NightmareWorkStation");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
