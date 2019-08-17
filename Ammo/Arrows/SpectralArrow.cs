using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Ammo.Arrows
{
	public class SpectralArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectral Arrow");
			Tooltip.SetDefault("'Brings the power of light upon your foes'");
		}
		public override void SetDefaults()
		{
			item.damage = 17;
            item.crit = 2;
			item.ranged = true;
			item.knockBack = 1.3f;
			item.value = 2000; //20 Silver
			item.rare = 0; //Grey Rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.scale = 1f;
            item.maxStack = 999;
            item.ammo = AmmoID.Arrow;
            item.shoot = mod.ProjectileType("SpectralArrowProjectile");
            item.shootSpeed = 8.5f;
            item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RainbowBrick, 2);
            recipe.AddIngredient(ItemID.WoodenArrow, 9);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 9);
			recipe.AddRecipe();
		}
	}
}
