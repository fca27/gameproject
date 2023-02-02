using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    class CampaignManager : ICampaignService
    {
        public void add(Campaign campaign)
        {
            Console.WriteLine("kampanya eklendi");
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine("kampanya silindi");
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine("kampanya güncellendi");
        }
    }
}
