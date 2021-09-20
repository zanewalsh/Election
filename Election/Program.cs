using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Election
{
	class Program
	{
		static void Main(string[] args)
		{
			var cans = new Dictionary<string, string>();
			var votes = new Dictionary<string, Int32>();
			int x = Int32.Parse(Console.ReadLine());
			for (int i = 0; i < x; i++)
			{
				cans.Add(Console.ReadLine(), Console.ReadLine());
			}
			Console.WriteLine("We have " + cans.Count + " cans");
			int voteNum = Int32.Parse(Console.ReadLine());
			for (int i = 0; i < voteNum; i++)
			{
				string vote = Console.ReadLine();
				if (votes.ContainsKey(vote))
				{
					votes[vote] += 1;
					Console.WriteLine("In here");
				}
				else
				{
					Console.WriteLine("Not here");
					votes.Add(vote, 1);
				}
			}
			Console.WriteLine("Scott has " + votes["Scott"] + " votes");
			Console.WriteLine("Kim has " + votes["Kim"] + " votes");
			var maxVal = votes.Values.Max();
			Console.WriteLine(maxVal);
		}
	}
}
