using System;                   // start of any c# Program, This is a must.
using System.Collections.Generic;


namespace MenuAssignment            // This will organise my code.
{

    class MainMethod    // This class will hold the Main method.
    {

        static void Main(string[] args)
        {

            MenuSystem.MenuDisplayMethod(); // This is the main method. It has purposely been left clean. However, it will display everything from the class MenuSystem.


        }
    }
    class MenuSystem            // This is the class that will store the Menu system.
    {
        char A = 'a';   //Declaring the possible input key 'a' that can be pressed for the menu.
        char B = 'b';   //Declaring the possible input key 'b' that can be pressed for the menu.
        char C = 'c';   //Declaring the possible input key 'c' that can be pressed for the menu.
        char D = 'd';   //Declaring the possible input key 'd' that can be pressed for the menu.

        public MenuSystem(char a, char b, char c, char d) // This is the Container that will store the fields.
        {
            A = a;  // Reassigning the variable A to a.
            B = b;  // Reassigning the variable B to b.
            C = c;  // Reassigning the variable C to c.
            D = d;  // Reassigning the variable D to d.


        }

        public static void MenuDisplayMethod() // 'MenuDisplayMethod' that has no return type.

        {

            bool ExitProgram = false; // this variable will not be needed anywhere else.
            while (!ExitProgram) //This will loop the program when the user uses the wrong input. However, d can be used to exit.
            {
                try // This Try/Catch will tell the user to click on the following keybinds that are displayed. This is important as char.Parse will ONLY close the program.
                {
                    Console.WriteLine("Choose one of the following options:"); // This will ensure that the user understands what is happening in the code.
                    Console.WriteLine("/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/\\/\\/\\"); // This is just a pattern to make the table look good.
                    Console.WriteLine("a) Trinary Converter .");// This will ensure that the user will be able to read and pink their wanting option.
                    Console.WriteLine("b) School Roster .");// This will ensure that the user will be able to read and pink their wanting option.
                    Console.WriteLine("c) ISBN Verifier.");// This will ensure that the user will be able to read and pink their wanting option.
                    Console.WriteLine("d) End the Program");// This will ensure that the user will be able to read and pink their wanting option.
                    char NavigationType = char.Parse(Console.ReadLine()); // This will allow user input using the char variable. Executer expects a single character from the user.

                
                    switch (NavigationType)
                    {

                        case 'a':
                            Console.Clear(); //Clears the console to ensure that nothing is spammed.
                            Trinary.TrinaryConverter();
                            break;
                        case 'b':
                            Console.Clear(); //Clears the console to ensure that nothing is spammed.
                            SchoolRoster.Roster();
                            break;
                        case 'c':
                            Console.Clear(); //Clears the console to ensure that nothing is spammed.
                            ISBNVerifier.ISBNTen();
                            break;
                        case 'd':
                            Console.Clear(); //Clears the console to ensure that nothing is spammed.
                            return;


                    }

                }

                catch (FormatException) // This will catch any format error the user makes such as inputting mulitple characters.
                {

                    Console.WriteLine("Please click on of the following keys: a , b , c ,d");
                }


            }
        }
    }

