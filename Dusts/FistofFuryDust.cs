using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Dusts
{
    public class FistofFuryDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = false;
            dust.scale = 1.2f;
            dust.noLight = false;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity / 2;
            dust.rotation += dust.velocity.X * 200;
            dust.scale -= 0.03f;
            if(dust.scale < 0.5f)
            {
                dust.active = false;
            }

            {
                float strength = dust.scale * 3f;
                Lighting.AddLight((int)(dust.position.X / 16f), (int)(dust.position.Y / 16f), dust.color.R / 255f * 0.2f * strength, dust.color.G / 255f * 0.5f * strength, dust.color.B / 255f * 0.2f * strength);
            }
            return false;
        }

        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return new Color(lightColor.R, lightColor.G, lightColor.B, 26);
        }
    }
}
