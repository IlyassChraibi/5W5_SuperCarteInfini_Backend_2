using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperCarteInfiniMVC.Models;
using System;

namespace SuperCarteInfiniMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "11111111-1111-1111-1111-111111111113", Name = "Admin", NormalizedName = "ADMIN" }
            );

            // Creation des users
            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            IdentityUser admin = new IdentityUser
            {
                Id = "11111111-1111-1111-1111-111111111111",
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                // La comparaison d'identity se fait avec les versions normalisés
                NormalizedEmail = "ADMIN@ADMIN.COM",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                EmailConfirmed = true
            };
            // On encrypte le mot de passe
            admin.PasswordHash = hasher.HashPassword(admin, "Passw0rd!");
            builder.Entity<IdentityUser>().HasData(admin);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = admin.Id, RoleId = "11111111-1111-1111-1111-111111111113" }
            );

            /*builder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "2", Name = "Player", NormalizedName = "PLAYER" }
           );*/

            // Creation des users
            PasswordHasher<IdentityUser> hasher2 = new PasswordHasher<IdentityUser>();
            IdentityUser player = new IdentityUser
            {
                Id = "11111111-1111-1111-1111-111111111112",
                UserName = "player@player.com",
                Email = "player@player.com",
                // La comparaison d'identity se fait avec les versions normalisés
                NormalizedEmail = "PLAYER@PLAYER.COM",
                NormalizedUserName = "PLAYER@PLAYER.COM",
                EmailConfirmed = true
            };
            // On encrypte le mot de passe
            player.PasswordHash = hasher2.HashPassword(player, "Passw0rd!");
            builder.Entity<IdentityUser>().HasData(player);

            /*builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = player.Id, RoleId = "2" }
            );*/


            Card card1 = new Card
            {
                Id = 1,
                Name = "A",
                Attack = 1,
                Defense = 2,
                ImageUrl = "dijdjj"

            };
            builder.Entity<Card>().HasData(card1);


            Card card2 = new Card
            {
                Id = 2,
                Name = "B",
                Attack = 2,
                Defense = 1,
                ImageUrl = "dijdjj"


            };

            builder.Entity<Card>().HasData(card2);


            Card card3 = new Card
            {
                Id = 3,
                Name = "C",
                Attack = 2,
                Defense = 2,
                ImageUrl = "dijdjj"


            };
            builder.Entity<Card>().HasData(card3);



            Player playerTest = new Player
            {
                Id = 1,
                Name = "Tester",
                Money = 100,
                IdentityUserId = player.Id,
                //IdentityUser = player,

            };

            builder.Entity<Player>().HasData(playerTest);


            //ASK TEACHER SAYS "The seed entity for entity type 'OwnedCard'
            //cannot be added because no value was provided for the required property 'CardId'."
            builder.Entity<OwnedCard>().HasData(new[] {
                new { Id = 1, CardId = card1.Id, PlayerId = playerTest.Id },
                new { Id = 2, CardId = card2.Id, PlayerId = playerTest.Id },
                new { Id = 3, CardId = card3.Id, PlayerId = playerTest.Id }
            });


        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Player> Players { get; set; }
        public List<OwnedCard> OwnedCards { get; private set; }
    }
}