using System;

namespace ConsoleApp31
{
	class Program
	{
		//Tip delegata
		public delegate void NekiDelegat();

		static void Main(string[] args)
		{
			int? a = null;
			bool? b = null;
			int x = a.GetValueOrDefault() ;

			NekiDelegat nd = null;
			nd = Foo;
			nd += () => Console.WriteLine("Foo anon :)");
			nd?.Invoke();

			Console.WriteLine("--------------------");

			Neznam sabirac = new Neznam { op = (a, b) => a + b };
			Neznam oduzimac = new Neznam { op = (a, b) => a - b };

			Console.WriteLine(sabirac.op(5, 6));
			Console.WriteLine(oduzimac.op(5, 6));

			Console.ReadKey();
		}

		static void Foo()
		{
			Console.WriteLine("Foo");
		}
		static void Bar()
		{
			Console.WriteLine("Bar");
		}
	}

	class Neznam
	{
		public delegate int TipDel(int x, int y);
		public TipDel op;
	}
}
