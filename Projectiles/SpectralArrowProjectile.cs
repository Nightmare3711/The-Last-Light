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
            projectile.damage = 17;
            projectile.tileCollide = true;
            projectile.penetrate = 3;
            projectile.light = 2.5f;
            projectile.knockBack = 4;
            projectile.scale = 1f;
            projectile.arrow = true;
        }

        //When projectile hits the ground, drop the item version
        //Fix maybe?
        /*
        public override void Kill(int timeLeft)
        {
            if(projectile.owner == Main.myPlayer)
            {
                int item = Main.rand.NextBool(5) ? Item.NewItem[projectile.getRect[mod.ItemType("SpectralArrow")]] : 0;
            }
        }
        */
    }
}