    class SchoolRoster
    {
        public static Dictionary<int, List<string>> Forms = new Dictionary<int, List<string>>(); // This is a dictionary with a list that will store student and form info.
        bool ExitProgram;
        public static void Roster() //Roster method that has no return type.
        {
            bool loopProgram = true; // Bool that will loop until the condition becomes false.
            while (loopProgram)
            {
                try
                {
                    Console.WriteLine("/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/ \\/\\/\\/\\");
                    Console.WriteLine("a) View existing students and forms");
                    Console.WriteLine("b) Add a student name to the list.");
                    Console.WriteLine("c) View students in a form");
                    Console.WriteLine("d) View all students");
                    Console.WriteLine("z) Return to the menu ");
                    Console.Write("Please pick an option: ");
                    char ChosenOption = char.Parse(Console.ReadLine());

                    switch (ChosenOption) // Will navigate to one of the chosen method.
                    {
                        case 'a':       // 'a' will navigate to (ViewExistingStudentsAndForms).
                            ViewExistingStudentsAndForms();
                            break;
                        case 'b':       // 'b' will navigate to (AddStudentToForm).
                            AddStudentToForm();
                            break;
                        case 'c':       // 'c' will navigate to (ViewStudentsInForm).
                            ViewStudentsInForm();
                            break;
                        case 'd':       // 'd' will navigate to (ViewAllStudents).
                            ViewAllStudents();
                            break;
                        case 'z':       // 'z' will navigate to (MenuDisplayMethod).
                            Console.Clear();
                            MenuSystem.MenuDisplayMethod();
                            break;
                        default:        // This will alert the user. Ensuring that the correct key is clicked.
                            Console.WriteLine("Invalid option. Please enter a valid option (a, b, c, or d).");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option."); // this format exception will alert the user for all the methods that are mentioned in the cases.
                }
            }
        }

        public static void ViewExistingStudentsAndForms() // Void method as it does not return a value.
        {
            bool ExitProgram = false;

            
            Console.WriteLine("Existing students and forms:"); 
            foreach (var form in Forms.OrderBy(g => g.Key)) //OrderBy is used for sorting. f is a random created variable that is used to order everything in 'Forms' in alphabetical order.
            {
                var students = form.Value.OrderBy(s => s);
                Console.WriteLine("Form " + form.Key + ": " + string.Join(", ", students)); // Joins together the variable form and students.

            }
            // This asks the user if they want to continuem or not.
            Console.WriteLine("Click any button to go back to the Roster Menu");
            string ContinueInput = Console.ReadLine();

            if (ContinueInput == "N") // Decided to use an if statement instead of a switch.
            {
                ExitProgram = true; // Condition has been set true meaning it will no longer loop.
                Roster(); // Returns the user back to Roster method.
            }
            Console.Clear(); //Clears the console to ensure that nothing is spammed.
        }

        public static void AddStudentToForm() // No return method. Will be used to store information.
        {

            try
            {
                Console.Clear(); //Clears the console to ensure that nothing is spammed.
                Console.Write("Enter the student name: ");
                string StudentName = Console.ReadLine(); // StudentName gets stored inside the declared variable 'StudentName' for now.

                Console.Write("Enter the form number: ");// 
                int FormNumber = int.Parse(Console.ReadLine()); // The integer that gets inputted by the user for their 'FormNumber' will be stored inside of 'FormNumber'. 

                if (!Forms.ContainsKey(FormNumber)) // If statement. Here .ContainsKey will take the 'FormNumber' variable and transfer it to the Forms Dictionary/list as a key.
                {
                    Forms[FormNumber] = new List<string>();
                }

                Forms[FormNumber].Add(StudentName); // This will add the 'StudentName' to the assigned form number. Joining them together.
                Console.WriteLine(StudentName + " added to form " + FormNumber + ".");
            }
            catch (FormatException) // This will give the user a format exception.
            {

                Console.WriteLine("Enter a username using characters.");
            }
        }

        public static void ViewStudentsInForm() // Non return type method that will hold the syntax which will allow user to enter input.
        {
            Console.Clear(); //Clears the console to ensure that nothing is spammed.
            Console.Write("Enter the form number: ");
            int FormNumber = int.Parse(Console.ReadLine()); // takes user inputs and only allows int numbers.

            if (Forms.ContainsKey(FormNumber))//checks if a specific form number exists.
            {
                var students = Forms[FormNumber].OrderBy(s => s);  //If a certain form number exists. it will be ordered alphabetically.
                Console.WriteLine("Students in form " + FormNumber + ": " + string.Join(", ", students)); // This will print out the result that has been found.
            }
            else
            {
                Console.WriteLine("No students found in form " + FormNumber + "."); // If the reuslt has not been found. You will get an erroneous message displayed.
            }

        }

        public static void ViewAllStudents() // No return type method that will allow the user to view all students in a list.
        {
            Console.Clear(); //Clears the console to ensure that nothing is spammed.
            Console.WriteLine("All students enrolled in school:");
            foreach (var form in Forms.OrderBy(f => f.Key)) //New loop variable defined as 'form'. Used .OrderBy to alphabetically order the inputs. Ensuring that 
                                                            //each key which is a row of information in the dictionary/List, is unique.
            {
                var students = form.Value.OrderBy(s => s);  // orders the values of the 'form'. s is a random variable as if to show x. to reference the students in the list.
                Console.WriteLine(string.Join(", ", students) + " in form " + form.Key); // string.Join, joins the sorted listed students together from the form/dictionary known as 'form'.

            }
        }
    }








    class Trinary // Main trinary class holder.
    {
        public static void TrinaryConverter() // TrinaryConverters Main method with no return type.
        {
            bool ExitProgram = false; // This True/False variable is set to false. Meaning, it will continue to do what it has been assigned to do until it becomes true.

            while (!ExitProgram)    //Will continue to loop until the condition gets set to true. 
            {
                try
                {
                    Console.WriteLine("///////////////////////////////////");
                    Console.Write("Enter a Trinary Number: ");
                    string TrinaryInput = Console.ReadLine(); // Will take the user input as string which can contain integers and keys.

                    decimal DecimalValue = TrinaryToDecimal(TrinaryInput); // DecimalValue variable will hold the method that will convert string characters to decimal.
                                                                           // Ensuring that numbers is not greater than 2 or less then 0.

                    Console.WriteLine("Decimal equivalent: " + DecimalValue);

                    if (!TrinaryRange(TrinaryInput))    // This will take a Trinary input and use the boolean method to check if the numbers are less then 0 and greater than 2.
                    {
                        Console.WriteLine("Please enter a valid trinary number.");
                    }

                    // this asks the user if they want to continuem or not.

                    Console.WriteLine("Do you want to convert another trinary number? (Y/N)");
                    string ContinueInput = Console.ReadLine(); // will take the user input as string to continue the input.

                    

                    switch (ContinueInput) // Switch that will proceed to allow the usersInput to either contine the program or exit the program ensuirng that it does/doesn't loop.
                    {

                        case "Y":
                            Console.Clear(); //Clears the console to ensure that nothing is spammed.
                            ExitProgram = false;
                            return;
                        case "N":
                            Console.Clear();//Clears the console to ensure that nothing is spammed.
                            MenuSystem.MenuDisplayMethod();// Will navigate back to the menu if the N character is clicked.
                            break;
                        default:
                            Console.Clear(); //Clears the console to ensure that nothing is spammed.
                            Console.WriteLine("Invalid Key..");
                            break;
                    }


                }
                catch (FormatException) // This will ensure that the inputs such as the 'ContinueInput' variable holds .
                {


                    Console.WriteLine("Please ensure that you input a string."); // This will specifically alert the user to why he/she is getting the format error.
                }

            }

        }
      
