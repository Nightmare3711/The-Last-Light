using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Projectiles
{
    public class BaseballProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Baseball");
        }

        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.damage = 13;
            projectile.tileCollide = true;
            projectile.scale = .5f;
            projectile.penetrate = 1;
            projectile.knockBack = 1f;
        }

        public override void Kill(int timeLeft)
        {
            // Make sure to only spawn items if you are the projectile owner.
            if (projectile.owner == Main.myPlayer)
            {
                // Drop a javelin item, 1 in 10 chance (~10% chance)
                int item =
                Main.rand.Next(10) == 0
                    ? Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, ItemType<Items.Weapons.Ranged.Baseball>())
                    : 0;

                // Sync the drop for multiplayer
                // Note the usage of Terraria.ID.MessageID, please use this!
                if (Main.netMode == 1 && item >= 0)
                {
                    NetMessage.SendData(MessageID.SyncItem, -1, -1, null, item, 1f);
                }
            }
        }
    }
}
