using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace NightmaresModContent.Items.Weapons.Magic
{
	public class NightStorm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Storm");
			Tooltip.SetDefault("'Brings the might of a Dark Star down upon your foes'");
		}

		public override void SetDefaults()
		{
			item.damage = 1200;
            item.crit = 2;
			item.magic = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 7f;
			item.value = 1200000; //1 Platinum, 20 Gold
			item.rare = 10; //Red rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.1f;
            item.shoot = mod.ProjectileType("NightStormProjectile");
            item.shootSpeed = 30f;
            item.noMelee = true;
            item.mana = 13;
            item.channel = true;
        }

        /*public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 3;
                item.useTime = 20;
                item.useAnimation = 20;
                item.damage = 50;
                item.shoot = mod.ProjectileType("NightStormProjectile");
            }
            else
            {
                item.useStyle = 1;
                item.useTime = 40;
                item.useAnimation = 40;
                item.damage = 100;
                item.shoot = 0;
                item.shoot = mod.ProjectileType("NightmareBolt");
            }
            return base.CanUseItem(player);
        }*/

            //The above thing is for alt usage

        /* Fix maybe?
        public override bool Shoot(ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            float ceilingLimit = target.Y;
            if (ceilingLimit > player.Center.Y - 200f)
            {
                ceilingLimit = player.Center.Y - 200f;
            }
            for (int i = 0; i < 3; i++)
            {
                position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                position.Y -= (100 * i);
                Vector2 heading = target - position;
                if (heading.Y < 0f)
                {
                    heading.Y *= -1f;
                }
                if (heading.Y < 20f)
                {
                    heading.Y = 20f;
                }
                heading.Normalize();
                heading *= new Vector2(speedX, speedY).Length();
                speedX = heading.X;
                speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
            }
            return false;
        }*/

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StarWrath, 1);
            recipe.AddIngredient(ItemID.Starfury, 1);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = mod.ProjectileType("NightStormProjectile");
            int numberProjectiles = 5 + Main.rand.Next(5);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.005f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.005f;  //this defines the projectile Y position speed and randomnes

                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, mod.ProjectileType("NightStormProjectile"), damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));

                //Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, (float)Main.rand.Next(5));
            }
            return false;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                //Emit dusts when swing the sword
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("NightmareDust"));
            }
        }
    }
}
