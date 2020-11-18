using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int carbonTotal = 0;

            Console.WriteLine("Carbon Footprint Quiz");
            Console.WriteLine("You will be scored with 'impact points', try and get this as low as possible in order to be a friend to the planet");
            Console.WriteLine("Send this website to your friends, see who has a lower score");
            Console.WriteLine("\n");
            int[] sections = { 1, 2, 3, 4, 5 };

            string[] questions1 = { "How often do you eat beef or lamb?", "How often do you eat fish or pork? ", "How often do you eat chicken? ", "Which of these do you eat most often for breakfast? ", "Which of these do you eat most often during an evening meal? " };
            string[,] answers1 = { { "At least every day", "Most days", "At least once a week ", "Almost never" }, { "At least every day", "Most days", "At least once a week ", "Almost never" }, { "At least every day", "Most days", "At least once a week ", "Almost never" }, { "Cereal with dairy milk", "Cereal with another type of milk", "Cereal with no milk", "Bread" }, { "Rice", "Pasta", "Bread", "Potatoes" } };
            int[,] carbon1 = { { 2201, 1258, 472, 40 }, { 670, 383, 143, 40 }, { 497, 284, 106, 40 }, { 267, 124, 38, 21 }, { 121, 43, 21, 16 } };
            double max1 = 3756;
            double min1 = 157;

            string[] questions2 = { "If you were going on holiday to Edinburgh from London, would you be most likely to: ", "Over the past 5 years, which of these most reflects the way you travel when going on holiday? ", "What mode of transport do you use for your commute ", "What type of car do you own?", "Do you work from home?" };
            string[,] answers2 = { { "Fly?", "Drive?", "Go by bus?", "Take the train?" }, { "Intercontinental flight ", "European flight", "Train", "No holiday" }, { "Car", "Train", "Bus", "Bicycle or walk" }, { "Petrol", "Diesel", "Electric or hybrid", "None" }, { "Yes", "No", "Some of the time", "Only during lockdown" } };
            int[,] carbon2 = { { 256, 200, 110, 42 }, { 1703, 290, 30, 0 },{ 600, 373, 191, 30 },{ 4163, 3707, 1149, 0 },{ 0, 400, 200, 150 } };
            double max2 = 7122;
            double min2 = 72;

            string[] questions3 = { "How often do you turn off the light when leaving a room? ", "What do you typically recycle? ", "How much of your household electricity do you generate yourself - e.g. solar panels? ", "How many bedrooms are there in your house? ", "" };
            string[,] answers3 = { { "Always", "Most of the time", "Some of the time", "Very rarely " }, { "Glass, Cans and plastic", "Cans and plastic", "Plastic ", "Nothing" }, { "None", "1%-50%", "50%-90%", "More than 90%" }, { "1", "2", "3", "4 or more" }, { "", "", "", "" }, };
            int[,] carbon3 = { { 0, 72, 144, 288 }, { 0, 31, 111, 211 }, { 546, 452, 264, 170 }, { 250, 446, 650, 800 }, { 0, 0, 0, 0 } };
            double max3 = 1845;
            double min3 = 420;

            string[] questions4 = { "When disposing of a computer, do you recycle it?", "How much of a breakage is necessary for you to replace your phone or computer? ", "Do you have separate work and personal devices?", "Question 4", "Question 5" };
            string[,] answers4 = { { "Yes", "No", "N/A", "N/A" }, { "Breaking beyond any hope of use", "Breaking it so some function is limited", "Cosmetic breakage", "Just want a newer model" }, { "No, I use my personal device for work too", "Shared devices exist at work which I use along side my personal device", "I have one extra device to manage workload", "Yes, I have separate devices" }, { "Question 1", "Question 2", "Question 3", "Question 4" }, { "Question 1", "Question 2", "Question 3", "Question 4" }, };
            int[,] carbon4 = { { 112, 175, 0, 0 }, { 43, 86, 175, 350 }, { 194, 229, 290, 388 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, };
            double max4 = 0;
            double min4 = 0;

            string[] questions5 = { "Question 1", "Question 2", "Question 3", "Question 4", "Question 5" };
            string[,] answers5 = { { "Answer 1", "Answer 2", "Answer 3", "Answer 4" }, { "Question 1", "Question 2", "Question 3", "Question 4" }, { "Question 1", "Question 2", "Question 3", "Question 4" }, { "Question 1", "Question 2", "Question 3", "Question 4" }, { "Question 1", "Question 2", "Question 3", "Question 4" }, };
            int[,] carbon5 = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, };
            double max5 = 0;
            double min5 = 0;


            double count = 0;
 
            foreach (int section in sections)
            {
                if (section == 1)
                {
                    carbonTotal = 0;
                    Console.WriteLine("This section is on FOOD");
                    Console.WriteLine("26% of global emissions come from the food we eat. Answer these simple questions to find out how you can improve and try and reduce this massive value");
                    Ask(questions1, answers1, carbon1, ref carbonTotal);
                    Console.WriteLine($"Your score for this section is {Calculate(carbonTotal, max1, min1)}");
                    count = count + Calculate(carbonTotal, max1, min1);
                }
                else if (section == 2)
                {
                    carbonTotal = 0;
                    Console.WriteLine("This section is on TRAVEL");
                    Console.WriteLine("Transport accounts for around one-fifth of global carbon dioxide (CO2) emissions [24% if we only consider CO2 emissions from energy]. In some countries – often richer countries with populations that travel often – transport can be one of the largest segments of an individual’s carbon footprint");
                    Ask(questions2, answers2, carbon2, ref carbonTotal);
                    Console.WriteLine($"Your score for this section is {Calculate(carbonTotal, max2, min2)}");
                    count = count + Calculate(carbonTotal, max2, min2);
                }
                else if (section == 3)
                {
                    carbonTotal = 0;
                    Console.WriteLine("This section is on HOUSEHOLDS");
                    Console.WriteLine("Carbon footprint emissions increases with the income but all houses leave a mark. Small actions can really decrease the footprint");
                    Ask(questions3, answers3, carbon3, ref carbonTotal);
                    Console.WriteLine($"Your score for this section is {Calculate(carbonTotal, max3, min3)}");
                    count = count + Calculate(carbonTotal, max3, min3);
                }
                else if (section == 4)
                {
                    carbonTotal = 0;
                    Console.WriteLine("This section is about EWASTE");
                    Console.WriteLine("Waste is the fourth largest source sector of emissions, accounting for 3% of total greenhouse gas emissions in 2017 and often we throw things away unnecessarily");
                    Ask(questions4, answers4, carbon4, ref carbonTotal);
                    Console.WriteLine($"Your score for this section is {Calculate(carbonTotal, max4, min4)}");
                    count = count + Calculate(carbonTotal, max4, min4);
                }
                else if (section == 5)
                {
                    carbonTotal = 0;
                    Ask(questions5, answers5, carbon5, ref carbonTotal);
                    Console.WriteLine($"Your score for this section is {Calculate(carbonTotal, max5, min5)}");
                    count = count + Calculate(carbonTotal, max5, min5);
                }

                Console.WriteLine();
                Console.WriteLine($"\nYou have just finished section {section}");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine($"According to the results of this quiz you have {count} impact points.");
            Console.ReadLine();

        }
        static void Ask(string[] questions, string[,] answers, int[,] carbon, ref int carbonTotal)
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine();
                Console.WriteLine($"{questions[x]}");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"\n{j + 1}. {answers[x,j]}");
                    }

                ReadIn(carbon, ref carbonTotal, x);
                Console.WriteLine("");
            }
        }
        static void ReadIn(int[,] carbon, ref int carbonTotal, int x)
        {

            int choice = 0;
            bool success = false;

            while (success == false)
            {
                Console.WriteLine("\nEnter the number of your choice");
                string input = Console.ReadLine();

                success = Int32.TryParse(input, out choice);
                if (success)
                {
                    Console.WriteLine("This section would contain advice about what you're doing currently affects the environment and how to imrove it. We would include links and resouces to help the user lead a more sustainable life");
                }
                else
                {
                    Console.WriteLine("Please enter a valid result");
                }
            }

            carbonTotal = carbonTotal + carbon[x, choice - 1];
        }
        static double Calculate(double carbonTotal, double maxCarbon, double minCarbon)
        {
            double output = ((carbonTotal - minCarbon) / (maxCarbon - minCarbon)) * 100;
            return Math.Round(output, 0);
        }
    }
}

