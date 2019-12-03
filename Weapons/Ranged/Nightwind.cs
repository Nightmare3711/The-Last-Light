using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace NightmaresModContent.Items.Weapons.Ranged
{
	public class Nightwind : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightwind");
			Tooltip.SetDefault("'Turns arrows into Nightmare arrows'");
		}
		public override void SetDefaults()
		{
			item.ranged = true;
            item.damage = 422;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 2000; //20 Silver
			item.rare = 1; //? rarity
			item.UseSound = SoundID.Item7;
			item.autoReuse = true;
            item.shoot = ProjectileID.WoodenArrowFriendly;
            item.shootSpeed = 60f;
            item.noMelee = true;
            item.useAmmo = AmmoID.Arrow;
            //item.reuseDelay = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType("NightmariumBar"), 12);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        /* Fix maybe?
         * public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == AmmoID.Arrow) // or ProjectileID.WoodenArrowFriendly
            {
                type = mod.ProjectileType("NightmareArrow"); // or ProjectileID.FireArrow;
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }
        */

        // How can I get a "Clockwork Assault Rifle" effect?
        // 3 round burst, only consume 1 ammo for burst. Delay between bursts, use reuseDelay
        /*	The following changes to SetDefaults()
		 	item.useAnimation = 12;
			item.useTime = 4;
			item.reuseDelay = 14;
        */
		public override bool ConsumeAmmo(Player player)
		{
			// Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
			// We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
			return !(player.itemAnimation < item.useAnimation - 2);
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 10 + Main.rand.Next(3); // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(20);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("NightmareArrow"), damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}
