﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace NConsoler
{
	class Program
	{
		static void Main(string[] args)
		{
			Consoler.Run(typeof(Program), args);
		}

		// consoler.exe 10 "description" /b
		[Action]
		public static void Delete(
			[Required(Description = "Object count")]
			int count,

			[Required(Description = "Object description")]
			string description,

			[Optional(false, "b", "bk", Description = "Boolean value")]
			bool book,
			
			[Optional("")]
			string comment)
		{
			Console.WriteLine("Delete {0} {1} {2} {3}", count, description, book, comment);
		}
	}
}