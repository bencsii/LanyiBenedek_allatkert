using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert_feladat
{
	internal class Pingvin_class
	{
		private string nev;
		private int sebesseg;
		private string nem;

		public string Nev { get => nev; set => nev = value; }
		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public string Nem { get => nem; set => nem = value; }


		public Pingvin_class(string nev ,int sebesseg, string nem)
		{
			this.nev = nev;
			this.sebesseg = sebesseg;
			this.nem = nem;
		}


		public override string ToString()
		{
			return $"{nev},{sebesseg}, {nem}";
		}
	}


}
