using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace NightmaresMod.Dusts
{
    public class CloudDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = false;
            dust.scale = 2f;
            dust.noLight = false;
        }

        public override bool Update(Dust dust)
        {
            /*float velXMult = 1f;
            dust.velocity /= velXMult;*/
            dust.position -= dust.velocity / 2;
            dust.rotation = dust.velocity.X;
            dust.scale -= 0.05f;
            if(dust.scale < 0.5f)
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
