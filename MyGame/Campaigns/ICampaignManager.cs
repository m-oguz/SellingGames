using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    interface ICampaignManager
    {
        public void AddCampaign(Campaign campaign);
        public void DeleteCampaign(Campaign campaign);
        public void Modify(Campaign campaign, DateTime newExpiryDate);
        public void Modify(Campaign campaign, int discountAmount);
    }
}
