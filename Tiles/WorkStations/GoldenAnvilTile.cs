using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace NightmaresMod.Tiles.WorkStations
{
	public class GoldenAnvilTile : ModTile
	{
		public override void SetDefaults()
        {
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.CoordinateHeights = new[] { 16 };
			TileObjectData.addTile(Type);
			//AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Golden Anvil");
			AddMapEntry(new Color(220, 175, 20), name);
			//dustType = mod.DustType("Sparkle");
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Anvils };
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
        {
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
			Item.NewItem(i * 16, j * 16, 32, 16, ItemType<Items.Placeables.WorkStations.GoldenAnvil>());
		}
	}
}