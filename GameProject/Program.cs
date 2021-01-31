using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ayşe";
            customer1.LastName = "Kaya";
            customer1.NationalityId = "12456890532";
            customer1.DateOfBirth = new DateTime(1994, 2, 3);

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Ali";
            customer2.LastName = "Emin";
            customer2.NationalityId = "19853656572";
            customer2.DateOfBirth = new DateTime(1988, 7, 3);

            Campaign campaign1 = new Campaign() { Id = 12, CampaignName = "Kampanya1", CampaignRate = 25 };
            Campaign campaign2 = new Campaign() { Id = 22, CampaignName = "Kampanya2", CampaignRate = 10 };

            Games games1 = new Games() { Id = 1, GameName = "Oyun1", Price = 100 };
            Games games2 = new Games() { Id = 2, GameName = "Oyun2", Price = 200 };
            Games games3 = new Games() { Id = 3, GameName = "Oyun3", Price = 300 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);


            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(customer1, games1,campaign1);
        }
    }
}
