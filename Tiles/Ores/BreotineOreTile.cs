using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresMod.Tiles.Ores
{
    public class BreotineOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("NightmariumOre");
            minPick = 250;
            dustType = mod.DustType("NightmariumDust");

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Breotine Ore");
            AddMapEntry(new Color(50, 10, 100), name);
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0.25f;
            b = 0.25f;
        }
    }
}