using Microsoft.AspNetCore.Identity;

namespace SuperCarteInfiniMVC.Models
{
    public class OwnedCard
    {
        public int Id { get; set; }
        public Card Card { get; set; }
        public Player Player { get; set; }
    }
}
