using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresMod.Items.Weapons.Melee
{
	public class Pyromania : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pyromania");
			Tooltip.SetDefault("'Will inflict a very painful flame effect'");
		}
		public override void SetDefaults()
		{
			item.damage = 134;
            item.crit = 5;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 500000; //50 gold
			item.rare = 9; //Cyan(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.4f;
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
			recipe.AddIngredient(mod.ItemType("PyroniumBar"), 13);
            recipe.AddTile(412);
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
