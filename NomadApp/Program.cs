using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Publisher publisher = new Publisher();
			Console.WriteLine("Добро пожаловать в Nomad Journals");
			Console.WriteLine("Пожалуйства зарегистрируетесь");

			RegistrationService registr = new RegistrationService();
			registr.CheckFullName();
			registr.CheckPassword();
			registr.CheckMail();
			registr.CheckPhone();
			registr.CheckAge();
			registr.client.Print();

			SubscribeService subscribe = new SubscribeService();
			subscribe.PaySubscribe();
			Console.WriteLine("");
			using (var context = new AppContext())
			{
				var ourJournal = new Journal
				{
					JournalNumber="203A",
					IsReady = true
				};
				var ourPublisher = new Publisher
				{
					Name="Nomad",
				};
				context.Clients.Add(registr.client);
				context.Journals.Add(ourJournal);
				context.Publishers.Add(ourPublisher);
				context.SaveChanges();
			};

			Console.ReadKey();
		}
	}
}
