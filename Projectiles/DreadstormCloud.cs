using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class DreadstormCloud : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dreadstorm Cloud");
        }
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 45;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.scale = .5f;
        }
    }
}
