using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Ship
    {
        private List<Pirate> _crew;

        private bool hasCaptain()
        {
            foreach (var pirate in _crew)
            {
                if (pirate is Captain)
                {
                    return true;
                }
            }

            return false;
        }

        public bool addPirate(Pirate pirate)
        {
            if (pirate is Captain && this.hasCaptain())
            {
                return false;
            }

            _crew.Add(pirate);
            return true;
        }

        public int GetCrewSize()
        {
            return _crew.Count;
        }

        public List<string> GetPoorPirates()
        {
            List<string> poorPirates = new List<string>();

            foreach(var pirate in _crew)
            {
                if (pirate.IsPoor())
                {
                    poorPirates.Add(pirate.GetName());
                }
            }

            return poorPirates;
        }

        public int GetTotalGold()
        {
            int total = 0;

            foreach(var pirate in _crew)
            {
                total += pirate.GetGoldAmount();
            }

            return total;
        }

        public void LastDayOnTheShip()
        {
            foreach (var pirate in _crew)
            {
                pirate.Party();
            }
        }

        public void PrepareForBattle()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (var pirate in _crew)
                {
                    pirate.Work();
                }
            }

            this.LastDayOnTheShip();
        }
    }
}
