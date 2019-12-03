using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class CelestiumBladeProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestium Blade");
        }
        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 24;
            projectile.aiStyle = 27;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.damage = 230;
            projectile.tileCollide = false;
            projectile.timeLeft = 300;
            projectile.penetrate = -1;
            projectile.knockBack = 4;
            projectile.scale = 2f;
        }

        public override void AI()
        {
            Lighting.AddLight(projectile.Center, .3f, .9f, 2f);

            if (projectile.alpha > 70)
            {
                projectile.alpha -= 50;
                if (projectile.alpha < 70)
                {
                    projectile.alpha = 70;
                }
            }

            if (projectile.localAI[0] == 0f)
            {
                AdjustMagnitude(ref projectile.velocity);
                projectile.localAI[0] = 5f;
            }

            Vector2 move = Vector2.Zero;
            float distance = 1000f;
            bool target = false;
            for (int k = 0; k < 200; k++)
            {
                if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5)
                {
                    Vector2 newMove = Main.npc[k].Center - projectile.Center;
                    float distanceTo = (float)Math.Sqrt(newMove.X * newMove.X + newMove.Y * newMove.Y);
                    if (distanceTo < distance)
                    {
                        move = newMove * 200;
                        distance = distanceTo / 200;
                        target = true;
                    }
                }
            }

            if (target)
            {
                AdjustMagnitude(ref move);
                projectile.velocity = (10 * projectile.velocity + move) / 2f;
                AdjustMagnitude(ref projectile.velocity);
            }

            if (projectile.alpha <= 100)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("CelestiumBladeDust"));
                Main.dust[dust].velocity /= 10f;
            }
        }

        private void AdjustMagnitude(ref Vector2 vector)
        {
            float magnitude = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            if (magnitude > 25f) //Turn speed
            {
                vector *= 30f / magnitude; // Outward speed
            }
        }
    }
}
