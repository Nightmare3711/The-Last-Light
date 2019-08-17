using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresMod.Items.Tools
{
	public class CelestiumPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestium Pickaxe");
			Tooltip.SetDefault("'Rips things apart'");
		}
		public override void SetDefaults()
		{
			item.damage = 92;
            item.crit = 2;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 3;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 500000; //50 gold
			item.rare = 9; //Cyan(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.4f;
            item.pick = 270;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("CelestiumBar"), 12);
            recipe.AddTile(412);
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
