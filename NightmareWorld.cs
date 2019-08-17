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

 Nightmare's-Temp-Stuff
        /*public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
 master
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
 Nightmare's-Temp-Stuff
        }*/

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            // Because world generation is like layering several images ontop of each other, we need to do some steps between the original world generation steps.

            // The first step is an Ore. Most vanilla ores are generated in a step called "Shinies", so for maximum compatibility, we will also do this.
            // First, we find out which step "Shinies" is.
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                // Next, we insert our step directly after the original "Shinies" step. 
                // ExampleModOres is a method seen below.
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Farozite Ore", FaroziteOre));
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Redtide Ore", RedtideOre));
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Pyronium Ore", PyroniumOre));
            }

            // This second step that we add will go after "Traps" and follows the same pattern.
            /*int TrapsIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Traps"));
            if (TrapsIndex != -1)
            {
                tasks.Insert(TrapsIndex + 1, new PassLegacy("Example Mod Traps", ExampleModTraps));
            }*/

            /*int LivingTreesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Living Trees"));
            if (LivingTreesIndex != -1)
            {
                tasks.Insert(LivingTreesIndex + 1, new PassLegacy("Post Terrain", delegate (GenerationProgress progress)
                {
                    // We can inline the world generation code like this, but if exceptions happen within this code 
                    // the error messages are difficult to read, so making methods is better. This is called an anonymous method.
                    progress.Message = "What is it Lassie, did Timmy fall down a well?";
                    MakeWells();
                }));
            }*/
        }

        private void FaroziteOre(GenerationProgress progress)
        {
            // progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes. 
            progress.Message = "Generating Farozite";

            // Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
            // "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
            for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-04); k++)
            {
                // The inside of this for loop corresponds to one single splotch of our Ore.
                // First, we randomly choose any coordinate in the world by choosing a random x and y value.
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

                // Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
                Tile tile = Framing.GetTileSafely(x, y); // Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
                if (tile.active() && tile.type == TileID.SnowBlock)
                {
                    WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 4), WorldGen.genRand.Next(2, 100), mod.TileType("FaroziteOreTile"), false, 0f, 0f, false, true);
                }
            }
        }

        private void RedtideOre(GenerationProgress progress)
        {
            // progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes. 
            progress.Message = "Generating Redtide";

            // Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
            // "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
            for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-04); k++)
            {
                // The inside of this for loop corresponds to one single splotch of our Ore.
                // First, we randomly choose any coordinate in the world by choosing a random x and y value.
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next(500, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

                // Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
                Tile tile = Framing.GetTileSafely(x, y); // Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
                if (tile.active() && tile.type == TileID.Sand)
                {
                    WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(1, 2), WorldGen.genRand.Next(2, 3), mod.TileType("RedtideOreTile"), false, 0f, 0f, false, true);
                }
            }
        }

        private void PyroniumOre(GenerationProgress progress)
        {
            // progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes. 
            progress.Message = "Generating Pyronium in the world";

            // Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
            // "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
            for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 3E-05); k++)
            {
                // The inside of this for loop corresponds to one single splotch of our Ore.
                // First, we randomly choose any coordinate in the world by choosing a random x and y value.
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next(2200, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

                // Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
                Tile tile = Framing.GetTileSafely(x, y); // Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
                WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 4), WorldGen.genRand.Next(999, 1000), mod.TileType("PyroniumOreTile"), false, 0f, 0f, false, true);
            }
        }
    }
}

        }
    }
}
 master
