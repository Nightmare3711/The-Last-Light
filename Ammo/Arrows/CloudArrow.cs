using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresMod.Items.Ammo.Arrows
{
	public class CloudArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cloud Arrow");
			Tooltip.SetDefault("'Light as a cloud'");
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
            item.shoot = mod.ProjectileType("CloudArrowProjectile");
            item.shootSpeed = 20f;
            item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Arrow"), 9);
            recipe.AddIngredient(ItemID.SoulofFlight, 1);
            recipe.AddIngredient(ItemID.Cloud, 5);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 9);
			recipe.AddRecipe();
		}
	}
}
