using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ConsoleLesson31ofMay

{

    class Program

    {

        static void Main(string[] args)

        {

            #region person

            Console.WriteLine("PERSON");

            Person p = new Person("Qwe", "Deiw", "10-08-1992", 185, 77, "Man");

            p.Display();

            Person sec_p = new Person("Qwe", "Deiw", "10-08-1992", 185, 77, "Man");

            #endregion

            #region admin

            Console.WriteLine("ADMIN");

            Admin _admin = new Admin("Funduk", "Chockolate", "12-05-2001", 167, 71, "Man", 1);

            _admin.AdmDisplay();

            Admin sec_adm = new Admin("Funduk", "Chockolate", "Man", 1);

            #endregion

            #region manager

            Console.WriteLine("MANAGER");

            Manager _manger = new Manager("Kate", "Labovski", "03-05-1888", 159, 45, "Women", 2);

            _manger.MngDisplay();

            Manager sec_mng = new Manager("Kate", "Lyabovski", "Women", 2);

            #endregion

            #region user

            Console.WriteLine("USER");

            User _user = new User("Jack", "Rendom", "27-12-1996", 182, 67, "Man", 3);

            _user.UsrDisplay();

            User sec_usr = new User("Jack", "Rendom", "Man", 3);

            #endregion

            Console.ReadKey();

        }

    }

    class Person

    {

        public string Name;

        public string LastName;

        public string BirthDate;

        public int Height;

        public int Weight;

        public string Gender;

        #region FULLperson

        public Person(string name, string surname, string birthday, int height, int weight, string gender)

        {

            this.Name = name;

            this.LastName = surname;

            this.BirthDate = birthday;

            this.Height = height;

            this.Weight = weight;

            this.Gender = gender;

        }

        public void Display()

        {

            Console.WriteLine($"Данные:\n{Name}\n{LastName}\n{BirthDate}\n{Height}\n{Weight}\n{Gender}\n");

        }

        #endregion

        #region person

        public Person(string name, string surname, string birthday, string gender)

        {

            this.Name = name;

            this.LastName = surname;

            this.BirthDate = birthday;

            this.Gender = gender;

            Console.WriteLine($"Ваши основные данные:\n{Name}\n{LastName}\n{BirthDate}\n{Gender}\n");

        }

        public Person(string name, string surname, string gender)

        {

            this.Name = name;

            this.LastName = surname;

            this.Gender = gender;

        }

        #endregion

    }

    class Admin : Person

    {

        public byte AdminLow { get; set; }

        public Admin(string name, string surname, string birthday, int height, int weight, string gender, byte adlow)

        : base(name, surname, birthday, height, weight, gender)

        {

            this.AdminLow = adlow;

        }

        public void AdmDisplay()

        {

            Console.WriteLine($"Данные админа {Name}:\n{Name}\n{LastName}\n{BirthDate}\n{Height}\n{Weight}\n{Gender}\n{AdminLow}\n");

        }

        public Admin(string name, string surname, string gender, byte adlow)

        : base(name, surname, gender)

        {

            this.AdminLow = adlow;

            Console.WriteLine($"Основные данные админа {Name}:\n{Name}\n{LastName}\n{Gender}\n{AdminLow}\n");

        }

    }

    class Manager : Person

    {

        public byte ManagerLow { get; set; }

        public Manager(string name, string surname, string birthday, int height, int weight, string gender, byte mnglow)

        : base(name, surname, birthday, height, weight, gender)

        {

            this.ManagerLow = mnglow;

        }
        public void MngDisplay()

        {

            Console.WriteLine($"Данные менеджера {Name}:\n{Name}\n{LastName}\n{BirthDate}\n{Height}\n{Weight}\n{Gender}\n{ManagerLow}\n");

        }

        public Manager(string name, string surname, string gender, byte mnglow)

        : base(name, surname, gender)

        {

            this.ManagerLow = mnglow;

            Console.WriteLine($"Основные данные менеджера {Name}:\n{Name}\n{LastName}\n{Gender}\n{ManagerLow}\n");

        }

    }
    class User : Person

    {

        public byte UserLow { get; set; }

        public User(string name, string surname, string birthday, int height, int weight, string gender, byte usrlow)

        : base(name, surname, birthday, height, weight, gender)

        {

            this.UserLow = usrlow;

        }

        public void UsrDisplay()

        {

            Console.WriteLine($"Данные пользователя {Name}:\n{Name}\n{LastName}\n{BirthDate}\n{Height}\n{Weight}\n{Gender}\n{UserLow}\n");

        }


        public User(string name, string surname, string gender, byte usrlow)

        : base(name, surname, gender)

        {

            this.UserLow = usrlow;

            Console.WriteLine($"Основные данные пользователя {Name}:\n{Name}\n{LastName}\n{Gender}\n{UserLow}\n");

        }

    }


}