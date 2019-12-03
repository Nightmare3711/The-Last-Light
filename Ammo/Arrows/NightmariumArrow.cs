using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresModContent.Items.Ammo.Arrows
{
	public class NightmariumArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmarium Arrow");
			Tooltip.SetDefault("'Rips your foes asunder'");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
            item.crit = 7;
			item.ranged = true;
			item.knockBack = 5f;
			item.value = 2000; //20 Silver
			item.rare = 0; //Grey Rarity
            item.maxStack = 999;
            item.ammo = AmmoID.Arrow;
            item.shoot = mod.ProjectileType("NightmariumArrowProjectile");
            item.shootSpeed = 20f;
            item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType("NightmariumBar"), 2);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 9);
			recipe.AddRecipe();
		}
	}
}
