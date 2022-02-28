/*
 * Created by SharpDevelop.
 * User: TUF
 * Date: 2/26/2022
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tugas1._
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Nama kamu siapa?  ");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama saya "+nama);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}