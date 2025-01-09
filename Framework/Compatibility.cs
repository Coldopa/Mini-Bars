using StardewValley;
using StardewValley.Monsters;

namespace MiniBars.Framework
{
    public class Compatibility
    {
        public static bool IsBlackListed()
        {
            if(ModEntry.instance.Helper.ModRegistry.IsLoaded("FlyingTNT.Swim") || ModEntry.instance.Helper.ModRegistry.IsLoaded("aedenthorn.Swim"))
            {
                if(Game1.player.currentLocation.Name.StartsWith("Custom_Underwater"))
                {
                    return true;
                }
            }
            
            if (Game1.player.currentLocation.Name == "Slime Hutch")
            {
                return true;
            }

            return false;
        }
    }
}
