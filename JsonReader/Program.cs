﻿using System;

namespace JsonReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileReader fileReader = new FileReader();
            fileReader.GetInventry();
        }
    }
}
