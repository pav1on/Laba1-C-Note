using System;
using System.Collections.Generic;

namespace laba111
{
    class Program
    {
        public static Dictionary<int, Note> dictionary = new Dictionary<int, Note>();
        static void Main(string[] args)
        {

            int id = 1;
            int a = 0;
            string surname = null;
            string surname1 = null;
            bool surnameCheck = true;
            string name = null;
            string name1 = null;
            bool nameCheck = true;
            string country = null;
            string country1 = null;
            bool countryCheck = true;
            bool numberCheck = false;
            long number;
            bool dateCheck = false;
            DateTime date1 = new DateTime();
            string date = null;

            do
            {
                Console.WriteLine("Нажмите 1 для создания новой записи!");
                Console.WriteLine("Нажмите 2 для редактирования уже созданной записи!");
                Console.WriteLine("Нажмите 3 для удаления записей!");
                Console.WriteLine("Нажмите 4 для просмотра краткой информации всех записей!");
                Console.WriteLine("Нажмите 5 для просмотра информации всех записей!");
                Console.WriteLine("Нажмите 6 для выхода из программы!");

                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите фамилию (обязательное поле):");
                        do
                        {
                            surname1 = Console.ReadLine();
                            surnameCheck = String.IsNullOrWhiteSpace(surname1);
                            if (surnameCheck == false)
                            {
                                surname = surname1;
                            }
                            else
                            {
                                Console.WriteLine("Это поле ОБЯЗАТЕЛЬНО!!!");
                            }
                        } while (surnameCheck);
                        Console.Clear();
                        Console.WriteLine("Введите имя (обязательное поле):");
                        do
                        {
                            name1 = Console.ReadLine();
                            nameCheck = String.IsNullOrWhiteSpace(name1);
                            if (nameCheck == false)
                            {
                                name = name1;
                            }
                            else
                            {
                                Console.WriteLine("Это поле ОБЯЗАТЕЛЬНО!!!");
                            }
                        } while (nameCheck);
                        Console.Clear();
                        Console.WriteLine("Введите отчество (необязательное поле):");   
                        string patronymic = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Введите номер телефона (обязательное поле):");
                        do
            {
                            string number1 = Console.ReadLine();
                            numberCheck = Int64.TryParse(number1, out number);
                            if (number1 == null || numberCheck == false)
                            {
                                Console.WriteLine("Введите номер ПРАВИЛЬНО, ИСПОЛЬЗУЯ ТОЛЬКО ЦИФРЫ!!!");
                            }
                        } while (!numberCheck) ;
                        Console.Clear();
                        Console.WriteLine("Введите страну (обязательное поле):");
                        do
                        {
                            country1 = Console.ReadLine();
                            countryCheck = String.IsNullOrWhiteSpace(country1);
                            if (countryCheck == false)
                            {
                                country = country1;
                            }
                            else
                            {
                                Console.WriteLine("Это поле ОБЯЗАТЕЛЬНО!!!");
                            }
                        } while (countryCheck);
                        Console.Clear();
                        Console.WriteLine("Введите дату рождения (необязательное поле):");
                        do
                        {
                            string date2 = Console.ReadLine();
                            bool dateCheckNull = String.IsNullOrWhiteSpace(date2);
                            if (dateCheckNull == true)
                            {
                                dateCheck = true;
                                continue;
                            }
                            else
                            {
                                dateCheck = DateTime.TryParse(date2, out date1);
                                date = date1.ToString("dd.MM.yyyy");
                                if (dateCheck == false)
                                {
                                    Console.WriteLine("Введите дату ВЕРНО!!!");
                                }
                            }
                        } while (dateCheck == false);
                        Console.Clear();
                        Console.WriteLine("Введите организацию (необязательное поле):");
                        string organisation = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Введите должность (необязательное поле):");
                        string job = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Введите прочие заметки (необязательное поле):");
                        string notes = Console.ReadLine();
                        dictionary.Add(id, new Note(surname, name, patronymic, number, country, date, organisation, job, notes));
                        id = id + 1;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите Id записи, которую Вы хотите отредактировать!");
                        int newid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(dictionary[newid]);
                        Console.WriteLine("Введите поле записи, которое Вы хотите отредактировать!");
                        Console.WriteLine("Возможные варианты: имя/фамилия/отчество/телефон/страна/дата/огранизация/должность/заметки");
                        string pole = Console.ReadLine();
                        if (pole == "имя")
                        {
                            Console.WriteLine("Введите имя:");
                            dictionary[newid].Name = Console.ReadLine();
                        }
                        if (pole == "фамилия")
                        {
                            Console.WriteLine("Введите фамилию:");
                            dictionary[newid].Surname = Console.ReadLine();
                        }
                        if (pole == "отчество")
                        {
                            Console.WriteLine("Введите отчество:");
                            dictionary[newid].Patronymic = Console.ReadLine();
                        }
                        if (pole == "телефон")
                        {
                            Console.WriteLine("Введите номер телефона:");
                            dictionary[newid].Number = Convert.ToInt64(Console.ReadLine());
                        }
                        if (pole == "страна")
                        {
                            Console.WriteLine("Введите страну:");
                            dictionary[newid].Country = Console.ReadLine();
                        }
                        if (pole == "дата")
                        {
                            Console.WriteLine("Введите дату:");
                            DateTime newDate = new DateTime();
                            newDate = DateTime.Parse(Console.ReadLine());
                            dictionary[newid].Date = newDate.ToString("dd.MM.yyyy");
                        }
                        if (pole == "организация")
                        {
                            Console.WriteLine("Введите организацию:");
                            dictionary[newid].Organisation = Console.ReadLine();
                        }
                        if (pole == "должность")
                        {
                            Console.WriteLine("Введите должность:");
                            dictionary[newid].Job = Console.ReadLine();
                        }
                        if (pole == "заметки")
                        {
                            Console.WriteLine("Введите заметки:");
                            dictionary[newid].Notes = Console.ReadLine();
                        }

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите Id записи, которую Вы хотите удалить!");
                        int newiddd = Convert.ToInt32(Console.ReadLine());
                        dictionary.Remove(newiddd);
                        break;

                    case 4:
                        Console.Clear();
                        foreach (KeyValuePair<int, Note> item in Program.dictionary)
                        {
                            Console.WriteLine("Id: " + item.Key + "\nФамилия: " + item.Value.Surname + "\nИмя: " + item.Value.Name + "\nНомер телефона: " + item.Value.Number + "\n");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        foreach (KeyValuePair<int, Note> item in dictionary)
                        {
                            Console.WriteLine("Id: " + item.Key + "; " + item.Value.ToString());
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Такой команды нет, попробуйте еще раз!!!");
                        Console.WriteLine();
                        break;
                }
            } while (a!=6);
        }
    }

    public class Note
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public long Number { get; set; }
        public string Country { get; set; }
        public string Date { get; set; }
        public string Organisation { get; set; }
        public string Job { get; set; }
        public string Notes { get; set; }


        public Note(string surname, string name, string patronymic, long number, string country, string date, string organisation, string job, string notes)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Number = number;
            Country = country;
            Date = date;
            Organisation = organisation;
            Job = job;
            Notes = notes;
        }

        public override string ToString()
        {
            return "\nФамилия: " + Surname + "\nИмя: " + Name + "\nОтчество: " + Patronymic + "\nНомер телефона: " + Number + "\nСтрана: " + Country + "\nДата рождения: " + Date + "\nОрганизация: " + Organisation + "\nДолжность: " + Job + "\nЗаметки: " + Notes + "\n";

        }
    }
}

