using System;
using System.Text.RegularExpressions;

namespace phoneNumberValidation
{
    class Program
    {
        // Function to check wether the inputed number is valid or not
        public static String isValidNumber(String inputMobileNumber)
        {
            // Used Regular Expression for checking the number "OR" Format matcher
            //String strRegX = "^[0-9]{10}$";
            String strRegX = "^((?!(0))[0-9]{10})$";
            Regex re = new Regex(strRegX);

            // Function that matches the regular expression format or not
            if (re.IsMatch(inputMobileNumber))
            {
                return "t";
            }
            else
            {
                return "f";
            }
        }
        public static void choiceSelect()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 : Check The Number \t 2 : Exit");
            Console.WriteLine("------------------------------------");
            Console.Write("\nEnter Your Choice : ");
        }
        // Main Function
        static void Main(string[] args)
        {
            // Initializing the boolean value to false that will help to exited in while loop when the falg = true
            bool flag = false;
            // A loop which will always execute the code to check the number until the user wants to exit from the loop by selecting the menu option by 2
            while (true)
            {
                // A method which will gives us a choice menu to select what operation we hava to perform
                choiceSelect();
                // The choice number user is going to choose for the menu
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= 2)
                    {
                        switch (choice)
                        {
                            case 1:
                                // Handling Exception is there is any error during the runtime process it will handle it
                                try
                                {
                                    // Inputing the number
                                    Console.Write("\nEnter Your Phone Number : ");
                                    String str = Console.ReadLine();

                                    // A boolean variable that checks the inputed number is not or not
                                    bool isEmpty = String.IsNullOrEmpty(str);

                                    // if the inputed number is null the is will throw the message 
                                    if (isEmpty == true)
                                    {
                                        Console.WriteLine("Number Can't Be Null");
                                        Console.ReadLine();
                                    }
                                    // if inputed number is not null then it will check the regualar expression return type
                                    else
                                    {
                                        // If the inputed number return type is "t" which is indicating true
                                        if (isValidNumber(str) == "t")
                                        {
                                            // Printing the Number is valid 
                                            Console.WriteLine("----Number is Valid----");
                                        }
                                        else
                                        {
                                            // Else Printing the number is Invalid
                                            Console.WriteLine("----Invalid Number----");
                                        }
                                        Console.ReadLine();
                                    }
                                }
                                // Catching the run time error.....
                                catch (Exception err)
                                {
                                    // Printing the error.....
                                    Console.WriteLine("Something wrong.....\n Try Again.....");
                                    Console.WriteLine(err.StackTrace);
                                }
                                break;
                            case 2:
                                flag = true;
                                Console.WriteLine("Exited Successfully ........");
                                Console.ReadLine();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nCan't take negative value or Value Which is Greater then 2");
                        Console.WriteLine("Please select the only option which is in the menu\n");
                        Console.ReadLine();
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
                catch (FormatException err)
                {
                    Console.WriteLine("\nCan't Inputed String Value Or Null Value");
                    Console.WriteLine(err.Message+"\n\n");
                }
            }
        }
    }
}
