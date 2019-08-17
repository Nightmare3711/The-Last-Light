using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Armor.CelestiumArmor
{
    [AutoloadEquip(EquipType.Head)]

    public class CelestiumHelm : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestium Helm");
			Tooltip.SetDefault("'Something'");
		}
		public override void SetDefaults()
		{
            item.defense = 19;
            item.rare = 9;
            item.value = 32000000; //32 platinum
            item.width = 18;
            item.height = 18;
		}

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("CelestiumBar"), 7);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
