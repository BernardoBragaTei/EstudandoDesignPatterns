using System;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Primeira Instância");
			SingletonClass s1 = SingletonClass.Instance;
			Console.WriteLine("Segunda Instância");
			SingletonClass s2 = SingletonClass.Instance;
			Console.WriteLine("Fim");
		}
	}
}
