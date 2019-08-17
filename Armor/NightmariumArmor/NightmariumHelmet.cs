using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Armor.NightmariumArmor
{
    [AutoloadEquip(EquipType.Head)]

    public class NightmariumHelmet : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmarium Helmet");
			Tooltip.SetDefault("'Protects the wearer against all'");
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
			recipe.AddIngredient(mod.ItemType("NightmariumBar"), 9);
            recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
