using Portfolio.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared
{
    public static class PortfolioProvider
    {
        public static readonly SitePortfolio Portfolio = new()
        {
            Name = "Izzy Bodell",
            Nickname = "Izzy",
            Email = "izzybodell@gmail.com",
            PhoneNumber = "",
        };
    }
}
