using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace Bloodsnguts
{
	public class InstaTNTBehavior : BlockBehavior
	{
		public static string NAME { get; } = "InstaTNT";

		public InstaTNTBehavior(Block block)
			: base(block) {  }

		public override bool OnBlockInteractStart(
			IWorldAccessor world, IPlayer byPlayer,
			BlockSelection blockSel, ref EnumHandling handling)
		{
			(world as IServerWorldAccessor)?.CreateExplosion(
				blockSel.Position, EnumBlastType.RockBlast, 10.0, 0.1, 2);
			handling = EnumHandling.PreventDefault;
			return true;
		}
	}
}
