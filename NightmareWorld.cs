using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;


namespace NightmaresMod
{
    public class NightmareWorld : ModWorld
    {

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (genIndex == -1)
            {
                return;
            }
            tasks.Insert(genIndex + 1, new PassLegacy("Nightmare Biome", delegate (GenerationProgress progress)
            {
                progress.Message = "Nightmare-ing the world"; //generation message
                for (int i = 0; i < Main.maxTilesX / 10000000000; i++)
                {
                    int X = WorldGen.genRand.Next(1, Main.maxTilesX - 300);
                    int Y = WorldGen.genRand.Next((int)WorldGen.rockLayerHigh - 100, Main.maxTilesY - 200);
                    int TileType = 30;     //This is the tile you want to use for the biome(what it's made out of)
                    WorldGen.TileRunner(X, Y, 500, WorldGen.genRand.Next(2000, 2500), TileType, false, 0f, 0f, true, true);
                }
            }));
        }
    }
}
