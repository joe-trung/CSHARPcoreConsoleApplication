using coreConsoleApplication;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text;

//float baseSalary = 5000;
//float hra = 0.30F;

//float netSalary = (baseSalary - (baseSalary * hra));

//Console.WriteLine("Base Salary " + baseSalary);
//Console.WriteLine("Net Salary " + netSalary);

//int temperature = 60;
//if (temperature < 20)
//    Console.WriteLine("It's very cold outside");
//else if (temperature <= 50 && temperature >= 20)
//    Console.WriteLine("It's moderate outside");
//else
//    Console.WriteLine("It's too hot outside");

//bool isLoggedIn = true;
//bool isEmailverified = true;
//bool cardInfo = true;
//if (isLoggedIn && isEmailverified && cardInfo)
//    Console.WriteLine("Allowed to make purchase");
//else
//    Console.WriteLine("Not Allowed to make purchase");


//bool isAuthenticated = true;

//if (isAuthenticated)
//    Console.WriteLine("you are logged in");
//else
//    Console.WriteLine("you are not logged in");

//string result = isAuthenticated ? "You are logged in" : "You are not logged in";
//Console.WriteLine(result);


//string userType = "subadmin";
//switch(userType)
//{
//    case "admin":
//        Console.WriteLine("You have full access");
//        break;
//    case "subadmin":
//        Console.WriteLine("You can create or delate courses");
//        break;
//    case "user":
//        Console.WriteLine("You can have access to the courses");
//        break;
//    default:
//        Console.WriteLine("Trial user");
//        break;
//}

//string[] names = { "Trung", "Kieu", "Lam", "Jonathan","Huong" };
//int i= 0;
//do
//{
//    Console.WriteLine(names[i]);
//    i++;

//} while (i < names.Length);

//foreach (string name in names)
//    Console.WriteLine(name);

//Console.WriteLine();

//for (i=0; i<5; i++)
//{ Console.WriteLine(names[i]); }

//for (i=4; i>=0; i--)
//{ Console.WriteLine(names[i]); }

//Console.WriteLine();

//for (int i=0;i<10; i++)
//{ if (i == 5) break;
//    Console.WriteLine("Hello " + i); }

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5) continue;
//    Console.WriteLine("Hello " + i);
//}


//string userType = "admin";
//switch (userType)
//{
//    case "admin":
//        Console.WriteLine("You have full access");
//        goto case "user";
//    case "subadmin":
//        Console.WriteLine("You can create or delate courses");
//        break;
//    case "user":
//        Console.WriteLine("You can have access to the courses");
//        break;
//    default:
//        Console.WriteLine("Trial user");
//        break;
//}

//int[] marks = new int[5];
//marks[0] = 25;
//marks[1] = 50;
//marks[2] = 55;
//marks[3] = 60;
//marks[4] = 40;

//foreach (int i in marks)
//    Console.WriteLine(i);


//int[] marks = new int[5] { 45, 56, 65, 67, 78 };
//foreach (int i in marks)
//    Console.WriteLine(i);

//int[,] multiArray = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

//for (int i = 0; i < multiArray.GetLength(0); i++)
//{
//    for (int j = 0; j < multiArray.GetLength(1); j++)
//    {
//        Console.Write(multiArray[i, j] + "\t");

//    }
//    Console.WriteLine();
//}

//int[][] jaggedArray = new int[2][];
//jaggedArray[0] = new int[2] { 4, 6 };
//jaggedArray[1] = new int[3] { 3, 7,5 };

//Console.WriteLine(jaggedArray[1][1]);

//string str1 = "Hello World";
//string str2 = "C# Programming";
//Console.WriteLine(str1);
//Console.WriteLine(str1.Length);
//string str3 = string.Concat(str1, str2);
//Console.WriteLine(str3);
//Console.WriteLine(str2.Equals(str1));


//string s1 = "C# Programming";
//string s2 = "Java Programming";

