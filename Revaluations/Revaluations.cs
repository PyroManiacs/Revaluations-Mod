using Terraria.ModLoader;

namespace Revaluations
{
	class Revaluations : Mod
	{
		public Revaluations()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
