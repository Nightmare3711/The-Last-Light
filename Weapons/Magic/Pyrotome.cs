using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresModContent.Items.Weapons.Magic
{
    public class Pyrotome : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pyrotome");
            Tooltip.SetDefault("'Shoots fireballs and whatnot'");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useTime = 10;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.value = 120000; //12 gold
            item.rare = 10; //Red
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.scale = 1f;
            item.magic = true; //Item type
            item.mana = 7; //Mana usage
            item.shootSpeed = 15f;
            item.noMelee = true; //Item itself does not deal damage
            item.shoot = ProjectileID.FireArrow;
            item.damage = 20;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NimbusRod);
            recipe.AddTile(412);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
