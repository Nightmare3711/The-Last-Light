using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Tools
{
	public class RedtidePickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Redtide Pickaxe");
			Tooltip.SetDefault("'Can mine faster while standing in water (one day)'");
		}
		public override void SetDefaults()
		{
			item.damage = 23;
            item.crit = 2;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 5;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 3f;
			item.value = 50000; //5 gold
			item.rare = 3; //Cyan(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.2f;
            item.pick = 65;
		}

        //Fix maybe?
        /*
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
			recipe.AddIngredient(ModContent.ItemType("RedtideBar"), 11);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
