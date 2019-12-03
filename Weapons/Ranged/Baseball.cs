using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresModContent.Items.Weapons.Ranged
{
    public class Baseball : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Baseball");
        }
        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 8;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.knockBack = 3f;
            item.value = 2000; //20 Silver
            item.rare = 1; //Red rarity
            item.UseSound = SoundID.Item7;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BaseballProjectile");
            item.shootSpeed = 25f;
            item.noUseGraphic = true;
            item.scale = .5f;
            item.maxStack = 99;
            item.consumable = true;
        }
    }
}
