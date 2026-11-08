using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace GuaranteedJungleRose.Config;

internal class MainConfig : ModConfig
{
    public static MainConfig Instance;
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [Range(0f, 1f)]
    [DefaultValue(1f)]
    public float JungleRoseDropChance;
}
