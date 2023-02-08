﻿using AlphaProjectBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Views
{
    public class ProgramRegistration
    {
        public Programm Show()
        {
            Console.WriteLine("Enter the Code: ");
            var code = Console.ReadLine();

            Console.WriteLine("Want to enter the name of the program? (y/n)");
            var input = Console.ReadLine();

            var name = "";
            if (input == "y")
            {
                Console.WriteLine("Enter the name of the program: ");
                name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You did not enter the name of the program");
            }

            Console.WriteLine("Enter the Start Date: ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the End Date: ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            Programm program = new Programm(code, name, startDate, endDate);

            return program;
        }
    }
}