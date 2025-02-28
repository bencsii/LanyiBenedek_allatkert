using allatkert_feladat;

namespace allatkert_feladat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Allatkert allatkert = new Allatkert();

			allatkert.AllatokLista.Add(new Tigris("Tigris", 10, "hím"));


		}
	}
}

