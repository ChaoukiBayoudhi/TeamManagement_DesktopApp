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
        public List<int> getAllIds()
        {
            List<int> lstIds = new List<int>();
            //foreach (var x in LstPlayers)
            //{
            //    lstIds.Add(x.Id);

            //}
            //or
            for (int i = 0; i < LstPlayers.Count; i++)
            {
                lstIds.Add(LstPlayers[i].Id);
            }
            return lstIds;

        }
        public Player FindPlayerById(int id)
        {
            Player p1 = new Player();
            p1.Id = id;
            int index = LstPlayers.IndexOf(p1);
            if (index == -1)//le palyer n'existe pas
                return null;
            return LstPlayers[index];
        }
        public bool RemovePlayer(int id) 
        {
            Player p1 = new Player();
            p1.Id = id;
            int index = LstPlayers.IndexOf(p1);
            if (index == -1)//le palyer n'existe pas
                return false;
            LstPlayers.RemoveAt(index);
            return true;
        }
    }
}
