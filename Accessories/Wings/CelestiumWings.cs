using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Accessories.Wings
{
    [AutoloadEquip(EquipType.Wings)]

    public class CelestiumWings : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestium Wings");
			Tooltip.SetDefault("Allows for flight and slow fall");
		}

		public override void SetDefaults()
		{
            item.defense = 3;
            item.rare = 10;
            item.value = 70000000; //70 platinum
            item.width = 18;
            item.height = 18;
            item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 3000;
        }

        //Fix maybe?
        /*
        public override void VerticalWingsSpeeds(ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultipliet, ref float maxAscentMultipler, ref float constantAscend)
        {
            ascentWhenFalling = 0.9f;
            ascentWhenRising = 0.1f;
            maxCanAscendMultiplier = 1.2f;
            maxAscentMultipler = 3.5f;
            constantAscend = -.125f;
        }
        */

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("CelestiumBar"), 16);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.2f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 20f;
            acceleration *= 2.5f;
        }
    }
}
