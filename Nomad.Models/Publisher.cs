using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp
{
	public class Publisher : Entity
	{
		public string Name { get; set; }
		public ICollection<Client> Clients { get; set; }
		public ICollection<Journal> Journals { get; set; }

		public void Deliver()
		{

		}
		public void LoadMonthlyAnswer()
		{

		}
	}
}
