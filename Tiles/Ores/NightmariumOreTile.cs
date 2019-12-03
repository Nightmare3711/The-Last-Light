using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresMod.Tiles.Ores
{
    public class NightmariumOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = ModContent.ItemType("NightmariumOre");
            minPick = 250;
            dustType = mod.DustType("NightmariumDust");

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Nightmarium Ore");
            AddMapEntry(new Color(50, 10, 100), name);
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.4f;
            g = 0f;
            b = 0.5f;
        }
    }
}