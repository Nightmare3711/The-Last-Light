using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace NightmaresMod.Projectiles
{
    public class FistofFuryProjBig : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fist of Fury");
        }
        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.damage = 67;
            projectile.tileCollide = true;
            projectile.penetrate = -1;
            projectile.knockBack = 7;
            projectile.scale = 1.2f;
            projectile.arrow = true;
            projectile.alpha = 150;
            projectile.timeLeft = 20;
        }

        //When projectile hits the ground, drop the item version
        //Fix maybe?
        /*
        public override void Kill(int timeLeft)
        {
            if(projectile.owner == Main.myPlayer)
            {
                int item = Main.rand.NextBool(5) ? Item.NewItem[projectile.getRect[ModContent.ItemType("NightmariumArrow")]] : 0;
            }
        }
        */
        public override void AI()
        {
            projectile.velocity.Y += projectile.ai[1];
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("FistofFuryDust"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }

            Lighting.AddLight(projectile.Center, 1.2f, 2f, 1.2f);
        }

        public override void Kill(int timeLeft)
        {
            Vector2 usePos = projectile.position; // Position to use for dusts
                                                  // Please note the usage of MathHelper, please use this! We subtract 90 degrees as radians to the rotation vector to offset the sprite as its default rotation in the sprite isn't aligned properly.
            Vector2 rotVector =
                (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2(); // rotation vector to use for dust velocity
            usePos += rotVector * 50f;

            for (int i = 0; i < 20; i++)
            {
                Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, mod.DustType("FistofFuryDust")); //Create new dust
                dust.position = (dust.position + projectile.Center) / 2f;
                dust.velocity += rotVector * 2f;
                dust.velocity *= 2f;
                dust.noGravity = false;
                usePos -= rotVector * 2f;
            }

            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
        }
    }
}
