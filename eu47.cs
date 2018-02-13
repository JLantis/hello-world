using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Eu47
{
	public class eu47
	{
		public static void Main(string[] args)
		{	
			string s1 = "";//enthält 1. Dateinamen
			string s2 = "";//enhält lezten Dateinamen
			Console.WriteLine("Erstellt eine csv oder xls Datei für eine Anzahl von Eu-Durchstrahlungen");
			Console.WriteLine("Version 0.1");
			Console.WriteLine("========================================================================");
			Console.WriteLine("");
			Console.WriteLine("ersten Dateinamen eingeben");
			s1 = Console.ReadLine();
			Console.WriteLine("letzten Dateinamen eingeben");
			s2 = Console.ReadLine();
			Console.WriteLine("von {0} bis {1}", s1, s2);
			
			Console.ReadLine();//um die Kommandozeile offen zu lassen
        }
	}
}
