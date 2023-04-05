using System;

namespace Loops_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {

            //asks the user for some input
            Console.WriteLine("Hi there! I can count the number of spaces inside of some text you give me, give it a try!");

            //calls the method
            CalculateSpaces(Console.ReadLine());

            string outInput = "0";

            Console.WriteLine("Now i can add up the digits of any interger you give me, lets do it!");
            Console.WriteLine($"{AddTheDigits(Console.ReadLine())} is the added digits of the nuber {outInput}");

            

            void CalculateSpaces(string input)
            {
                //this int will be the count of the spaces inside of {input}
                int numOfSpaces = 0;


                //the for loop will run each time saveing the calculation string to the previous string, but it
                //will cut off everything before the first space that occurs, it will do this until the index of "space" is -1
                //meaning there are no spaces in the string


                //   starting string               condition to break
                for (string calulationString = input; calulationString.IndexOf(" ") != -1; numOfSpaces++)
                {
                    //shortens the calculation string
                    calulationString = calulationString.Substring(calulationString.IndexOf(" ") + 1);
                    
                }
                //prints out to the user how many spaces are in the string
                Console.WriteLine($"\"{input}\" has {numOfSpaces} spaces inside of it");
            }

            //blah blah blah refer to the good documentation up there or somthin
             int AddTheDigits(string input)
            {

                //documentation
                int addedNum = 0;

                //wow a foreeach loop
                foreach(char num in input)
                {
                    //hehe number go brrrrrrr
                    addedNum += (int)char.GetNumericValue(num);
                }

                //documentation
                outInput = input;
                return addedNum;
            }
            
            
        }
    }
}
