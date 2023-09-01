﻿namespace SuperCarteInfiniMVC.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Attack { get; set; }
        public int Defense { get; set; }
        public string ImageUrl { get; set; } = "";

        public override bool Equals(object other)
        {
            return other is Card c &&
                (c.Id, c.Name, c.Attack, c.Defense, c.ImageUrl)
                    .Equals((Id, Name, Attack, Defense, ImageUrl));
        }

    }
}
