﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int DiscountAmount { get; set; }
        public DateTime ExpiryDate { get; set; }

        
    }
}
