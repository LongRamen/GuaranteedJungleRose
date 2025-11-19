using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuaranteedJungleRose.Content
{
    public class JungleRose : GlobalTile
    {
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
			int tileStyle = Main.tile[i, j].TileFrameX / 18;
			if (!noItem && type == TileID.JunglePlants && (tileStyle == 6 || tileStyle == 7))
			{
				if (Main.rand.NextFloat() < ModContent.GetInstance<Config.MainConfig>().JungleRoseDropChance)
				{
					Item.NewItem(WorldGen.GetItemSource_FromTileBreak(i, j), i * 16, j * 16, 0, 0, ItemID.JungleRose);
				}
                noItem = true;
			}
		}
	}
}