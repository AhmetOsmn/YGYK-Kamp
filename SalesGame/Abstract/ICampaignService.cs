using SalesGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesGame.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void BuyWithCampaign(Campaign campaign, Game game);
    }
}
