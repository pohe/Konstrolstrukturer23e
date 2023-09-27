// See https://aka.ms/new-console-template for more information


//int age = 17;
using System.Reflection.PortableExecutable;
using static System.Formats.Asn1.AsnWriter;

//Console.WriteLine("Starting to check age...");
//if (age < 18)
//{
//    Console.WriteLine("You are still a child...");
//}

//if (age < 18)
//    Console.WriteLine("You are still a child...");
//else
//    Console.WriteLine("You are an adult!");

//if (age > 12 && age <20)
//{

//        Console.WriteLine("You are a teenager");

//}

//int age = 15;
//string message = "You are ";
//message += (age < 18) ? "a child." : "an adult.";
////if (age < 18)
////{
////    message = message + "a child.";
////}
////else
////{
////    message = message + "an adult.";
////}
//Console.WriteLine(message);

//Console.WriteLine("Finished checking age");

//int score = 75;
//if (score >= 90)
//{
//    Console.WriteLine("Mark is: A");
//}
//if (score >= 70 && score <=89)
//{
//    Console.WriteLine("Mark is: B");
//}
//if (score >= 40 && score <=69)
//{
//    Console.WriteLine("Mark is: C");
//}
//if (score >= 0 && score <=39)
//{
//    Console.WriteLine("Mark is: D");
//}

//int childSupport = 0;
//int noOfChildren = 2;

//switch (noOfChildren)
//{
//    case 0:
//        childSupport = 0;
//        break;
//    case 1:
//        childSupport = 1200;
//        break;
//    case 2:
//        childSupport = 2000;
//        break;
//    case 3:
//        childSupport = 2600;
//        break;
//    default:
//        childSupport = 3000;
//        break;
//}
//Console.WriteLine($"For {noOfChildren} gives {childSupport}");


//int number = 1;
//while (number < 5)
//{
//    Console.WriteLine($"The value of the number is {number}");
//    number = number + 2;
//}


//void Menu(string choices)
//{
//    int key = 0;
//    while (key != 3)
//    {
//        Console.WriteLine(choices);
//        Console.Write("Angiv dit valg: ");
//        key = int.Parse(Console.ReadLine()) ;
//        Console.Clear();
//        Console.WriteLine($"You pressed {key}");
//        if (key == 1)
//        {
//            Console.WriteLine("Opret kunde");
//        }
//        else if (key == 2)
//        {
//            Console.WriteLine("Bestil pizza");
//        }
//        else if (key == 3)
//            Console.WriteLine("Afslut");
//        else
//            Console.WriteLine("Ikke en valgmulighed");
//        Console.ReadLine();
//    }

//}

//string choices = "\t1.\tOpret Kunde \n\t2.\tBestil pizza\n\t3.\tAfslut";
//Menu(choices);


//Udskriv alle lige tal fra 20 og til og med 0 i faldende orden

////initialisering
//int i = 20;
//while(i>=0) //Condition
//{
//    Console.WriteLine(i);
//    i = i - 2; //ændre condition
//}

////initialisering
//int i = 20;
//while (i >= 0) //Condition
//{
//    if (i%2 ==0)
//    {
//        Console.WriteLine(i);
//    }
//    i = i - 1; //ændre condition    
//}


int i = 1;
int j = 1;
while(j<=10)
{
    i = 1;
    while (i <= 10)
    {
        Console.Write("*\t");
        i = i + 1; //i++
    }
    Console.WriteLine();
    j = j + 1;//j++
}



