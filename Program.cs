using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!

                int oneSidePaddingSize = Task2.Padding / 2;

                string decoration = new String(task.DecorativeSign, oneSidePaddingSize);
                string spacePadding = new String(' ', oneSidePaddingSize);
                string moneyBalance = task.Balance.ToString("C2");

                string result = $"{decoration}{spacePadding}{moneyBalance}{spacePadding}{decoration}";

                return result;
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
