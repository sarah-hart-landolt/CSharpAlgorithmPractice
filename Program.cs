using CSharpAlgorithmPractice.CardDeck;
using CSharpAlgorithmPractice.EvenNumbers;
using CSharpAlgorithmPractice.PrimeNumber;
using CSharpAlgorithmPractice.FizzBuzzChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using CSharpAlgorithmPractice.Char;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Reflection;
using CSharpAlgorithmPractice.Programs;

namespace CSharpAlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IProgramExecute> programs = GetAllProgramInstances();

            Console.WriteLine("Welcome to the C# Algorithm Practice!");
            Console.WriteLine();

            while (true)
            {
                //Print out the menu
                int menuNumber = 1;
                foreach (var program in programs)
                {
                    Console.WriteLine((menuNumber++) + ") " + program.GetMenuTitle());
                }
                Console.WriteLine("0) Exit");

                //Get the user Selection and Execute Correct Program
                Console.WriteLine();
                Console.Write("Selection: ");
                var command = Console.ReadLine();

                if (command == "0")
                {
                    Console.WriteLine("Goodbye... Press Any Key To Close");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    if (int.TryParse(command, out int programIndexToExecute))
                    {
                        if (programs.Count >= programIndexToExecute)
                        {
                            Console.Clear();
                            programs[programIndexToExecute - 1].Execute();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                        //throw new Exception("Something went wrong...invalid selection");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("====Execution Completed... Press Any Key To Return To Main Menu=====");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static IList<IProgramExecute> GetAllProgramInstances()
        {
            IList<IProgramExecute> instances = new List<IProgramExecute>();

            //Returns all types in your program that implement the IProgramExecute interface we created
            var programTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                    .Where(x => typeof(IProgramExecute).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract);

            foreach (var programType in programTypes)
            {
                // Use the Activator to create an instance of the type
                IProgramExecute instance = (IProgramExecute)Activator.CreateInstance(programType);

                //Store the instance in a list to return
                instances.Add(instance);
            }

            return instances.OrderBy(t => t.SortOrder()).ToList();
        }
    }
}