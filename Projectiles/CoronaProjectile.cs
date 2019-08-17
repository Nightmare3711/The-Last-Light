using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class CoronaProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corona");
        }

        public override void SetDefaults()
        {
            projectile.width = 46;
            projectile.height = 46;
            projectile.CloneDefaults(ProjectileID.PaladinsHammerFriendly);
            aiType = ProjectileID.PaladinsHammerFriendly;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.damage = 324;
            projectile.tileCollide = false;
            projectile.scale = 1.7f;
            projectile.penetrate = -1;
            projectile.alpha = 75;
            projectile.knockBack = 2f;
            Lighting.AddLight(projectile.Center, 0.9f, 0.2f, 0f);

            drawOffsetX = 0;
            drawOriginOffsetY = 6;
            drawOriginOffsetX = 6; //Hitbox offset
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 5 * 60, true);
            target.AddBuff(BuffID.Burning, 5 * 60, true);
        }


        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 2f, 1f, .5f); //Light effect (Red-Yellow)

            if (Main.rand.Next(1) == 0) //New dust particles
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, mod.DustType<Dusts.CoronaDust>(),
                    projectile.velocity.X * .5f, projectile.velocity.Y * .2f, 200, Scale: 1.6f);
                dust.velocity += projectile.velocity * 0.1f;
                dust.velocity *= 0.1f;
            }
            if (Main.rand.Next(2) == 0)
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, mod.DustType<Dusts.CoronaDust>(),
                    0, 0, 254, Scale: 0.3f);
                dust.velocity += projectile.velocity * 0.1f;
                dust.velocity *= 0.1f;
            }
        }
    }
}
