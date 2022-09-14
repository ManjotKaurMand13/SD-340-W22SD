// C# program to illustrate how 
// to create a LinkedList
using System;
using System.Collections.Generic;

class CreatingLinkedListClass
{

    // Main Method
    static public void Main()
    {

        // Creating a linkedlist
        // Using LinkedList class
        LinkedList<String> PunjabiNames = new LinkedList<String>();

        // Adding elements in the LinkedList
        // Using AddLast() method
        PunjabiNames.AddLast("Manjot");
        PunjabiNames.AddLast("Gurman");
        PunjabiNames.AddLast("gitNavdeep");
        PunjabiNames.AddLast("Khushi");
        PunjabiNames.AddLast("Prabh");
        PunjabiNames.AddLast("Mander");

        Console.WriteLine("Selected Players in Volleyball Teams National ");

        // Accessing the elements of 
        // LinkedList Using foreach loop
        foreach (string str in PunjabiNames)
        {
            Console.WriteLine(str);
        }
    }
}