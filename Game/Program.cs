using System;
using GameProject.Concrete;
using GameProject.Concretes;
using GameProject.Entities;
using GameProject.Entity;


namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game()
            {
                id = 1,
                name = "cod",
                price = 23
            };
            Customer customer = new Customer()
            {
                id = 1,
                dateofBirth = new DateTime(2001, 1, 27),firstName="furkan",lastName="akbaba"
            };
            Campaign campaign = new Campaign()
            {
                id = 1,
                name = "%50"
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.add(campaign);

            SaleManager saleManager = new SaleManager();

        }
    }
}
