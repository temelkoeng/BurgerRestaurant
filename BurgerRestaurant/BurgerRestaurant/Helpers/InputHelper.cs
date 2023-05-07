using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Helpers
{
    public static class InputHelper
    {
        public static int GetBurgerInput()
        {
            int burgerType = 0;
            do
            {
                string input = Console.ReadLine();

                try
                {
                    burgerType = int.Parse(input);
                    if (burgerType == 1 || burgerType == 2 || burgerType == 3)
                        break;
                    else
                        throw new Exception();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Невалиден тип! Моля изберете число между 1 и 3");
                }

            } while (true);

            return burgerType;
        }

        public static bool AskTheClientForDecoration()
        {
            do
            {
                string input = Console.ReadLine();
                try
                {
                    if (input.ToLower() == "y")
                    {
                        return true;
                    }
                    else if (input.ToLower() == "n")
                    {
                        return false;
                    }
                    else
                    {
                        throw new Exception("Моля отговорете с 'y' или 'n'.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        public static int GetDecorationNumber()
        {
            do
            {
                string input = Console.ReadLine();
                try
                {
                    int inputNumber = int.Parse(input);
                    if (inputNumber == 1 || inputNumber == 2)
                    {
                        return inputNumber;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Моля въведете отговорете с 1 или 2.");
                }
            } while (true);
        }
    }
}
