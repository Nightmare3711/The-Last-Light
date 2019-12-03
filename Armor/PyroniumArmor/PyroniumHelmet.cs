using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresModContent.Items.Armor.PyroniumArmor
{
    [AutoloadEquip(EquipType.Head)]

    public class PyroniumHelmet : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pyronium Helmet");
			Tooltip.SetDefault("'Protects the wearer against all thermal elements'");
		}
		public override void SetDefaults()
		{
            item.defense = 41;
            item.rare = 10;
            item.value = 70000000; //70 platinum
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
			recipe.AddIngredient(ModContent.ItemType("PyroniumBar"), 8);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
