using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Armor.FaroziteArmor
{
    [AutoloadEquip(EquipType.Body)]

    public class FaroziteChestplate : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Farozite Chestplate");
			Tooltip.SetDefault("'Protects the wearer against extreme temperatures'");
		}
		public override void SetDefaults()
		{
            item.defense = 26;
            item.rare = 9;
            item.value = 12000000; //12 platinum
            item.width = 18;
            item.height = 18;
		}

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("FaroziteBar"), 22);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
