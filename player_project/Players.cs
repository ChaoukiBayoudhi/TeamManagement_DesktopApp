using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_project
{
    class Players
    {
        public List<Player> LstPlayers { get; set; } = new List<Player>();

        public bool AddPlayer(Player p)
        {
            if (LstPlayers.Contains(p)) //Contains, IndexOf, LastIndexOf, ... utilisent une méthode prédefinie
                //qui s'appelle Equals. Equals compare deux objets et retourne un booléen (true si les deux objets sont equivalents)
                return false;
            LstPlayers.Add(p);
            return true;
        }
    }
}
