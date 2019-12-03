using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Placeables.Blocks.Mushrooms
{
    public class PurpleMushroom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Mushroom");
            //Tooltip.SetDefault("'The essence of of the universe'");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 10; // Speed before reuse
            item.useAnimation = 30; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 900000; // 90 gold
            item.rare = 2; //Cyan rarity
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.maxStack = 999; // The maximum number you can have of this item.
            item.createTile = mod.TileType("PurpleMushroomTile");
        }
    }
}