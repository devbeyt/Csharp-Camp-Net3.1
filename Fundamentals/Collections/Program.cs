using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
             // string[] languages = new string[] { "HTML", "CSS", "JS", "REACT"};
            

                              // LIST  Add() same push()

            List<string> languages2 = new List<string> { "HTML", "CSS", "JS", "REACT" };
            languages2.Add("REDUX TOOLKIT");
            Console.WriteLine(languages2[4]);
            
        }
    }
}
