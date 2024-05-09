using System.Text;

Console.WriteLine(".NET COURSE SPECIALIZATION by PSDF");
Console.WriteLine();
Console.WriteLine("Single Array ");

// Arrays in C#
int[] marks = new int[5];
marks[0] = 25;
marks[1] = 26;
marks[2] = 27;
marks[3] = 28;
marks[4] = 29;
foreach (int mark in marks)
    Console.WriteLine(mark);

Console.WriteLine("\n");
// Two Dimenional Array
Console.WriteLine("Multi-dimenional Array ");
int[,] marks2 = new int[3, 4] {
    {1,2,6,7 },
    {57,8,79,4 },
    {57,8,79,4 }
};
for (int i = 0; i <= 2; i++)
{
    for (int j = 0; j <= 3; j++)
    {
        Console.Write(marks2[i, j] + " \t");
    }
    Console.WriteLine();
}

// Jagged array
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[3];
jaggedArray[1] = new int[3];


// string manipulating
string name = "waleedalisarwar";
string title = "C# by PSDF";
Console.WriteLine(name);
Console.WriteLine(title);
Console.WriteLine("Length of string NAME :" + name.Length);
Console.WriteLine("Concatinating string : " + name.Concat(title));
Console.WriteLine("Equals String : " + name.Equals(title));

// concatinating the string in to string
string ctext = string.Concat(name, title);
Console.WriteLine(ctext);

// immutable string 
string s1 = "C# programming";
string s2 = " Java programming";

// mutable string
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append(s1);
stringBuilder.Append(s2);
Console.WriteLine(stringBuilder);

