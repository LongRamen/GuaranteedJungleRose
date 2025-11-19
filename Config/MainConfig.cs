using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace GuaranteedJungleRose.Config
{
    public class MainConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Range(0f, 1f)]
        [DefaultValue(1f)]
        public float JungleRoseDropChance;
    }
}
