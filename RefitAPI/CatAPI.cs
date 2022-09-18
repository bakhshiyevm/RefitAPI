﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitAPI
{
	public interface CatAPI
	{
		[Get("/fact?{length?}")]
		Task<CatFact> GetFacts(int? length = null);
	}
}
