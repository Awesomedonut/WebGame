using System;
namespace WebGame.Models
{
    public class Villain : Enemy
    {
        public int attack { get; set; }

        public Villain()
        {
            attack = 50;
        }
    }
}

