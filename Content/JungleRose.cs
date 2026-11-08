using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

using GuaranteedJungleRose.Config;

namespace GuaranteedJungleRose.Content;

public class JungleRose : GlobalTile
{
    public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
    {
        int tileStyle = Main.tile[i, j].TileFrameX / 18;

        if (!noItem && type == TileID.JunglePlants && (tileStyle == 6 || tileStyle == 7))
        {
            if (Main.rand.NextFloat() < MainConfig.Instance.JungleRoseDropChance)
            {
                IEntitySource source = WorldGen.GetItemSource_FromTileBreak(i, j);
                int X = i * 16;
                int Y = j * 16;

                Item.NewItem(source, X, Y, 0, 0, ItemID.JungleRose);
            }
            noItem = true;
        }
    }
}
