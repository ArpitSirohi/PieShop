using System;
namespace BethanysPieShop.Models
{
	public class MockCategoryRepository:ICategoryRepository
	{
		public IEnumerable<Category> AllCategories =>
			new List<Category>
			{
				new Category {CategoryId=1,CategoryName="Fruit Pies", Description="All Fruit Pies"},
				new Category {CategoryId=2,CategoryName="Cheese Cake",Description="Chessy Cake"},
                new Category {CategoryId=3,CategoryName="Seasonal Pies",Description="Yeah Seasonal Pie"} 
            };
	
	}
}

	