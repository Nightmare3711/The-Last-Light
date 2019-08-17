using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresMod.NPCs
{
    public class MyGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Zombie)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Baseball"), Main.rand.Next(0, 20)); // Place added drops specific to Frankenstein here
            }
            // Addtional if statements here if you would like to add drops to other vanilla npc.
        }
    }
}
