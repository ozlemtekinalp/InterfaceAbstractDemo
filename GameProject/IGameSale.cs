using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameSale
    {
        void Sale(Customer customer, Games games, Campaign campaign);
    }
}
