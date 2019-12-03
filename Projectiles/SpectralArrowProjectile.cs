using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class SpectralArrowProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectral Arrow");
        }
        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.damage = 52;
            projectile.tileCollide = true;
            projectile.penetrate = -1;
            projectile.light = 2.5f;
            projectile.knockBack = 4;
            projectile.scale = 1f;
            projectile.arrow = true;
        }

        public override void AI()
        {
            /*projectile.velocity.Y += projectile.ai[1];
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("NightmariumDust"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }

            Lighting.AddLight(projectile.Center, 1.2f, .2f, 2f);*/

            /*if (Main.rand.NextBool(3))
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("CloudDust"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }*/

            float velXMult = 1f;
            projectile.velocity.X *= velXMult;
            float velYMult = 0.0001f;
            projectile.velocity.Y += velYMult;

            float velRotation = projectile.velocity.ToRotation();

            projectile.rotation = velRotation + MathHelper.ToRadians(90f);
        }

        //When projectile hits the ground, drop the item version
        //Fix maybe?
        /*
        public override void Kill(int timeLeft)
        {
            if(projectile.owner == Main.myPlayer)
            {
                int item = Main.rand.NextBool(5) ? Item.NewItem[projectile.getRect[ModContent.ItemType("SpectralArrow")]] : 0;
            }
        }
        */
    }
}
