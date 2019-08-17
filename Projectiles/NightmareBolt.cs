using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class NightmareBolt : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nightmare Bolt");
            ProjectileID.Sets.Homing[projectile.type] = true;
        }
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 27;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.damage = 700;
            projectile.tileCollide = false;
            projectile.scale = 1f;
            projectile.timeLeft = 3 * 60; //Time left in seconds (60 frames per second)
            projectile.penetrate = 5;
        }

        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 1.2f, .2f, 2f);

            if (projectile.alpha > 70)
            {
                projectile.alpha -= 15;
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
            float distance = 400f;
            bool target = false;
            for (int k = 0; k < 200; k++)
            {
                if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5)
                {
                    Vector2 newMove = Main.npc[k].Center - projectile.Center;
                    float distanceTo = (float)Math.Sqrt(newMove.X * newMove.X + newMove.Y * newMove.Y);
                    if (distanceTo < distance)
                    {
                        move = newMove;
                        distance = distanceTo;
                        target = true;
                    }
                }
            }
            if (target)
            {
                AdjustMagnitude(ref move);
                projectile.velocity = (10 * projectile.velocity + move) / 11f;
                AdjustMagnitude(ref projectile.velocity);
            }
            if (projectile.alpha <= 100)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("NightmariumDust"));
                Main.dust[dust].velocity /= 10f;
            }
        }

        private void AdjustMagnitude(ref Vector2 vector)
        {
            float magnitude = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            if (magnitude > 17f) //Turn speed
            {
                vector *= 20f / magnitude; // Outward speed
            }
        }
    }
}