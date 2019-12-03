using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresModContent.Items.Weapons.Melee
{
    public class Corona : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corona");
            Tooltip.SetDefault("'Wield just a fraction of the power of the sun.'");
        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 324;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 7f;
            item.value = 600000; //60 Gold
            item.rare = 10; //Red rarity
            item.UseSound = SoundID.Item7;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("CoronaProjectile");
            item.shootSpeed = 40f;
            item.noUseGraphic = true;
            item.noMelee = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DayBreak, 1);
            recipe.AddIngredient(ModContent.ItemType("PyroniumBar"), 13);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
