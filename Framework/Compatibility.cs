using MiniBars.Framework.Rendering;
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

        public static BarInformations CheckCompatibleMonster(Monster _monster)
        {
            string _prefix = "";
            if (_monster.isHardModeMonster.Value) _prefix = "Hardmode";

            BarInformations _informations = null;

            // RIDGESIDE VILLAGE
            if (ModEntry.instance.Helper.ModRegistry.IsLoaded("Rafseazz.RidgesideVillage"))
            {
                if (Game1.player.currentLocation.Name.StartsWith("Custom_Ridgeside"))
                {
                    if (_monster.Name == "Putrid Ghost")
                    {
                        _informations = Textures.barInformations.Find(x => x.monsterName == "Wraith");
                    }
                    else if (_monster.Name == "Shadow Brute")
                    {
                        _informations = Textures.barInformations.Find(x => x.monsterName == "Serpentine Beast");
                    }
                    else if (_monster.Name == "Pepper Rex")
                    {
                        _informations = Textures.barInformations.Find(x => x.monsterName == "Viperial");
                    }
                }
            }
            return _informations;
        }
    }
}
