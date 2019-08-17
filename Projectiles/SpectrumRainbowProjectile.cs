using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class SpectrumRainbowProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectrum");
        }
        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.damage = 17;
            projectile.tileCollide = true;
            projectile.penetrate = 3;
            projectile.light = 2.5f;
            projectile.knockBack = 4;
            projectile.scale = 1f;
        }
    }
}
