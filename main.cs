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
    public class st
    {

        protected string name;
        protected int course;
        protected string pol;
        protected string date;
        protected string born;
        protected string live;


        public st(string name, int course, string pol, string date, string born, string live)
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


    public class sprvk : st
    {

        protected string nom;


        public sprvk(string nom, string name, int course, string pol, string date, string born, string live) :
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

    public class otch : st
    {

        protected string topic;


        public otch(string name, int course, string pol, string date, string born, string live, string topic) :
            base(name, course, pol, date, born, live)
        {
            base.name = name;
            this.course = course;
            this.pol = pol;
            this.date = date;
            this.born = born;
            this.live = live;
            this.topic = topic;
        }


        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }


        public new void Print()
        {
            Console.Write("СТУДЕНТ: ");
            base.Print();
            Console.WriteLine(topic + "ПЕРЕВЕДЕН НА СЛЕДУЮЩИЙ КУРС!");
            Console.WriteLine(" ");

        }
    }

    class prg
    {
        static void Main(string[] args)
        {


            st st1 = new st("Иванов И.И.", 1, "Мужской", "20.01.2004", "Тула", "Тула");
            st st2 = new st("Сидоров О.И.", 1, "Мужской", "20.05.2004", "Тула", "Щекино");
            st st3 = new st("Петрова А.А.", 1, "Женский", "01.12.2004", "Тула", "Кимовск");
            st st4 = new st("Макаров Е.Я.", 1, "Мужской", "14.03.2004", "Тула", "Щекино");
            st st5 = new st("Беляева Е.А.", 1, "Женский", "18.07.2004", "Тула", "Тула");
            st st6 = new st("Котова К.Ю.", 2, "Женский", "26.05.2003", "Тула", "Тула");
            st st7 = new st("Цветкова Я.В.", 2, "Женский", "09.01.2003", "Москва", "Тула");
            st st8 = new st("Гришин О.И.", 2, "Мужской", "15.02.2003", "Тула", "Калуга");
            st st9 = new st("Григорьев Д.Е.", 2, "Мужской", "24.11.2003", "Тула", "Тула");
            st st10 = new st("Овечкий Ю.В.", 2, "Мужской", "29.03.2003", "Тула", "Щекино");
            st st11 = new st("Орехов В.И.", 3, "Мужской", "30.06.2002", "Тула", "Тула");
            st st12 = new st("Александров Б.Ю.", 3, "Мужской", "31.12.2002", "Тула", "Шатск");
            st st13 = new st("Белоусова В.А.", 3, "Женский", "14.01.2002", "Тула", "Шатск");
            st st14 = new st("Громова Д.А.", 3, "Женский", "07.03.2002", "Тула", "Узловая");
            st st15 = new st("Иванова Е.В.", 3, "Женский", "10.09.2002", "Тула", "Тула");
            st st16 = new st("Васьков В.В.", 4, "Мужской", "23.04.2001", "Тула", "Узловая");
            st st17 = new st("Малинина Л.Д.", 4, "Женский", "18.12.2001", "Тула", "Тула");
            st st18 = new st("Кадетов О.И.", 4, "Мужской", "23.08.2001", "Тула", "Тула");
            st st19 = new st("Юрьев Ю.Ю.", 4, "Мужской", "11.11.2001", "Калуга", "Тула");
            st st20 = new st("Лазарев С.С.", 4, "Мужской", "27.01.2001", "Тула", "Тула");

            Console.WriteLine("Выполнила Савицкая Алина");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("Dela - вывести личные дела студентов");
            Console.WriteLine("Spravka - вывести справку");
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
                    sprvk spr1 = new sprvk("5 о временной нетрудоспособности студента", st1.Name, st1.Course, st1.Pol, st1.Date, st1.Born, st1.Live);
                    sprvk spr5 = new sprvk("290 о заселении в общажитие", st5.Name, st5.Course, st5.Pol, st5.Date, st5.Born, st5.Live);
                    sprvk spr8 = new sprvk("124 об отчислении", st8.Name, st8.Course, st8.Pol, st8.Date, st8.Born, st8.Live);
                    sprvk spr20 = new sprvk("76 для материальной помощи", st20.Name, st20.Course, st20.Pol, st20.Date, st20.Born, st20.Live);

                    Console.WriteLine("---------------------");
                    Console.WriteLine("===СПРАВКИ ДЛЯ СТУДЕНТОВ===");
                    Console.WriteLine(" ");
                    spr1.Print();
                    spr5.Print();
                    spr8.Print();
                    spr20.Print();
                    break;
                case "Otchet":
                    otch ot1 = new otch(st1.Name, st1.Course, st1.Pol, st1.Date, st1.Born, st1.Live, "");
                    otch ot2 = new otch(st2.Name, st2.Course, st2.Pol, st2.Date, st2.Born, st2.Live, "");
                    otch ot3 = new otch(st3.Name, st3.Course, st3.Pol, st3.Date, st3.Born, st3.Live, "НЕ ");
                    otch ot4 = new otch(st4.Name, st4.Course, st4.Pol, st4.Date, st4.Born, st4.Live, "");
                    otch ot5 = new otch(st5.Name, st5.Course, st5.Pol, st5.Date, st5.Born, st5.Live, "");
                    otch ot6 = new otch(st6.Name, st6.Course, st6.Pol, st6.Date, st6.Born, st6.Live, "НЕ ");
                    otch ot7 = new otch(st7.Name, st7.Course, st7.Pol, st7.Date, st7.Born, st7.Live, "");
                    otch ot8 = new otch(st8.Name, st8.Course, st8.Pol, st8.Date, st8.Born, st8.Live, "");
                    otch ot9 = new otch(st9.Name, st9.Course, st9.Pol, st9.Date, st9.Born, st9.Live, "");
                    otch ot10 = new otch(st10.Name, st10.Course, st10.Pol, st10.Date, st10.Born, st10.Live, "");
                    otch ot11 = new otch(st11.Name, st11.Course, st11.Pol, st11.Date, st11.Born, st11.Live, "");
                    otch ot12 = new otch(st12.Name, st12.Course, st12.Pol, st12.Date, st12.Born, st12.Live, "");
                    otch ot13 = new otch(st13.Name, st13.Course, st13.Pol, st13.Date, st13.Born, st13.Live, "НЕ ");
                    otch ot14 = new otch(st14.Name, st14.Course, st14.Pol, st14.Date, st14.Born, st14.Live, "");
                    otch ot15 = new otch(st15.Name, st15.Course, st15.Pol, st15.Date, st15.Born, st15.Live, "");
                    otch ot16 = new otch(st16.Name, st16.Course, st16.Pol, st16.Date, st16.Born, st16.Live, "");
                    otch ot17 = new otch(st17.Name, st17.Course, st17.Pol, st17.Date, st17.Born, st17.Live, "НЕ ");
                    otch ot18 = new otch(st18.Name, st18.Course, st18.Pol, st18.Date, st18.Born, st18.Live, "");
                    otch ot19 = new otch(st19.Name, st19.Course, st19.Pol, st19.Date, st19.Born, st19.Live, "");
                    otch ot20 = new otch(st20.Name, st20.Course, st20.Pol, st20.Date, st20.Born, st20.Live, "");

                    Console.WriteLine("---------------------");
                    Console.WriteLine("===ОТЧЕТ О ПЕРЕВОДЕ СТУДЕНТОВ НА СЛЕДУЮЩИЙ КУРС===");
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
