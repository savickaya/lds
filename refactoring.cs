//подпись: Савицкая Алина 1521501-3Б
//Разработать приложение «Личные дела студентов». Приложение предназначено для хранения личных карточек студентов 
//(которые содержат: пол, дату рождения, место рождения, место проживания и т. п.) в деканате и отделе кадров. 
//Сведения должны храниться в течение всего срока обучения студентов и использоваться при составлении справок и отчетов.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LichnieDelaStudentov
{
    public class Student
    {
       
        protected string name; 
        protected int course; 
        protected string pol; 
        protected string date; 
        protected string born; 
        protected string live; 

   
        public Student(string name, int course, string pol, string date, string born, string live)
        {
            this.name = name;
            this.course = course;
            this.pol = pol;
            this.date = date;
            this.born = born;
            this.live = live;
        }

   
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Born
        {
            get { return born; }
            set { born = value; }
        }

        public string Live
        {
            get { return live; }
            set { live = value; }
        }

  
        public void Print()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Фио: " + name);
            Console.WriteLine("Курс: " + course);
            Console.WriteLine("Пол: " + pol);
            Console.WriteLine("Дата рождения: " + date);
            Console.WriteLine("Место рождения: " + born);
            Console.WriteLine("Место проживания: " + live);
        }
    }

  
    public class Spravka : Student
    {
     
        protected string nom; 

       
        public Spravka(string nom, string name, int course, string pol, string date, string born, string live) :
            base(name, course, pol, date, born, live)
        {
         
            this.nom = nom; 
            base.name = name; 
            this.course = course; 
            this.pol = pol;
            this.date = date;
            this.born = born;
            this.live = live;


        }

 
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

  
        public new void Print() 
        {
            Console.Write("СПРАВКА №" + nom + " ВЫДАНА СТУДЕНТУ: ");
            base.Print(); 
            Console.WriteLine(" ");

        }
    }

    public class Otchet : Student
    {
      
        protected string topic; 

    
        public Otchet( string name, int course, string pol, string date, string born, string live, string topic) :
            base(name, course, pol, date, born, live)
        {
            NewMethodBase(name); 
            this.course = course; 
            this.pol = pol;
            this.date = date;
            this.born = born;
            this.live = live;
            this.topic = topic; 
        }

        private void NewMethodBase(string name)
        {
            base.name = name;
        }

  
        public string Topic
        {
            get { return topic; }
            set { NewMethodTopic(value); }
        }

        private void NewMethodTopic(string value)
        {
            topic = value;
        }

   
        public new void Print() 
        {
            Console.Write("СТУДЕНТ: ");
            base.Print(); 
            Console.WriteLine(topic + "ПЕРЕВЕДЕН НА СЛЕДУЮЩИЙ КУРС!");
            Console.WriteLine(" ");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          

            Student st1 = new Student("Иванов И.И.", 1, "Мужской", "20.01.2004", "Тула", "Тула");
            Student st2 = new Student("Сидоров О.И.", 1, "Мужской", "20.05.2004", "Тула", "Щекино");
            Student st3 = new Student("Петрова А.А.", 1, "Женский", "01.12.2004", "Тула", "Кимовск");
            Student st4 = new Student("Макаров Е.Я.", 1, "Мужской", "14.03.2004", "Тула", "Щекино");
            Student st5 = new Student("Беляева Е.А.", 1, "Женский", "18.07.2004", "Тула", "Тула");
            Student st6 = new Student("Котова К.Ю.", 2, "Женский", "26.05.2003", "Тула", "Тула");
            Student st7 = new Student("Цветкова Я.В.", 2, "Женский", "09.01.2003", "Москва", "Тула");
            Student st8 = new Student("Гришин О.И.", 2, "Мужской", "15.02.2003", "Тула", "Калуга");
            Student st9 = new Student("Григорьев Д.Е.", 2, "Мужской", "24.11.2003", "Тула", "Тула");
            Student st10 = new Student("Овечкий Ю.В.", 2, "Мужской", "29.03.2003", "Тула", "Щекино");
            Student st11 = new Student("Орехов В.И.", 3, "Мужской", "30.06.2002", "Тула", "Тула");
            Student st12 = new Student("Александров Б.Ю.", 3, "Мужской", "31.12.2002", "Тула", "Шатск");
            Student st13 = new Student("Белоусова В.А.", 3, "Женский", "14.01.2002", "Тула", "Шатск");
            Student st14 = new Student("Громова Д.А.", 3, "Женский", "07.03.2002", "Тула", "Узловая");
            Student st15 = new Student("Иванова Е.В.", 3, "Женский", "10.09.2002", "Тула", "Тула");
            Student st16 = new Student("Васьков В.В.", 4, "Мужской", "23.04.2001", "Тула", "Узловая");
            Student st17 = new Student("Малинина Л.Д.", 4, "Женский", "18.12.2001", "Тула", "Тула");
            Student st18 = new Student("Кадетов О.И.", 4, "Мужской", "23.08.2001", "Тула", "Тула");
            Student st19 = new Student("Юрьев Ю.Ю.", 4, "Мужской", "11.11.2001", "Калуга", "Тула");
            Student st20 = new Student("Лазарев С.С.", 4, "Мужской", "27.01.2001", "Тула", "Тула");

            Console.WriteLine("Выполнила Савицкая Алина");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("Dela - вывести личные дела студентов");
            Console.WriteLine("Spravka - вывести справки");
            Console.WriteLine("Otchet - вывести отчет");
            string n; 
            n = Console.ReadLine();
            switch (n)
            {
                case "Dela":
                    Console.WriteLine("===ЛИЧНЫЕ ДЕЛА ВСЕХ СТУДЕНТОВ===");
                    st1.Print();
                    st2.Print();
                    st3.Print();
                    st4.Print();
                    st5.Print();
                    st6.Print();
                    st7.Print();
                    st8.Print();
                    st9.Print();
                    st10.Print();
                    st11.Print();
                    st12.Print();
                    st13.Print();
                    st14.Print();
                    st15.Print();
                    st16.Print();
                    st17.Print();
                    st18.Print();
                    st19.Print();
                    st20.Print();
                    break;

                case "Spravka":
                    Spravka spr1 = new Spravka("5 о временной нетрудоспособности студента", st1.Name, st1.Course, st1.Pol, st1.Date, st1.Born, st1.Live);
                    Spravka spr5 = new Spravka("290 о заселении в общажитие", st5.Name, st5.Course, st5.Pol, st5.Date, st5.Born, st5.Live);
                    Spravka spr8 = new Spravka("124 об отчислении", st8.Name, st8.Course, st8.Pol, st8.Date, st8.Born, st8.Live);
                    Spravka spr20 = new Spravka("76 для материальной помощи", st20.Name, st20.Course, st20.Pol, st20.Date, st20.Born, st20.Live);

                    Console.WriteLine("---------------------");
                    Console.WriteLine("===СПРАВКИ ДЛЯ СТУДЕНТОВ===");
                    Console.WriteLine(" ");
                    spr1.Print();
                    spr5.Print();
                    spr8.Print();
                    spr20.Print();
                    break;
                case "Otchet":
                    Otchet ot1 = new Otchet(st1.Name, st1.Course, st1.Pol, st1.Date, st1.Born, st1.Live, "");
                    Otchet ot2 = new Otchet(st2.Name, st2.Course, st2.Pol, st2.Date, st2.Born, st2.Live, "");
                    Otchet ot3 = new Otchet(st3.Name, st3.Course, st3.Pol, st3.Date, st3.Born, st3.Live, "НЕ ");
                    Otchet ot4 = new Otchet(st4.Name, st4.Course, st4.Pol, st4.Date, st4.Born, st4.Live, "");
                    Otchet ot5 = new Otchet(st5.Name, st5.Course, st5.Pol, st5.Date, st5.Born, st5.Live, "");
                    Otchet ot6 = new Otchet(st6.Name, st6.Course, st6.Pol, st6.Date, st6.Born, st6.Live, "НЕ ");
                    Otchet ot7 = new Otchet(st7.Name, st7.Course, st7.Pol, st7.Date, st7.Born, st7.Live, "");
                    Otchet ot8 = new Otchet(st8.Name, st8.Course, st8.Pol, st8.Date, st8.Born, st8.Live, "");
                    Otchet ot9 = new Otchet(st9.Name, st9.Course, st9.Pol, st9.Date, st9.Born, st9.Live, "");
                    Otchet ot10 = new Otchet(st10.Name, st10.Course, st10.Pol, st10.Date, st10.Born, st10.Live, "");
                    Otchet ot11 = new Otchet(st11.Name, st11.Course, st11.Pol, st11.Date, st11.Born, st11.Live, "");
                    Otchet ot12 = new Otchet(st12.Name, st12.Course, st12.Pol, st12.Date, st12.Born, st12.Live, "");
                    Otchet ot13 = new Otchet(st13.Name, st13.Course, st13.Pol, st13.Date, st13.Born, st13.Live, "НЕ ");
                    Otchet ot14 = new Otchet(st14.Name, st14.Course, st14.Pol, st14.Date, st14.Born, st14.Live, "");
                    Otchet ot15 = new Otchet(st15.Name, st15.Course, st15.Pol, st15.Date, st15.Born, st15.Live, "");
                    Otchet ot16 = new Otchet(st16.Name, st16.Course, st16.Pol, st16.Date, st16.Born, st16.Live, "");
                    Otchet ot17 = new Otchet(st17.Name, st17.Course, st17.Pol, st17.Date, st17.Born, st17.Live, "НЕ ");
                    Otchet ot18 = new Otchet(st18.Name, st18.Course, st18.Pol, st18.Date, st18.Born, st18.Live, "");
                    Otchet ot19 = new Otchet(st19.Name, st19.Course, st19.Pol, st19.Date, st19.Born, st19.Live, "");
                    Otchet ot20 = new Otchet(st20.Name, st20.Course, st20.Pol, st20.Date, st20.Born, st20.Live, "");

                    Console.WriteLine("---------------------");
                    Console.WriteLine("===ОЧЕТ О ПЕРЕВОДЕ СТУДЕНТОВ НА СЛЕДУЮЩИЙ КУРС===");
                    ot1.Print();
                    ot2.Print();
                    ot3.Print();
                    ot4.Print();
                    ot5.Print();
                    ot6.Print();
                    ot7.Print();
                    ot8.Print();
                    ot9.Print();
                    ot10.Print();
                    ot11.Print();
                    ot12.Print();
                    ot13.Print();
                    ot14.Print();
                    ot15.Print();
                    ot16.Print();
                    ot17.Print();
                    ot18.Print();
                    ot19.Print();
                    ot20.Print();
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }

        }
    }
}
