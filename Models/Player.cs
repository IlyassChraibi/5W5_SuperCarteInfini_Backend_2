using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace SuperCarteInfiniMVC.Models
{
    public class Player
    {
		public Player()
		{
		}


		public int Id { get; set; }
		public string Name { get; set; } = "";
		public int Money { get; set; }
		public string IdentityUserId { get; set; } //REQUIRED
		[JsonIgnore]
		public virtual IdentityUser? IdentityUser { get; set; }
		// TODO: Ajouter les cartes du joueur
	}
}

