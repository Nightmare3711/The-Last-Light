using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class StarManiaProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Mania");
            //ProjectileID.Sets.Homing[projectile.type] = true; I forget what this does
        }
        public override void SetDefaults()
        {
            /*
            projectile.width = 60;
            projectile.height = 60;
            projectile.aiStyle = 6;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.damage = 930;
            projectile.tileCollide = false;
            projectile.timeLeft = 300;
            projectile.penetrate = -1;
            projectile.alpha = 50;
            projectile.light = 1.7f;
            */
            projectile.CloneDefaults(ProjectileID.Starfury);
            aiType = ProjectileID.Starfury;

        }
    }
}
