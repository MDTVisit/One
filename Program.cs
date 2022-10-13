using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Program //64120501029 วิศิษฎ์ มโนมัยวิศิษฎ์ 
    {
        static int NumberBS = 0;
        static int NumberSSSS = 0;
        static int NumberT = 0;
        static int M4 = 0;
        static int M5 = 0;
        static int M6 = 0;
        static int introductionBS = 0;
        static string nameBS;
        static string surnameBS;
        static int introductionSSSS =0;
        static string nameSSSS;
        static string surnameSSSS;
        static int introductionT =0;
        static string nameT;
        static string surnameT;


        public static void Main(string[] args)
        {
            Console.WriteLine("[1.1.1.1]");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 Register");
            Console.WriteLine("2 Show statistics?");
            Console.WriteLine("3 Login");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) { Register(); }
            {
                if (n == 2) { SS(); }
            }
            {
                if (n == 3) { Login(); }
            }

            {
                if (n <= 4)
                    Console.WriteLine("ERROR ERROR ERROR ERROR Activate Self-Destruct");
            }


        }

        static void Rerun()
        {
            Console.Clear();
            Console.WriteLine("[1.1.1.1]"); //1.2
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 Register");
            Console.WriteLine("2 Show statistics?");
            Console.WriteLine("3 Login");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) { Register(); }
            {
                if (choice == 2) { SS(); }
            }
            {
                if (choice == 3) { Login(); }
            }

            {
                if (choice <= 4)
                    Console.WriteLine("ERROR ERROR ERROR ERROR Activate Self-destruct");

            }
        }
        static void Login()
        {
            Console.WriteLine("[1.1.1.2]"); //1.2
            Console.WriteLine("1 Login");
            Console.WriteLine("2 Show all BIGBOY Students");
            Console.WriteLine("3 Show all Smally Students");
            Console.WriteLine("4 Show all Teachers");
            Console.WriteLine("5 Log out");
            Console.WriteLine("6 Answering the option will take you to another step.");
            int Fake = int.Parse(Console.ReadLine());
            if (Fake == 1) { Register(); }
            if (Fake == 2) { BIGBOY(); }
            if (Fake == 3) { Smally(); }
            if (Fake == 4) { Teachers(); }
            if (Fake == 5) { Rerun(); }

            else if (Fake >= 6) { station(); }
        }

        static void station()
        { //1.2-1.7
            Console.Clear();
            Console.WriteLine("[1.1.1.3]"); //1.2
            Console.WriteLine("1 Register"); //1.2
            Console.WriteLine("2 Show statistics"); //1.4
            Console.WriteLine("3 Show all BIGBOY Students"); //1.5
            Console.WriteLine("4 Show all Smally Students"); //1.6
            Console.WriteLine("5 Show all Teachers"); //1.7
            Console.WriteLine("6 Log out"); //1.1
            int Anwser = int.Parse(Console.ReadLine());
            if (Anwser == 1) { Register(); }
            if (Anwser == 2) { SS(); }
            if (Anwser == 3) { BIGBOY(); }
            if (Anwser == 4) { Smally(); }
            if (Anwser == 5) { Teachers(); }
            if (Anwser >= 6) { Rerun(); }
        }




        static void BIGBOY() //1.5
        {
            int CheckS;
            Console.Clear();
            Console.WriteLine("Show all BIGBOY Students"); //1.5
            if (introductionBS == 1) 
                Console.WriteLine("Mr.");
            if (introductionBS == 2)
                Console.WriteLine("Mrs.");
            if (introductionBS == 3)
                Console.WriteLine("Miss.");
            Console.Write("Name :");
            Console.WriteLine(nameBS);
            Console.Write("SurnameBS : ");
            Console.WriteLine(surnameBS);
            Console.WriteLine("Complete! Would you like to go back to the menu?");
            Console.WriteLine("1 = Yes | 2 = YES | 3 = YES YES YES!");
            CheckS = int.Parse(Console.ReadLine());
            switch (CheckS)
            {
                case 1:
                    { Rerun(); }
                    break;
                case 2:
                    { Rerun(); }
                    break;
                case 3:
                    { Rerun(); }
                    break;
                default:
                    { Rerun(); }
                    break;
            }
        }
    
        static void Smally() //1.6
        {
            int CheckS;
            Console.Clear();
            Console.WriteLine("Show all Smally Students"); //1.5
            if (introductionSSSS == 1)
                Console.WriteLine("Mr.");
            if (introductionSSSS == 2)
                Console.WriteLine("Mrs.");
            if (introductionSSSS == 3)
                Console.WriteLine("Miss.");
            Console.Write("Name :");
            Console.WriteLine(nameSSSS);
            Console.Write("SurnameBS : ");
            Console.WriteLine(surnameSSSS);
            Console.WriteLine("Complete! Would you like to go back to the menu?");
            Console.WriteLine("1 = Yes | 2 = YES | 3 = YES YES YES!");
            CheckS = int.Parse(Console.ReadLine());
            switch (CheckS)
            {
                case 1:
                    { Rerun(); }
                    break;
                case 2:
                    { Rerun(); }
                    break;
                case 3:
                    { Rerun(); }
                    break;
                default:
                    { Rerun(); }
                    break;
            }
        }


        static void Teachers() //1.7
        {
            int CheckS;
            Console.Clear();
            Console.WriteLine("Show all Teachers"); //1.5
            if (introductionT == 1)
                Console.WriteLine("Mr.");
            if (introductionT == 2)
                Console.WriteLine("Mrs.");
            if (introductionT == 3)
                Console.WriteLine("Miss.");
            Console.Write("Name :");
            Console.WriteLine(nameT);
            Console.Write("SurnameBS : ");
            Console.WriteLine(surnameT);
            Console.WriteLine("Complete! Would you like to go back to the menu?");
            Console.WriteLine("1 = Yes | 2 = YES | 3 = YES YES YES!");
            CheckS = int.Parse(Console.ReadLine());
            switch (CheckS)
            {
                case 1:
                    { Rerun(); }
                    break;
                case 2:
                    { Rerun(); }
                    break;
                case 3:
                    { Rerun(); }
                    break;
                default:
                    { Rerun(); }
                    break;
            }
        }


        static void Register() //1.2
        {
            int Human;
            Console.WriteLine("[1.2 And 1.3]");
            Console.WriteLine("Who are you ?");
            Console.WriteLine("1 = BIGBOY Students | 2 = Smally Students | 3 = Teachers");
            Human = int.Parse(Console.ReadLine());
            switch (Human)
            {
                case 1:
                    { BS(); }
                    break;
                case 2:
                    { SSSS(); }
                    break;
                case 3:
                    { T(); }
                    break;
                default:
                    break;

            }

        }

        static void BS()
        {
            int Religion;
            int Fakebool;
            string EmailBS;
            string PasswordBS;
            string CheckE;
            string CheckP;
            int CheckS;
            int age;
            int Allergy;
            int StudentID;
            ++NumberBS;
            Console.Clear();
            Console.WriteLine("Introduction ");
            Console.WriteLine("1 = Mr. 2 = Mrs. 3 = Miss.");

            introductionBS = int.Parse(Console.ReadLine());
            switch (introductionBS)
            {
                case 1:
                    Console.WriteLine("Mr."); 
                    break;
                case 2:
                    Console.WriteLine("Mrs.");
                    break;
                case 3:
                    Console.WriteLine("Miss.");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Name ");
            nameBS = (Console.ReadLine());
            Console.WriteLine("Surname ");
            surnameBS = (Console.ReadLine());
            Console.WriteLine("StudentID ");
            StudentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Age ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Allergy ");
            Allergy = int.Parse(Console.ReadLine());
            Console.WriteLine("what religion are you? :");
            Console.WriteLine("1 = Buddhist | 2 = Christ | 3 = Islam | 4 = Other ");
            Religion = int.Parse(Console.ReadLine());
            switch (Religion)
            {
                case 1:
                    Console.WriteLine("Buddhist");
                    break;
                case 2:
                    Console.WriteLine("Christ");
                    break;
                case 3:
                    Console.WriteLine("Islam");
                    break;
                case 4:
                    Console.WriteLine("Other");
                    break;
                default:
                    break;
            }

            Console.WriteLine("Are you an administrator ?? : 1 = Yes | 2 = No ");
            Fakebool = int.Parse(Console.ReadLine());
            switch (Fakebool)
            {
                case 1:
                    Console.WriteLine("Are you an Email?");
                    EmailBS = (Console.ReadLine());

                    Console.WriteLine("Are you an Password?");
                    PasswordBS = (Console.ReadLine());

                    Console.WriteLine("Check email ");
                    CheckE = (Console.ReadLine());
                    Console.WriteLine("Check code");
                    CheckP = (Console.ReadLine());
                    if (CheckE != EmailBS && CheckP != PasswordBS)
                    {
                        Console.WriteLine("Incorrect email or password. Please try again.");
                        { Rerun(); }
                    }

                    else Console.WriteLine("Correct!");
                    break;
                case 2:
                    Console.WriteLine("OK");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Complete! Would you like to go back to the menu?");
            Console.WriteLine("1 = Yes | 2 = YES | 3 = YES YES YES!");

            CheckS = int.Parse(Console.ReadLine());
            switch (CheckS)
            {
                case 1:
                    { Rerun(); }
                    break;
                case 2:
                    { Rerun(); }
                    break;
                case 3:
                    { Rerun(); }
                    break;
                default:
                    { Rerun(); }
                    break;
            }
        }

        static void SSSS()
        {
            int Religion;
            int CheckS;
            int Education;
            int age;
            int Allergy;
            int school;
            ++NumberSSSS;
            Console.Clear();
            Console.WriteLine("Introduction ");
            Console.WriteLine("1 = Mr. 2 = Mrs. 3 = Miss.");

            introductionSSSS = int.Parse(Console.ReadLine());
            switch (introductionSSSS)
            {
                case 1:
                    Console.WriteLine("Mr.");
                    break;
                case 2:
                    Console.WriteLine("Mrs.");
                    break;
                case 3:
                    Console.WriteLine("Miss.");
                    break;
                default:
                    break;
            }
                    Console.WriteLine("Name ");
            nameSSSS = (Console.ReadLine());
            Console.WriteLine("Surname ");
            surnameSSSS = (Console.ReadLine());
            Console.WriteLine("Age ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Education");
            Education = int.Parse((Console.ReadLine()));
            switch (Education)
            {
                case 1:
                    Console.WriteLine("M.4");
                    ++M4;
                    break;
                case 2:
                    Console.WriteLine("M.5");
                    ++M5;
                    break;
                case 3:
                    Console.WriteLine("M.6");
                    ++M6;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Allergy ");
            Allergy = int.Parse(Console.ReadLine());
            Console.WriteLine("what religion are you?: ");
            Console.WriteLine("1 = Buddhist | 2 = Christ | 3 = Islam | 4 = Other ");
            Religion = int.Parse(Console.ReadLine());
            switch (Religion)
            {
                case 1:
                    Console.WriteLine("Buddhist");
                    break;
                case 2:
                    Console.WriteLine("Christ");
                    break;
                case 3:
                    Console.WriteLine("Islam");
                    break;
                case 4:
                    Console.WriteLine("Other");
                    break;
                default:
                    break;
            }
            Console.WriteLine("School :");
            school = int.Parse(Console.ReadLine());
            Console.WriteLine("Complete! Would you like to go back to the menu?");
            Console.WriteLine("1 = Yes | 2 = YES | 3 = YES YES YES!");

            CheckS = int.Parse(Console.ReadLine());
            switch (CheckS)
            {
                case 1:
                    { Rerun(); }
                    break;
                case 2:
                    { Rerun(); }
                    break;
                case 3:
                    { Rerun(); }
                    break;
                default:
                    { Rerun(); }
                    break;
            }
        }

        static void T()
        {
            int Religion;
            int Rank;
            int Fakebool;
            string EmailT;
            string PasswordT;
            string CheckE;
            string CheckP;
            int CheckS;
            int car;
            int age;
            int Allergy;
            int carnumber;
            ++NumberT;
            Console.Clear();
            Console.WriteLine("Introduction ");
            Console.WriteLine("1 = Mr. 2 = Mrs. 3 = Miss.");

            introductionT = int.Parse(Console.ReadLine());
            switch (introductionT)
            {
                case 1:
                    Console.WriteLine("Mr.");
                    break;
                case 2:
                    Console.WriteLine("Mrs.");
                    break;
                case 3:
                    Console.WriteLine("Miss.");
                    break;
                default:
                    break;
            
            }

            Console.WriteLine("Name ");
            nameT = (Console.ReadLine());
            Console.WriteLine("Surname ");
            surnameT = (Console.ReadLine());
            Console.WriteLine("Age ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("What Rank are you?: ");
            Console.WriteLine("1 = Dean 2 = Head of department 3 = Full Time Teacher");
            Rank = int.Parse(Console.ReadLine());
            switch (Rank)
            {
                case 1:
                    Console.WriteLine("Dean");
                    break;
                case 2:
                    Console.WriteLine("Head of department");
                    break;
                case 3:
                    Console.WriteLine("Full Time Teacher");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Allergy ");
            Allergy = int.Parse(Console.ReadLine());
            Console.WriteLine("what religion are you? :");
            Console.WriteLine("1 = Buddhist | 2 = Christ | 3 = Islam | 4 = Other ");
            Religion = int.Parse(Console.ReadLine());
            switch (Religion)
            {
                case 1:
                    Console.WriteLine("Buddhist");
                    break;
                case 2:
                    Console.WriteLine("Christ");
                    break;
                case 3:
                    Console.WriteLine("Islam");
                    break;
                case 4:
                    Console.WriteLine("Other");
                    break;
                default:
                    break;
            }

            Console.WriteLine("Do you a car? : 1 = Yes | 2 = No ");
            car = int.Parse(Console.ReadLine());
            switch (car)
            {
                case 1: Console.WriteLine("car registration");
                    carnumber = int.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }

            Console.WriteLine("Are you an administrator ?? : 1 = Yes | 2 = No ");
            Fakebool = int.Parse(Console.ReadLine());
            switch (Fakebool)
            {
                case 1:
                    Console.WriteLine("Are you an Email?");
                    EmailT = (Console.ReadLine());

                    Console.WriteLine("Are you an Password?");
                    PasswordT = (Console.ReadLine());

                    Console.WriteLine("Check email ");
                    CheckE = (Console.ReadLine());
                    Console.WriteLine("Check code");
                    CheckP = (Console.ReadLine());
                    if (CheckE != EmailT && CheckP != PasswordT) {
                        Console.WriteLine("Incorrect email or password. Please try again.");
                        { Rerun(); }
                    }
                    else Console.WriteLine("Correct!");
                    break;
                case 2:
                    Console.WriteLine("OK");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Complete! Would you like to go back to the menu?");
            Console.WriteLine("1 = Yes | 2 = YES | 3 = YES YES YES!");

            CheckS = int.Parse(Console.ReadLine());
            switch (CheckS)
            {
                case 1:
                    { Rerun(); }
                    break;
                case 2:
                    { Rerun(); }
                    break;
                case 3:
                    { Rerun(); }
                    break;
                default:
                    { Rerun(); }
   
                    break;
            }
        }
        static void SS() { //1.4
            int CheckS;
            Console.Clear();
            Console.WriteLine("[1.4]");
            Console.WriteLine("Show attendance statistics");
            Console.Write("Total number of registered teachers ");
            Console.WriteLine(NumberT);
            Console.Write("Total number of registered Smally students ");
            Console.WriteLine(NumberSSSS);
            Console.Write("Total number of registered BIGBOY students ");
            Console.WriteLine(NumberBS);
            Console.Write("The total number of registered students in M.4 only ");
            Console.WriteLine(M4);
            Console.Write("The total number of registered students in M.5 only ");
            Console.WriteLine(M5);
            Console.Write("The total number of registered students in M.6 only ");
            Console.WriteLine(M6);
            Console.WriteLine("Complete! Would you like to go back to the menu?");
            Console.WriteLine("1 = Yes | 2 = YES | 3 = YES YES YES!");

            CheckS = int.Parse(Console.ReadLine());
            switch (CheckS)
            {
                case 1:
                    { Rerun(); }
                    break;
                case 2:
                    { Rerun(); }
                    break;
                case 3:
                    { Rerun(); }
                    break;
                default:
                    { Rerun(); }
                    break;
            }
        }
    }