﻿using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
	{
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesofTheWeek { get; }
        Pie? GetPieById(int pieId);
    }
}

