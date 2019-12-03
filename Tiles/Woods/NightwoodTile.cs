using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresMod.Tiles.Woods
{
    public class NightwoodTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("Nightwood");
            minPick = 240;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Nightwood");
            AddMapEntry(new Color(120, 30, 190), name);
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.05f;
            g = 0.04f;
            b = 0.05f;
        }
    }
}