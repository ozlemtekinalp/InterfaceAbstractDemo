using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaign
    {
         int Id{ get; set; }
        string CampaignName { get; set; }
        int CampaignRate { get; set; }

    }
}
