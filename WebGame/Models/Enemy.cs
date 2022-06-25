using System;
namespace WebGame.Models
{
    public class Enemy
    {
        public int health { get; set; }
        public int size { get; set; }


        public Enemy()
        {
            health = 10;
            size = 5;
        }
    }
}