//StringBuilder stringBuilder = new StringBuilder();
//stringBuilder.Append("C# Programming ");
//stringBuilder.Append("Java Programing ");
//Console.WriteLine(stringBuilder);

//Student student = new Student();
//student.acceptDetails();
//student.displayDetails();

//Student student1 = new Student(101, "Trung");
//student.acceptDetails();
//student1.displayDetails();


//Marks marks = new Marks();
//marks.acceptDetails();
//marks.displayDetails();


//ConsolePrinter consolePrinter = new ConsolePrinter();
//consolePrinter.Print("how are you", "Trung", "Tran");

//Dog dog = new Dog();
//dog.MakeSound();

//SavingAccount savingAccount = new SavingAccount();
//savingAccount.getMessage();
//savingAccount.deposit();
//savingAccount.withdraw();
//savingAccount.balance();


//SavingAcc savingacc =  new SavingAcc();
//savingacc.openAccount();
//savingacc.balance();
//savingacc.deposit();
//savingacc.withdraw();
//savingacc.closeAccount();


//Console.WriteLine(Calculate.count);

//Console.WriteLine(Calculate.increment());

//Console.WriteLine(Calculate.increment());

//Console.WriteLine(Calculate.increment());

//Console.WriteLine(Calculate.increment());

//Console.WriteLine(Calculate.decrement());



//int number = 100;
//bool result = number.IsGreaterThan(1000);
//Console.WriteLine(result);

//var employee = new Employee();

//Console.WriteLine(employee.EmpId);
//Console.WriteLine(employee.EmpName);
//employee.DisplayDetails();

//Users users = new Users();
//users.Name = "King Kochlar";
//users.Age = 30;
//Console.WriteLine(users.Name);
//Console.WriteLine(users.CompanyName);
//Console.WriteLine(users.Age);


//StringIndexerTpye stringIndexerTpye = new StringIndexerTpye();
//stringIndexerTpye[0] = "String One";
//stringIndexerTpye[1] = "String Two";
//stringIndexerTpye[2] = "String Three";
//stringIndexerTpye[3] = "String Four";
//stringIndexerTpye[4] = "String Five";

//for (int i = 0;i<10;i++)
//    Console.WriteLine(stringIndexerTpye[i]);


//EnumDemo enumDemo = new EnumDemo();
//enumDemo.display();


//Calculation calculation = new Calculation();
////calculation.calculate(100, 0);

//calculation.calculateAnother();


//var obj = new
//{
//    firstName = "King",
//    lastName = "Kochlar",
//    salary = 12000,
//    address = new { streetName = "Civil Lines", city = "Dehli" },
//    project = new[]
//    {
//        new{projectName="ECommerce", projectDuration = "40 Hours" },
//        new{projectName="Admin Portal", projectDuration = "25 Hours" },
//        new{projectName="Accounting", projectDuration = "30 Hours" },
//    }
//};
//Console.WriteLine(obj.firstName);
//Console.WriteLine(obj.lastName);
//Console.WriteLine(obj.salary);
//Console.WriteLine(obj.address.streetName);
//Console.WriteLine(obj.address.city);

//foreach (var project in obj.project)
//{
//    Console.WriteLine(project.projectName+":"+project.projectDuration);
//}



//CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
//CalculateDelegate c2 = new CalculateDelegate(DelegateExample.multiplication);

//c1(100);
//Console.WriteLine(DelegateExample.getNumber());
//c2(200);
//Console.WriteLine(DelegateExample.getNumber());


//CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
//c1(100);
//Console.WriteLine(DelegateExample.getNumber());
//c1 += new CalculateDelegate(DelegateExample.addition);
//c1 += new CalculateDelegate(DelegateExample.multiplication);

//c1(100);
//Console.WriteLine(DelegateExample.getNumber());



EventExample eventExample = new EventExample();
eventExample.event_OddNumber += new EventExample.delegate_OddNumber(EventMessage);
eventExample.addition();
Console.ReadLine();

static void EventMessage()
{
    Console.WriteLine("Event Executed : Odd Number");
}
