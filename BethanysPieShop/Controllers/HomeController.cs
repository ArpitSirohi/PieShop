﻿using System;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
	public class HomeController:Controller
	{
		private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
		{
			var piesoftheWeek = _pieRepository.PiesofTheWeek;
			var homeViewModel = new HomeViewModel(piesoftheWeek);
			return View(homeViewModel);
		}
	}
}

