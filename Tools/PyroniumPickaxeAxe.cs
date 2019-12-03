using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Tools
{
	public class PyroniumPickaxeAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pyronium Pickaxe Axe");
			Tooltip.SetDefault("'Will inflict a very painful flame effect'");
		}
		public override void SetDefaults()
		{
			item.damage = 92;
            item.crit = 2;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 5;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 500000; //50 gold
			item.rare = 9; //Cyan(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.4f;
            item.axe = 180;
            item.pick = 225;
		}

        /* Fix maybe?
        public override void OnHitNPC(int damage, float knockback, bool crit)
        {
            // Add Onfire buff to the NPC
            // 60 frames = 1 second
            target.AddBuff(BuffID.Burning, 18000); //5 minutes(?)
        }
        */

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType("PyroniumBar"), 13);
            recipe.AddTile(412);
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
