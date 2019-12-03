using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace NightmaresMod.Dusts
{
    public class CelestiumDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.scale = 1.6f;
            dust.noLight = false;
            dust.frame = new Rectangle(5, Main.rand.Next(5) * 2, 20, 20);
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X * 0.01f;
            dust.scale -= 0.01f;
            if(dust.scale < 0.01f)
            {
                dust.active = false;
            }

            {
                float strength = dust.scale / .2f;
                Lighting.AddLight((int)(dust.position.X / 16f), (int)(dust.position.Y / 16f), dust.color.R / 255f * 0.5f * strength, dust.color.G / 255f * 0.5f * strength, dust.color.B / 255f * 0.5f * strength);
            }
            return false;
        }
    }
}
