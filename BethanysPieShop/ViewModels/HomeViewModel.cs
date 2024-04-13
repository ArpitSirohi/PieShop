using System;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
	public class HomeViewModel
	{
        public IEnumerable<Pie> PiesofTheWeek { get; }

        public HomeViewModel (IEnumerable<Pie> piesofTheWeek)
        {
            PiesofTheWeek = piesofTheWeek;
        }

    }
}

