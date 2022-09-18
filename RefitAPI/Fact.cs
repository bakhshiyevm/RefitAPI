﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RefitAPI
{
	public class CatFact
	{
		[JsonPropertyName("fact")]
		public string Fact { get; set; }
		[JsonPropertyName("length")]
		public int Length { get; set; }
	}
}
