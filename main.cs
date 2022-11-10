//подпись: Савицкая Алина 1521501-3Б
//Разработать приложение «Личные дела студентов». Приложение предназначено для хранения личных карточек студентов 
//(которые содержат: пол, дату рождения, место рождения, место проживания и т. п.) в деканате и отделе кадров. 
//Сведения должны храниться в течение всего срока обучения студентов и использоваться при составлении справок и отчетов.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//класс отвечающий за личные данные о студентах
namespace LichnieDelaStudentov
{
    public class SubSystemStudent
    {
      //имя
        protected string name;
      //курс
        protected int course;
      //пол
        protected string pol;
      //дата рождения
        protected string date;
      //место рождения
        protected string born;
      //место жительсва
        protected string live;

//присваивание значений
        public SubSystemStudent(string name, int course, string pol, string date, string born, string live)
        {
          //присваивание свойству name значение name
            this.name = name;
          //присваивание свойству course значение course
            this.course = course;
          //присваивание свойству pol значение pol
            this.pol = pol;
          //присваивание свойству date значение date
            this.date = date;
          //присваивание свойству born значение born
            this.born = born;
          //присваивание свойству live значение live
            this.live = live;
        }

//получение значений имени студента
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
//получение значений курса студента
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
//получение значений пола студента
        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }
//получение значений даты рождения
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
      //получение значений места рждения
        public string Born
        {
            get { return born; }
            set { born = value; }
        }
//получение значений места жительства
        public string Live
        {
            get { return live; }
            set { live = value; }
        }

//вывод данных о студентах
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

    //класс с помощью которого можно создавать справки для студентов
    public class SubSystemSpravka : SubSystemStudent
    {

        protected string nom;

//присваивание значений
        public SubSystemSpravka(string nom, string name, int course, string pol, string date, string born, string live) :
            base(name, course, pol, date, born, live)
        {
//присваивание свойству  значение 
            this.nom = nom;
//присваивание свойству  значение 
            base.name = name;
//присваивание свойству  значение 
            this.course = course;
//присваивание свойству  значение 
            this.pol = pol;
//присваивание свойству  значение 
            this.date = date;
//присваивание свойству  значение 
            this.born = born;
//присваивание свойству  значение 
            this.live = live;


        }

//получение номера справки
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

//функция вывода справки
        public new void Print()
        {
            Console.Write("СПРАВКА №" + nom + " ВЫДАНА СТУДЕНТУ: ");
            base.Print();
            Console.WriteLine(" ");

        }
    }
    //класс с помощью которого можно создавать отчеты о студентах
    public class SubSystemOtchet : SubSystemStudent
    {

        protected string topic;


        public SubSystemOtchet(string name, int course, string pol, string date, string born, string live, string topic) :
            base(name, course, pol, date, born, live)
        {
            NewMethodBase(name);
//присваивание свойству  значение 
            this.course = course;
//присваивание свойству  значение 
            this.pol = pol;
//присваивание свойству  значение 
            this.date = date;
//присваивание свойству  значение 
            this.born = born;
//присваивание свойству  значение 
            this.live = live;
//присваивание свойству  значение 
            this.topic = topic;
        }

        private void NewMethodBase(string name)
        {
            base.name = name;
        }

//получение темы отчета
        public string Topic
        {
            get { return topic; }
            set { NewMethodTopic(value); }
        }

