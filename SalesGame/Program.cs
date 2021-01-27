using SalesGame.Abstract;
using SalesGame.Concrete;
using SalesGame.Entities;
using System;
using System.Collections.Generic;

namespace SalesGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEntity> games = new List<IEntity>();
            List<IEntity> palyers = new List<IEntity>();

            Campaign campaign1 = new Campaign {Name = "Pazartesi Kampanyasi", Centage = 10.5 };
            Campaign campaign2 = new Campaign { Name = "Carsamba Kampanyasi", Centage = 19.5 };
            Campaign campaign3 = new Campaign { Name = "Cuma Kampanyasi", Centage = 30.5 };


            Game game1 = new Game { Name = "Metin2", UnitPrice = 19.90, DateOfDevelopment = "2005" };
            Game game2 = new Game { Name = "Crysis2", UnitPrice = 30.00, DateOfDevelopment = "2008" };
            Game game3 = new Game { Name = "Cs Go", UnitPrice = 25.50, DateOfDevelopment = "2013" };
            Game game4 = new Game { Name = "PUBG", UnitPrice = 79.90, DateOfDevelopment = "2017" };

            Player palyer1 = new Player {Name = "Kursat Gurler", CustomerId = 1, NationalityId = "123", DateOfBirth = new DateTime(2000,3,17)};
            Player palyer2 = new Player { Name = "Ulas Avil", CustomerId = 2, NationalityId = "1234", DateOfBirth = new DateTime(2000, 3, 18)};
            Player palyer3 = new Player { Name = "Mert Altin", CustomerId = 3, NationalityId = "12345", DateOfBirth = new DateTime(2000, 3, 19)};
            Player palyer4 = new Player { Name = "Emre Doran", CustomerId = 4, NationalityId = "123456", DateOfBirth = new DateTime(2000, 3, 20)};
            Player palyer5 = new Player { Name = "Burak Guney", CustomerId = 5, NationalityId = "1234567", DateOfBirth = new DateTime(2000,3,21)};
            Player palyer6 = new Player { Name = "AHMET SEZGIN", CustomerId = 6, NationalityId = "12345678", DateOfBirth = new DateTime(2000, 3, 22)};



            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            IEntityService gameManager = new GameManager();
            ICampaignService campaignManager = new CampaignManager();
            

            gameManager.Add(game1, games);
            gameManager.Add(game2, games);
            gameManager.Add(game3, games);
            gameManager.Add(game4, games);
            gameManager.Show(games);

            playerManager.Add(palyer1, palyers);
            playerManager.Add(palyer2, palyers);
            playerManager.Add(palyer3, palyers);
            playerManager.Add(palyer4, palyers);
            playerManager.Add(palyer5, palyers);
            playerManager.Add(palyer6, palyers);

            playerManager.Show(palyers);

            //playerManager.Update(palyer6, "Ahmet Osman");
            //playerManager.Show(palyers);

            //playerManager.Delete(palyer6, palyers);
            //playerManager.Show(palyers);

            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.BuyWithCampaign(campaign1, game4);

            playerManager.Buy(palyer6, game4);
        }
    }
}
