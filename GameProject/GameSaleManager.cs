using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSaleManager : IGameSale
    {
        public void Sale(Customer customer,Games games,Campaign campaign)
        {

            int discount;
            discount = campaign.CampaignRate * games.Price / 100;
            int amount;
            amount = games.Price - discount;
     
         
         
            Console.WriteLine("Satın alan oyuncu:"+" "+customer.FirstName+" "+customer.LastName);
            Console.WriteLine("Satın aldığı oyun:"+ games.GameName);
            Console.WriteLine("Ödenecek tutar:"+ amount );
        }
    }
}
