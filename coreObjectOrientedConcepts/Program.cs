
using coreObjectOrientedConcepts;
using System.Linq.Expressions;
Console.WriteLine(".NET SPECIALIZATION COURSE BY PSDF COURSERA");
Console.WriteLine();
// Class 
//Student student = new Student();
////student.acceptDetails();
//student.displayDetails();

//Student student2 = new Student(220208733,"Adnan Mehmood");
//student2.displayDetails();

// Marks class
/***
 * 
 *  Clearing the concept of Inheritance of OOPS in C# .NET
 *  Student Marks 
 *  Example below
 * 
 */

//Marks marks = new Marks();
//marks.acceptDetails();
//marks.displayDetails();


/*
 * 
 * Abstract Class Example practice
 *
 */

//SavingAccount savingAccount = new SavingAccount();
//savingAccount.getMessage();
//savingAccount.deposit();
//savingAccount.withdraw();
//savingAccount.balance();

//SavingAcc savingAcc = new SavingAcc();
//savingAcc.openAcc();
//savingAcc.balance(); 
//savingAcc.withdraw();
//savingAcc.deposit();
//savingAcc.closeAcc();

// static keyword basics

//Console.WriteLine(Calculate.increment());
//Console.WriteLine(Calculate.increment());
//Console.WriteLine(Calculate.increment());
//Console.WriteLine(Calculate.increment());
//Console.WriteLine(Calculate.count);

//int num = 100;
//bool result = num.IsGreaterThan(Calculate.count);
//Console.WriteLine(result);

// Partial Class Basics
//var employee = new Employee();
//Console.WriteLine(employee.EmployeeID);
//Console.WriteLine(employee.EmployeeName);
//employee.DisplayDetails();


// Property in C#
//User user = new User();
//user.Name = "Waleed";
//user.Age = 18;
//user.City = "Rawalpindi/Islamabad";
//Console.WriteLine($"Name of User : {user.Name}, age is : {user.Age}, and City is :{user.City}");

// Indexers
//StringIndexerType stringIndexerType = new StringIndexerType();
//stringIndexerType[0] = "Welcome";
//stringIndexerType[1] = "to";
//stringIndexerType[2] = "Waleed";
//stringIndexerType[3] = "Ali";
//stringIndexerType[4] = "Program";
//stringIndexerType[5] = "In";
//stringIndexerType[6] = "C#";

//for (int i = 0;i< 10;i++)
//    Console.WriteLine(stringIndexerType[i] +"\t");

// Enum in C#
//EnumDemo enumDemo = new EnumDemo();
//enumDemo.DisplayDays();

// Anonymous Type in C#

//var myData = new
//{
//    name = "Waleed Anonymous!",
//   title = "C# Coursera",
//   session = new {
//    sessionDate = "2024",
//    sessionStatus = true
//   }
//};
//Console.WriteLine(myData.title);
//Console.WriteLine(myData.name);
//Console.WriteLine(myData.session.sessionDate);
//Console.WriteLine(myData.session.sessionStatus);

// Delegate in C#

//CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
//CalculateDelegate c2 = new CalculateDelegate(DelegateExample.multiplication);
//c1(100);
//Console.WriteLine(DelegateExample.getNumber());
//c2(200);
//Console.WriteLine(DelegateExample.getNumber());

// Events in C#

// The Subscriber Event 
//EventExample eventsExample = new EventExample();
//eventsExample.event_OddNumber += new EventExample.delegate_OddNumber(EventMessage);
//eventsExample.addition();

//static void EventMessage()
//{
//    Console.WriteLine("Event Executed : Odd Number");
//}

// Annonymous Method
//AnnonymousMethods.InvokeMethod();

// Lambda Expression
//var numObj = new int[] { 1, 23, 5, 8, 7, 9, 41 };
//var count = numObj.Count(x=> x == 1);
//Console.WriteLine(count);

//// Lambda Statement
//List <int> numList = new List<int> { 55,66,8,78,987,54,65,65,78,79,55};
//count = numList.Count(x => { return x == 55; });
//Console.WriteLine(count);

//Expression Tree
Func<string,string,string> stringJoin = (str1,str2)=>string.Concat(str1,str2);
Expression <Func<string, string,string>> stringJoinExpression = (str1, str2) => string.Concat(str1, str2);


var func = stringJoinExpression.Compile();
var resultExpression = func("Welcome", ".NET Course by PSDF");
Console.WriteLine(resultExpression);

// OR
resultExpression = stringJoinExpression.Compile()("Eid ", "Mubarak");
Console.WriteLine(resultExpression);