        private static bool TrinaryRange(string input)  // This bool method ensures that the user input can only range from 0 to 2. 
        {
            foreach (char ChosenValue in input)
            {
                if (ChosenValue < '0' || ChosenValue > '2')
                {
                    return false; // By entering an invalid input from the 'string TrinaryInput'.
                }
            }
            return true;
        }
        
        private static decimal TrinaryToDecimal(string trinary)// Here we have taken trinary input from Converter method which we put in the parameters as 'string trinary'.
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

                // Check if the digit is a valid trinary digit (0, 1, or 2).
                if (AssignedNumber < 0 || AssignedNumber > 2)
                {
                    // If invalid, consider the whole trinary number as 0.
                    return 0;
                }

                // Multiply the digit value by 3 raised to the power of its position
                Result += AssignedNumber * (decimal)Math.Pow(3, ValuePower);

                // This increments the power for the next position step by step.
                ValuePower++;
            }
            // This will return the result 0 if the condition is not satisfied which is a number less than 0 or greater than 2.
            return Result;
        }

       
    }

    class ISBNVerifier // ISBNVerifier class holder.
    {
        public static void ISBNTen() // Main ISBNTen(); Method that has no return type. Defined by 'void'.
        {
            bool ExitProgram = true; // Condition will always keep going until this variable 'ExitProgram' is set to falsee.

            while (ExitProgram) //Continuous loop until the condition has been met. Making 'ExitProgram' false.
            {
                Console.Write("Enter an ISBN-10 Number: ");
                string ISBNTen = Console.ReadLine();

                string FinishedInput = InputReplacer(ISBNTen); // Fininshed uptdate will hold a return type string method that will replace hyphens and X.
                InputRange(FinishedInput);

                while (ExitProgram) // While will loop the program until everything is satisfied.
                {
                    // this asks the user if they want to continuem or not
                    Console.WriteLine("Would you like to verify another ISBN-10? Y/N");
                    string ContinueInput = Console.ReadLine();


                        switch (ContinueInput) // Switch case ensures that user is able to use (Y/N) to navigate.
                        {
                            case "Y": // 'Y' button will navigate the user to the ISBNTen(); method.
                                Console.Clear(); // Clears the console before displaying ISBNTen(); method.
                                ISBNVerifier.ISBNTen();
                                break;
                            case "N":  // 'N' button will navigate the user to the MenuDisplayMethod(); method.
                                Console.Clear(); // Clears the console before displaying MenuDisplayMethod(); method.
                                MenuSystem.MenuDisplayMethod();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid Key. Please choose either (Y/N)."); // If user does neither. it will display this erroneous message.
                                break;
                        }
                    

                    

                }
                    
                }
                
                 //Clears the console to ensure that nothing is spammed.
            }
        

        public static string InputReplacer(string UserInput)
        {
            
            string RemovedHyphensAndSpaces = UserInput.Replace("-", ""); // Removes hyphens and spaces.

            
            string XChanger = RemovedHyphensAndSpaces.Replace("X", "10"); // Replaces 'X' with '10'.

            return XChanger; // the return type is string. it will return Xchanger once the method has been executed.
        }

        public static void InputRange(string UserInput) //No return method that will ensure that UserInput does not contain 'non-numeric characters.
        {
            
            foreach (char Character in UserInput) // Check for invalid characters
            {
                // char.IsDigit is a built in c# method that checks if Character variable has the decimal (0-9).
                if (!char.IsDigit(Character) && Character != 'X') // Checks if Character variable is not equal to 'X'.
                {
                    Console.WriteLine("Invalid ISBN-10 as it contains non-numeric characters.");
                    return;

                }
            }

            
            if (UserInput.Length != 10) // This will check  the length after removing hyphens and also ensure that the length is not less or greater than 10.
            {
                Console.WriteLine("Invalid ISBN-10: Incorrect length.");
                return;
            }

           
            int sum = 0; // variable that stores in the integer value 0.
            for (int i = 0; i < 10; i++)  // for loop that will iterate checking 10 numbers.
            {
                int digit = int.Parse(UserInput[i].ToString());
                sum += digit * (10 - i);
            }

            if (sum % 11 == 0) //result of the Modulo, must be zero or it is an invalid ISBN.
            {
                Console.WriteLine("Valid ISBN-10");
            }
            else 
            {
                Console.WriteLine("Invalid ISBN-10");
            }
        }
    }
}
  
