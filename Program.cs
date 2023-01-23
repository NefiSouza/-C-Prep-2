// See https://aka.ms/new-console-template for more information
 Console.Write("What percentage did you get? ");
        string response = Console.ReadLine();
      int grade = int.Parse(response);




if (grade >= 90)
{
    Console.WriteLine("You got an A");
}

else if (grade >= 80)
{
    Console.WriteLine("You got a B");
}


else if (grade >= 70)
{
    Console.WriteLine("You got a C");
}

else if (grade >= 60)
{
    Console.WriteLine("You got a D");
}
else if (grade < 60)
{
    Console.WriteLine("You got a F");
}
else  
{
    Console.WriteLine("You need to take this course again");
}

