using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Weapons.Magic
{
    public class Dreadstorm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dreadstorm");
            Tooltip.SetDefault("'Summons a dark cloud to rain darkness on your foes.'");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.value = 120000; //12 gold
            item.rare = 10; //Red
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.scale = 1f;
            item.magic = true; //Item type
            item.mana = 24; //Mana usage
            item.shootSpeed = 15f;
            item.noMelee = true; //Item itself does not deal damage
            item.shoot = mod.ProjectileType("DreadstormCloud");
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
