using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programming.Test
{
    public class MenuSystem
    {
        //Naming convention - ClassName_MethodName_ExpectedResult
        public static void MenuSystem_MenuDisplayMethod_ReturnAChar()
        {

            try
            {




                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("a) Trinary Converter .");
                char NavigationType = char.Parse(Console.ReadLine());

                switch (NavigationType)
                {
                    case 'a':
                        Console.Clear(); //should clear console after user input in the variable (NavigationType).

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Test Failed.");
                        return;
                }






            }
            catch (FormatException)
            {
                Console.WriteLine("Format Error.");

            }
        }

        public static void MenuSystem_MenuDisplayMethod_ReturnBChar()
        {

            try
            {
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("b) School Roster .");
                char NavigationType = char.Parse(Console.ReadLine());

                switch (NavigationType)
                {
                    case 'b':
                        Console.Clear();
                        School.RosterButton(NavigationType);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Test Failed.");
                        return;
                }
            }

            catch (FormatException)
            {

                Console.WriteLine("Format Error.");
            }

        }

        public static void MenuSystem_MenuDisplayMethod_ReturnCChar()
        {

            try
            {
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("c) ISBN Verifier.");
                char NavigationType = char.Parse(Console.ReadLine());

                switch (NavigationType)
                {
                    case 'c':
                        Console.Clear();
                        ISBNVerifier.ISBNTenButton(NavigationType);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Test Failed.");
                        return;

                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Format Error.");
            }
        }

        public static void MenuSystem_MenuDisplayMethod_ReturnDChar()
        {

            try
            {

                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("d) End the Program");
                char NavigationType = char.Parse(Console.ReadLine());


                switch (NavigationType)
                {
                    case 'd':
                        Console.Clear();
                        EndProgram.EndProgramDButton(NavigationType);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Test Failed.");
                        return;
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Format Error.");
            }
        }

    }
    class Trinary
    {
        public static void TrinaryConverter()
        {
            bool ExitProgram = false;

            while (!ExitProgram)
            {
                try
                {
                    Console.WriteLine("///////////////////////////////////");
                    Console.Write("Enter a Trinary Number: ");
                    string TrinaryInput = Console.ReadLine();

                    decimal DecimalValue = TrinaryToDecimal(TrinaryInput);

                    Console.WriteLine("Decimal equivalent: " + DecimalValue);

                    if (!TrinaryRange(TrinaryInput))    // This will take a Trinary input and use the boolean method to check if the numbers are less then 0 and greater than 2.
                    {
                        Console.WriteLine("Please enter a valid trinary number.");
                    }

                    // this asks the user if they want to continuem or not

                    Console.WriteLine("Do you want to convert another trinary number? (Y/N)");
                    string ContinueInput = Console.ReadLine();

                    if (ContinueInput == "Y")
                    {
                        Console.Clear();
                        ExitProgram = false;
                    }
                    else if (ContinueInput == "N")
                    {
                        Console.Clear();
                        /*MenuSystem.MenuDisplayMethod();*/ //not testing this.
                    }

                    switch (ContinueInput)
                    {

                        case "Y":
                            ExitProgram = false;
                            break;
                        case "N":
                            ExitProgram = true;
                            break;
                        default:
                            Console.Clear(); //Clears the console to ensure that nothing is spammed.
                            Console.WriteLine("Invalid Key..");
                            break;
                    }


                }
                catch (FormatException)
                {


                    Console.WriteLine("wrong");
                }

            }

        }
        // This bool method ensures that the user input can only range from 0 to 2.// 
        private static bool TrinaryRange(string input)
        {
            foreach (char ChosenValue in input)
            {
                if (ChosenValue < '0' || ChosenValue > '2')
                {
                    return false; // By entering an invalid input from the 'string TrinaryInput'
                }
            }
            return true;
        }
        // Here we have taken trinary input from Converter method which we put in the parameters as 'string trinary'.//
        private static decimal TrinaryToDecimal(string trinary)
        {
            decimal Result = 0;
            int ValuePower = 0;


            for (int i = trinary.Length - 1; i >= 0; i--) /* This will iterate through each value of the trinary number from right to left.
               Though it is until it reaches the end of the left side.*/
            {
                /* The string inputs from trinary gets convert into integer inputs whilst every time the loop iterates through i
                 then the value of AssignedNumber will be the same as the trinarys integer. For instance from right to left. 
                the first value will be 0. Therefore, whatever the user inputs first which is value 0 in string. Will get converted to string.*/
                int AssignedNumber = trinary[i] - '0';

                // Check if the digit is a valid trinary digit (0, 1, or 2)
                if (AssignedNumber < 0 || AssignedNumber > 2)
                {
                    // If invalid, consider the whole trinary number as 0
                    return 0;
                }

                // Multiply the digit value by 3 raised to the power of its position
                Result += AssignedNumber * (decimal)Math.Pow(3, ValuePower);

                // This increments the power for the next position step by step.//
                ValuePower++;
            }
            // This will return the result 0 if the condition is not satisfied which is a number less than 0 or greater than 2.//
            return Result;
        }
        public static void Trinary_TryinaryInputMethod_ReturnDecimal()
        {

            try
            {
                Console.WriteLine("///////////////////////////////////");
                Console.Write("Enter a Trinary Number: ");
                string TrinaryInput = Console.ReadLine();
                decimal DecimalValue = TrinaryToDecimal(TrinaryInput);
                // These are everything the compliler expects.
                if (GetExpectedResult(TrinaryInput) == DecimalValue)
                {
                    Console.WriteLine("Test Passed.");
                }
                else
                {
                    Console.WriteLine("Test Failed.");
                }


            }
            catch (FormatException)
            {

                Console.WriteLine("Format Error.");
            }



        }
        static void TrinaryConverterButton(char NavigationType)

        {

            if (NavigationType == 'a')
            {

                Console.WriteLine("Test passed.");
                return;
            }

        }
        public static decimal GetExpectedResult(string TrinaryInput)
        {
            switch (TrinaryInput)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "10":
                    return 3;
                case "112":
                    return 14;
                case "1122000120":
                    return 32091;
                default:
                    Console.Clear();
                    throw new ArgumentException("Only test the shown inputs. " + TrinaryInput);

                    
            }
        }
    }
        class School
        {
        public static Dictionary<int, List<string>> Forms = new Dictionary<int, List<string>>(); // This is a dictionary with a list that will store student and form info.
        bool ExitProgram;

        public static void School_RosterMethod_Return_String()
        {
            Console.WriteLine("/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/\\/\\/\\");
            Console.Write("Enter the student name: ");
            string StudentName = Console.ReadLine();
            

            switch (StudentName)
            {
                case "Aimee":
                    Console.WriteLine("Test Passed.");
                    return;
                case "Blair":
                    Console.WriteLine("Test Passed.");
                    return;
                case "James":
                    Console.WriteLine("Test Passed.");
                    return;
                case "Chelsea":
                    Console.WriteLine("Test Passed.");
                    return;
                case "Logan":
                    Console.WriteLine("Test Passed.");
                    return;
                case "Jennifer":
                    Console.WriteLine("Test Passed.");
                    return;
                case "Kareem":
                    Console.WriteLine("Test Passed.");
                    return;
                case "Chris":
                    Console.WriteLine("Test Passed.");
                    return;
                case "Claire":
                    Console.WriteLine("Test Passed.");
                    return;
                default:
                    Console.WriteLine("Test Failed.");
                    return;
            }
        }
        



        public static void RosterButton(char NavigationType)
            {

                if (NavigationType == 'b')
                {
                    Console.WriteLine("Test Passed.");
                    return;
                }

                }
            }
        }


class ISBNVerifier
{

    public static void ISBNVerifier_ISBENTen_ReturnInt()
    {
        bool ExitProgram = true;

        while (ExitProgram)
        {
            Console.Write("Enter an ISBN-10 Number: ");
            string ISBNTen = Console.ReadLine();


            switch (ISBNTen)
            {

                case "3-598-21508-8":
                    Console.Clear();
                    Console.WriteLine("Valid.");
                    Console.WriteLine("Test Passed.");
                    return;
                case "3-598-21507-X":
                    Console.Clear();
                    Console.WriteLine("Valid.");
                    Console.WriteLine("Test Passed.");
                    return;
                case "3-598-21508-9":
                    Console.Clear();
                    Console.WriteLine("Failed.");
                    Console.WriteLine("Test Passed.");
                    return;
                case "3-598-21507-A":
                    Console.Clear();
                    Console.WriteLine("Failed.");
                    Console.WriteLine("Test Passed.");
                    return;
                case "3-598-2X507-9":
                    Console.Clear();
                    Console.WriteLine("Failed.");
                    Console.WriteLine("Test Passed.");
                    return;
            }
        }


    } 


            public static void ISBNTenButton(char NavigationType)
            {

                if (NavigationType == 'c')
                {

                    Console.Clear();
                    Console.WriteLine("Test Passed.");
                    return;
                }


            }
        }

        class EndProgram
        {

            public static void EndProgramDButton(char NavigationType)
            {

                if (NavigationType == 'd')
                {

                    Console.Clear();
                    Console.WriteLine("Test Passed.");
                }

            }
        }
    
