using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace NightmaresModContent.Items.Weapons.Magic
{
    public class FistofFury : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fist of Fury");
            Tooltip.SetDefault("'Hiyaaa!'");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;
            item.value = 120000; //12 gold
            item.rare = 10; //Red
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.scale = 1f;
            item.magic = true; //Item type
            item.mana = 7; //Mana usage
            item.shootSpeed = 12f;
            item.noMelee = true; //Item itself does not deal damage
            item.shoot = mod.ProjectileType("FistofFuryProj");
            item.damage = 78;
            item.noMelee = true;
            item.channel = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NimbusRod);
            recipe.AddTile(412);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        // Even Arc style: Multiple Projectile, Even Spread 
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 3 + Main.rand.Next(3); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(45);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1.4f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
    }
}
