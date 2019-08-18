using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Weapons.Melee
{
	public class TheNightmare : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmare");
			Tooltip.SetDefault("'The sword of a lost yet powerul soul'"
                + "\nThe first item added into the mod!");
		}
		public override void SetDefaults()
		{
			item.damage = 3711;
            item.crit = 2;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 3200000; //3 Platinum, 20 Gold
			item.rare = 10; //Red rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 2f;
            item.shoot = mod.ProjectileType("NightmareProjectile");
            item.shootSpeed = 30f;
		}

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("NightmariumDust"));
            }
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.BreakerBlade, 1);
            recipe.AddIngredient(ItemID.TerraBlade, 1);
            //recipe.AddIngredient(ItemID.TheHorsemansBlade, 1);
            //recipe.AddIngredient(ItemID.InfluxWaver, 1);
            //recipe.AddIngredient(ItemID.Meowmere, 1);
            //recipe.AddIngredient(ItemID.StarWrath, 1);
            //recipe.AddIngredient(ItemID.DD2SquireBetsySword, 1);
            recipe.AddIngredient(mod.ItemType("NightmariumBar"), 13);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("NightmareBolt"), damage = 700, knockBack, player.whoAmI);

                // Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
                // By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
}
