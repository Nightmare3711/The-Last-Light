using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresModContent.Items.Armor.PyroniumArmor
{
    [AutoloadEquip(EquipType.Body)]

    public class PyroniumChestplate : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pyronium Chestplate");
			Tooltip.SetDefault("'Protects the wearer against all thermal elements'");
		}
		public override void SetDefaults()
		{
            item.defense = 62;
            item.rare = 10;
            item.value = 70000000; //70 platinum
            item.width = 18;
            item.height = 18;
		}

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Wet] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType("PyroniumBar"), 23);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
