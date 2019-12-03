using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresMod.Tiles.Ores
{
    public class FaroziteOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = ModContent.ItemType("FaroziteOre");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Farozite Ore");
            AddMapEntry(new Color(150, 200, 255), name);
            minPick = 230;
            dustType = DustID.Platinum;
            Main.tileLavaDeath[Type] = true;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.4f;
            g = 0.25f;
            b = 0.5f;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}