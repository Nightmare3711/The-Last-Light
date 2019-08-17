using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Placeables.Blocks.Bricks
{
    public class NightmariumBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nightmarium Brick");
            Tooltip.SetDefault("'The brick form of the truest form of darkness'");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 10; // Speed before reuse
            item.useAnimation = 10; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 240000; // 24 gold
            item.rare = 7; //Lime rarity
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.maxStack = 999; // The maximum number you can have of this item.
            item.createTile = mod.TileType("NightmariumBrickTile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("NightmariumBar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 25);
            recipe.AddRecipe();
        }
    }
}