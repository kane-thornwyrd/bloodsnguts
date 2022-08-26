using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo( "Bloods'n'Guts",
	Description = "R-rated gore and also useful stuffs related",
	Website     = "https://github.com/kane-thornwyrd/bloodsnguts",
	Version 		= "0.0.1",
	Authors     = new []{ "Kane Thornwyrd" } )]

namespace Bloodsnguts
{
	public class bloodsngutsMod : ModSystem
	{
		public override void Start(ICoreAPI api)
		{
			api.RegisterBlockBehaviorClass(InstaTNTBehavior.NAME, typeof(InstaTNTBehavior));
		}

		public override void StartClientSide(ICoreClientAPI api)
		{

		}

		public override void StartServerSide(ICoreServerAPI api)
		{

		}
	}
}
