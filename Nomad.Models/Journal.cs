using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp
{
	public class Journal:Entity
	{
		public string JournalNumber { get; set; }
		public bool IsReady { get; set; }
	}
}
