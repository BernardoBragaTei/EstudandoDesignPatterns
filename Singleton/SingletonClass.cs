using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class SingletonClass
	{
		private static SingletonClass instance;
		private static readonly object lockObject = new object();

		private SingletonClass()
		{
			Console.WriteLine("Executando o método construtor...");
		}

		public static SingletonClass Instance 
		{
			get
			{
				if (instance == null) //Verificação dupla para evitar bloqueios desnecessários
				{
					lock (lockObject) //Segurança para execução multithread
					{
						if (instance == null) 
							instance = new SingletonClass();
					}
				}
				return instance;

			}
		}

	}
}
