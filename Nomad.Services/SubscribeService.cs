using System;

namespace NomadApp
{
	public class SubscribeService
	{
		public int SelectSub { get; set; }
		public StatusSubs Status { get; set; }
		public int Price { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }

		public void PaySubscribe()
		{
			Console.WriteLine("Выберите подписку (1-3): " +
				"/n1 - (12 месяцев)" +
	            "/n2 - (24 месяцев)" +
                "/n3 - (36 месяцев)");
			switch (SelectSub)
			{
				case 1: Status = StatusSubs.first;  break;
				case 2: Status = StatusSubs.second; break;
				case 3: Status = StatusSubs.third;  break;
			}
		}
		public void CancelSubsricption()
		{
			Console.WriteLine("Отменить подписку");
		}
	}
}
