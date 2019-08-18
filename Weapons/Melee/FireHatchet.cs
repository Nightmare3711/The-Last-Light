using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Weapons.Melee
{
	public class FireHatchet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fire Hatchet");
			Tooltip.SetDefault("'Used for chopping fires.'");
		}
		public override void SetDefaults()
		{
			item.damage = 13;
            item.crit = 2;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 1; //Swing
			item.knockBack = 7;
			item.value = 2000; //20 Silver
			item.rare = 1; //Blue Rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.axe = 10; //Works like an axe
            item.scale = 1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddIngredient(ItemID.IronBar, 7);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
