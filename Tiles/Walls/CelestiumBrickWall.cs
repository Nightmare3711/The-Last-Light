using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace NightmaresMod.Tiles.Walls
{
	public class CelestiumBrickWall : ModWall
	{
		public override void SetDefaults()
        {
			Main.wallHouse[Type] = true;
			//dustType = mod.DustType("Celestium");
			drop = mod.ItemType("CelestiumBrickWall");
			AddMapEntry(new Color(50, 0, 205));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
        {
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
			r = 0.5f;
			g = 0.4f;
			b = 0.5f;
		}
	}
}