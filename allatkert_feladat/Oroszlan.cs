﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert_feladat
{
	internal class Oroszlan
	{
		private int sebesseg;
		private string nem;


		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public string Nem { get => nem; set => nem = value; }


		public Oroszlan(int sebesseg, string nem)
		{

			this.sebesseg = sebesseg;
			this.nem = nem;
		}


		public override string ToString()
		{
			return $"{sebesseg}, {nem}";
		}
	}
}
