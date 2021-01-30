using System;

namespace MyDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();

			ogrenci.Add(101, "Ayşe Yaman");
			ogrenci.Add(102, "Ahmet Güzel");
			ogrenci.Add(103, "Meyrem Uzerli");
			ogrenci.Add(104, "Neslihan Atagül");
			ogrenci.Add(105, "Yasemin Ergene");
			ogrenci.Add(106,"Burak Özçivit");

		}
	}
}
