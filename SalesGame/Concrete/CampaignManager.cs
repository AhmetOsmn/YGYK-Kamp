using SalesGame.Abstract;
using SalesGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesGame.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " eklendi.");
        }

        public void BuyWithCampaign(Campaign campaign, Game game)
        {
            Console.WriteLine("-----------------------------------");
            double NewPrice = game.UnitPrice - ((game.UnitPrice*campaign.Centage)/100);
            Console.WriteLine(game.Name + " oyununa, " + campaign.Name + " kampanyasi uygulandi.\nEski fiyati = " + game.UnitPrice + "\nYeni fiyati = " + Math.Round(NewPrice,1));
            Console.WriteLine("-----------------------------------");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " silindi.");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " guncellendi.");

        }
    }
}
