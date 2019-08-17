using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class NightmareProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nightmare");
        }
        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 27;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.damage = 700;
            projectile.tileCollide = false;
            projectile.timeLeft = 300;
            projectile.penetrate = -1;
            projectile.knockBack = 4;
            projectile.scale = 2f;
        }

        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 1.2f, .2f, 2f);
        }
    }
}
