using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace NomadApp
{
	public class Client:Entity
	{
		public string Mail { set; get; }
		public string Phone { set; get; }
		public string Login { set; get; }
		public int Age { set; get; }
		public string Password { set; get; }
		//public SubscribeService sub;

		public void Print()
		{
			WriteLine
				(
				$"\nимя:   {Login}\n" +
				$"возраст: {Age}\n" +
				$"мэйл:    {Mail}\n" +
				$"телефон: {Phone}\n" +
				$"пароль:  {Password}");
		}
	}
}