        private void NewMethodTopic(string value)
        {
            topic = value;
        }

//функция вывода отчета
        public new void Print()
        {
            Console.Write("СТУДЕНТ: ");
            base.Print();
            Console.WriteLine(topic + "ПЕРЕВЕДЕН НА СЛЕДУЮЩИЙ КУРС!");
            Console.WriteLine(" ");

        }
    }
    //класс с помощью которого можно работать с программой
    class FasadProgram
    {
        static void Main(string[] args)
        {

            //данные о студентах
            SubSystemStudent st1 = new SubSystemStudent("Иванов И.И.", 1, "Мужской", "20.01.2004", "Тула", "Тула");
            SubSystemStudent st2 = new SubSystemStudent("Сидоров О.И.", 1, "Мужской", "20.05.2004", "Тула", "Щекино");
            SubSystemStudent st3 = new SubSystemStudent("Петрова А.А.", 1, "Женский", "01.12.2004", "Тула", "Кимовск");
            SubSystemStudent st4 = new SubSystemStudent("Макаров Е.Я.", 1, "Мужской", "14.03.2004", "Тула", "Щекино");
            SubSystemStudent st5 = new SubSystemStudent("Беляева Е.А.", 1, "Женский", "18.07.2004", "Тула", "Тула");
            SubSystemStudent st6 = new SubSystemStudent("Котова К.Ю.", 2, "Женский", "26.05.2003", "Тула", "Тула");
            SubSystemStudent st7 = new SubSystemStudent("Цветкова Я.В.", 2, "Женский", "09.01.2003", "Москва", "Тула");
            SubSystemStudent st8 = new SubSystemStudent("Гришин О.И.", 2, "Мужской", "15.02.2003", "Тула", "Калуга");
            SubSystemStudent st9 = new SubSystemStudent("Григорьев Д.Е.", 2, "Мужской", "24.11.2003", "Тула", "Тула");
            SubSystemStudent st10 = new SubSystemStudent("Овечкий Ю.В.", 2, "Мужской", "29.03.2003", "Тула", "Щекино");
            SubSystemStudent st11 = new SubSystemStudent("Орехов В.И.", 3, "Мужской", "30.06.2002", "Тула", "Тула");
            SubSystemStudent st12 = new SubSystemStudent("Александров Б.Ю.", 3, "Мужской", "31.12.2002", "Тула", "Шатск");
            SubSystemStudent st13 = new SubSystemStudent("Белоусова В.А.", 3, "Женский", "14.01.2002", "Тула", "Шатск");
            SubSystemStudent st14 = new SubSystemStudent("Громова Д.А.", 3, "Женский", "07.03.2002", "Тула", "Узловая");
            SubSystemStudent st15 = new SubSystemStudent("Иванова Е.В.", 3, "Женский", "10.09.2002", "Тула", "Тула");
            SubSystemStudent st16 = new SubSystemStudent("Васьков В.В.", 4, "Мужской", "23.04.2001", "Тула", "Узловая");
            SubSystemStudent st17 = new SubSystemStudent("Малинина Л.Д.", 4, "Женский", "18.12.2001", "Тула", "Тула");
            SubSystemStudent st18 = new SubSystemStudent("Кадетов О.И.", 4, "Мужской", "23.08.2001", "Тула", "Тула");
            SubSystemStudent st19 = new SubSystemStudent("Юрьев Ю.Ю.", 4, "Мужской", "11.11.2001", "Калуга", "Тула");
            SubSystemStudent st20 = new SubSystemStudent("Лазарев С.С.", 4, "Мужской", "27.01.2001", "Тула", "Тула");
//меню
            Console.WriteLine("Выполнила Савицкая Алина");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("Dela - вывести личные дела студентов");
            Console.WriteLine("Spravka - вывести справки");
            Console.WriteLine("Otchet - вывести отчет");
            string n;
            n = Console.ReadLine();
//выборы меню          
            switch (n)
            {
//личные дела студентов                
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
//справки
                case "Spravka":
                    SubSystemSpravka spr1 = new SubSystemSpravka("5 о временной нетрудоспособности студента", st1.Name, st1.Course, st1.Pol, st1.Date, st1.Born, st1.Live);
                    SubSystemSpravka spr5 = new SubSystemSpravka("290 о заселении в общажитие", st5.Name, st5.Course, st5.Pol, st5.Date, st5.Born, st5.Live);
                    SubSystemSpravka spr8 = new SubSystemSpravka("124 об отчислении", st8.Name, st8.Course, st8.Pol, st8.Date, st8.Born, st8.Live);
                    SubSystemSpravka spr20 = new SubSystemSpravka("76 для материальной помощи", st20.Name, st20.Course, st20.Pol, st20.Date, st20.Born, st20.Live);
//вывод справки
                    Console.WriteLine("---------------------");
                    Console.WriteLine("===СПРАВКИ ДЛЯ СТУДЕНТОВ===");
                    Console.WriteLine(" ");
                    spr1.Print();
                    spr5.Print();
                    spr8.Print();
                    spr20.Print();
                    break;
//отчеты                
                case "Otchet":
                    SubSystemOtchet ot1 = new SubSystemOtchet(st1.Name, st1.Course, st1.Pol, st1.Date, st1.Born, st1.Live, "");
                    SubSystemOtchet ot2 = new SubSystemOtchet(st2.Name, st2.Course, st2.Pol, st2.Date, st2.Born, st2.Live, "");
                    SubSystemOtchet ot3 = new SubSystemOtchet(st3.Name, st3.Course, st3.Pol, st3.Date, st3.Born, st3.Live, "НЕ ");
                    SubSystemOtchet ot4 = new SubSystemOtchet(st4.Name, st4.Course, st4.Pol, st4.Date, st4.Born, st4.Live, "");
                    SubSystemOtchet ot5 = new SubSystemOtchet(st5.Name, st5.Course, st5.Pol, st5.Date, st5.Born, st5.Live, "");
                    SubSystemOtchet ot6 = new SubSystemOtchet(st6.Name, st6.Course, st6.Pol, st6.Date, st6.Born, st6.Live, "НЕ ");
                    SubSystemOtchet ot7 = new SubSystemOtchet(st7.Name, st7.Course, st7.Pol, st7.Date, st7.Born, st7.Live, "");
                    SubSystemOtchet ot8 = new SubSystemOtchet(st8.Name, st8.Course, st8.Pol, st8.Date, st8.Born, st8.Live, "");
                    SubSystemOtchet ot9 = new SubSystemOtchet(st9.Name, st9.Course, st9.Pol, st9.Date, st9.Born, st9.Live, "");
                    SubSystemOtchet ot10 = new SubSystemOtchet(st10.Name, st10.Course, st10.Pol, st10.Date, st10.Born, st10.Live, "");
                    SubSystemOtchet ot11 = new SubSystemOtchet(st11.Name, st11.Course, st11.Pol, st11.Date, st11.Born, st11.Live, "");
                    SubSystemOtchet ot12 = new SubSystemOtchet(st12.Name, st12.Course, st12.Pol, st12.Date, st12.Born, st12.Live, "");
                    SubSystemOtchet ot13 = new SubSystemOtchet(st13.Name, st13.Course, st13.Pol, st13.Date, st13.Born, st13.Live, "НЕ ");
                    SubSystemOtchet ot14 = new SubSystemOtchet(st14.Name, st14.Course, st14.Pol, st14.Date, st14.Born, st14.Live, "");
                    SubSystemOtchet ot15 = new SubSystemOtchet(st15.Name, st15.Course, st15.Pol, st15.Date, st15.Born, st15.Live, "");
                    SubSystemOtchet ot16 = new SubSystemOtchet(st16.Name, st16.Course, st16.Pol, st16.Date, st16.Born, st16.Live, "");
                    SubSystemOtchet ot17 = new SubSystemOtchet(st17.Name, st17.Course, st17.Pol, st17.Date, st17.Born, st17.Live, "НЕ ");
                    SubSystemOtchet ot18 = new SubSystemOtchet(st18.Name, st18.Course, st18.Pol, st18.Date, st18.Born, st18.Live, "");
                    SubSystemOtchet ot19 = new SubSystemOtchet(st19.Name, st19.Course, st19.Pol, st19.Date, st19.Born, st19.Live, "");
                    SubSystemOtchet ot20 = new SubSystemOtchet(st20.Name, st20.Course, st20.Pol, st20.Date, st20.Born, st20.Live, "");
//вывод отчетов
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
