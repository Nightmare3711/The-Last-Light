using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresModContent.Items.Armor.FaroziteArmor
{
    [AutoloadEquip(EquipType.Legs)]

    public class FaroziteLeggings : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Farozite Leggings");
			Tooltip.SetDefault("'Protects the wearer against extreme temperatures'");
		}
		public override void SetDefaults()
		{
            item.defense = 23;
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
			recipe.AddIngredient(ModContent.ItemType("FaroziteBar"), 11);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
