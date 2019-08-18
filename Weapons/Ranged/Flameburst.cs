using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Weapons.Ranged
{
	public class Flameburst : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flameburst");
			Tooltip.SetDefault("'Turns arrows into hellfire arrows'");
		}
		public override void SetDefaults()
		{
			item.ranged = true;
            item.damage = 320;
			item.useTime = 30;
			item.useAnimation = 50;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 2000; //20 Silver
			item.rare = 1; //Red rarity
			item.UseSound = SoundID.Item7;
			item.autoReuse = true;
            item.shoot = ProjectileID.HellfireArrow;
            item.shootSpeed = 12f;
            item.noMelee = true;
            item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PyroniumBar"), 13);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == AmmoID.Arrow) // or ProjectileID.Bullet
            {
                type = ProjectileID.HellfireArrow; // or ProjectileID.FireArrow;
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }
    }
}
