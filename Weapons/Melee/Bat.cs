using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Weapons.Melee
{
	public class Bat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Bat");
			Tooltip.SetDefault("'Hey batta batta, swing!'" +
                "Can shoot baseballs if you have them.");
		}
		public override void SetDefaults()
		{
			item.damage = 8;
            item.crit = 2;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1; //Swing
			item.knockBack = 7;
			item.value = 2000; //20 Silver
			item.rare = 0; //Grey Rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.scale = 1f;
            item.reuseDelay = 50;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 9);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
