using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresMod.Tiles.Bricks
{
    public class RedtideBrickTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("RedtideBrick");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Redtide Brick");
            AddMapEntry(new Color(255, 100, 150), name);
            minPick = 20;
            dustType = DustID.Platinum;
            Main.tileLavaDeath[Type] = true;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.4f;
            g = 0.2f;
            b = 0.35f;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}