using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace NomadApp
{
	public class RegistrationService
	{
		const int nameMaxLength = 50;
		const int passwordMinLength = 5;
		const int minPhoneLength = 7;
		const int maxPhoneLength = 16;

		public Client client;

		private string _email;
		private string _phone;
		private string _fullName;
		private int _age;
		private string _password;

		public RegistrationService()
		{
			client = new Client();
		}
		//Mail
		public void CheckMail()
		{
			WriteLine("\nВведите мэйл [мэйл должен содержать @ и .]:");
			while (true)
			{
				_email = ReadLine();
				if (_email.Contains('@') == true && _email.Contains('.') == true
					&& _email.IndexOf('@') < _email.IndexOf('.'))
				{
					client.Mail = _email;
					break;
				}
				else { WriteLine("Неправильный мэйл! Смотри правила"); }
			}
		}
		//Phone
		public void CheckPhone()
		{
			while (true)
			{
				WriteLine("\nВведите ваш телефон [больше 7 и меньше 16 знаков" +
					" и можно использовать цифры,-,(),+]: ");
				_phone = ReadLine();

				if (string.IsNullOrWhiteSpace(_phone) == true)
				{
					WriteLine("телефон не должно быть пустым!");
				}
				if (_phone.Length > minPhoneLength && _phone.Length < maxPhoneLength)
				{
					foreach (char symbol in _phone)
					{
						if (symbol > '0' && symbol < '9' || symbol == '(' && symbol == ')'
							|| symbol == '+' || symbol == '-')
						{
							if (_phone[0] == '+' || _phone.Contains('+') == false
								|| _phone.IndexOf('(') < _phone.IndexOf(')'))
							{
								client.Phone = _phone;
								break;
							}
						}
					}
					break;
				}
				else { WriteLine("Вы ввели неправильный номер"); }
			}
		}
		//Name
		public void CheckFullName()
		{
			while (true)
			{
				WriteLine("\nВведите полное имя [не более 50 символов]: ");
				_fullName = ReadLine();

				if (string.IsNullOrWhiteSpace(_fullName) == true)
				{
					WriteLine("Имя должно быть не пустое!");
				}

				if (_fullName.Length > nameMaxLength)
				{
					_fullName = null;
					WriteLine("Логин не должен быть больше 50 символов\n");
				}
				else if (string.IsNullOrWhiteSpace(_fullName) == false
					&& _fullName.Length < nameMaxLength)
				{
					client.Login = _fullName;
					break;
				}
			}
		}
		//Password
		public void CheckPassword()
		{
			bool correct = false;
			WriteLine("\nВведите пароль [Пароль должен содержать верхний" +
				" и нижний регистр, цифру и символ]:");
			while (true)
			{
				_password = ReadLine();
				for (int i = 0; i < _password.Length; i++)
				{
					if (char.IsUpper(_password[i]) == true
						&& char.IsLower(_password[i]) == true
						&& char.IsSymbol(_password[i]) == true
						&& char.IsNumber(_password[i]) == true)
					{
						correct = true;
						break;
					}
					else if (i == _password.Length - 1) { WriteLine("Неправильный пароль!"); }
				}
				if (_password.Length < passwordMinLength && correct == false)
				{
					_password = null;
					WriteLine("Пароль должен быть больше 5 символов\n");
				}
				else
				{
					break;
				}
			}

			while (true)
			{
				WriteLine("Введите повторно пароль: ");
				string password = ReadLine();
				if (password != _password)
				{
					password = null;
					WriteLine("Пароль не совпадает!\n");
				}
				else
				{

					client.Password = _password;
					break;
				}
			}
		}
		//Age
		public void CheckAge()
		{
			bool correctAge = false;
			while (correctAge != true)
			{
				try
				{
					WriteLine("Ваш возраст [цифры]: ");
					_age = Convert.ToInt32(ReadLine());
				}
				catch
				{
					WriteLine("Вы ввели возраст не правильно!");
					continue;
				}
				correctAge = true;
				if (correctAge == true) client.Age = _age;
			}
		}
	}
}
