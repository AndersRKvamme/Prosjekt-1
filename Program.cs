﻿using System.Reflection.Metadata.Ecma335;

namespace Prosjekt_1;

class Program
{
    static void Main(string[] args)
    {
        static int myFunc(int num, int num2){
            return num * num2;
        };
        Console.WriteLine(myFunc(10, 12));
        Console.WriteLine("Hello, World!");
        string myWord = "Word";
        Console.WriteLine(myWord);
        string expectedName = "anders";
        Console.WriteLine("What's your name?");
        string? name = Console.ReadLine()?.ToLower();
        Console.WriteLine("Hello " + name);
        if (name == expectedName)
        {
        Console.WriteLine("Welcome Anders");
        }
        else
        {
        Console.WriteLine("Hello " +name+ ", please leave");
        }
        int convert = 16;
        double converted = Convert.ToDouble(convert)+0.5;
        Console.WriteLine(converted);
        Console.WriteLine(converted.GetType());

        //01/10/2024
        //Arrays, store multiple values of the same 
        
        int[] myIntArray ={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

        // Loop through the array, using index-based interator
        // iterator++ is the same as: iterator= itself +1...
        for(int iterator = 0; iterator < myIntArray.Length; iterator++) 
        {
        Console.WriteLine($"Iterator on position:{iterator}, index of the numbers in the array: {myIntArray[iterator]}");
        }
       
        // We assign a new string array, using string [] myStringArray = {"some", "strings"};

        string[] myStringArray = { "Hello", "from", "a", "string", "Array!" };

        // We can use a foreach loop, to loop through the string array, using a single string variable
        
        foreach (string myStrings in myStringArray)
        {
        Console.WriteLine(myStrings);
        }
    Console.Beep();
    }
}
