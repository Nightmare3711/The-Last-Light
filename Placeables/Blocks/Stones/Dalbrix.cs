using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Placeables.Blocks.Stones
{
    public class Dalbrix : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dalbrix");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 10; // Speed before reuse
            item.useAnimation = 10; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 320000; // 32 gold
            item.rare = 7; //Lime rarity
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.maxStack = 999; // The maximum number you can have of this item.
            item.createTile = mod.TileType("DalbrixTile");
        }
    }
}