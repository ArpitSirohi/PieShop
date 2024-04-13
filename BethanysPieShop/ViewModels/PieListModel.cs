using System;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
	public class PieListModel
	{
		public IEnumerable<Pie> Pies { get; }
		public string? CurrentCategory { get; }
		public PieListModel (IEnumerable<Pie>pies,String? currentCategory)
		{
			Pies = pies;
			CurrentCategory = currentCategory;
		}
	}
}

