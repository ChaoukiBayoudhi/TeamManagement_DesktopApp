using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_project
{
    enum PlayerState { Injured, Safe}
    enum PlayerPosition
    {
        LeftBack,
        RightBack,
        GoalKeeper,
        CenterMiddle
    } 
    class Player
    {
        //proprieties
        //snippet prop + 2 time tab

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public PlayerState State { get; set; }
        public PlayerPosition Position { get; set; }

        //methods
        //snippet ctor + 2 time tab
        public Player()
        {
                
        }

        public Player(int Id, string name, DateTime birthDate, PlayerState state, PlayerPosition position)
        {
            this.Id = Id;
            Name = name;
            BirthDate = birthDate;
            State = state;
            Position = position;
        }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   Id == player.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
