using System;

class NumberAsWords
{
    static void Main()
    {
        string numString = Console.ReadLine();
        int d = int.Parse(numString);

        // 0 - 19
        if (d <= 20)
        {
            switch (numString)
            {
                case "0": Console.WriteLine("Zero"); break;
                case "1": Console.WriteLine("One"); break;
                case "2": Console.WriteLine("Two"); break;
                case "3": Console.WriteLine("Three"); break;
                case "4": Console.WriteLine("Four"); break;
                case "5": Console.WriteLine("Five"); break;
                case "6": Console.WriteLine("Six"); break;
                case "7": Console.WriteLine("Seven"); break;
                case "8": Console.WriteLine("Eight"); break;
                case "9": Console.WriteLine("Nine"); break;
                case "10": Console.WriteLine("Ten"); break;
                case "11": Console.WriteLine("Eleven"); break;
                case "12": Console.WriteLine("Twelve"); break;
                case "13": Console.WriteLine("Thirteen"); break;
                case "14": Console.WriteLine("Fourteen"); break;
                case "15": Console.WriteLine("Fifteen"); break;
                case "16": Console.WriteLine("Sixteen"); break;
                case "17": Console.WriteLine("Seventeen"); break;
                case "18": Console.WriteLine("Eighteen"); break;
                case "19": Console.WriteLine("Nineteen"); break;
            }
        }

        // 20 - 99
        else if (d >= 20 && d <= 99)
        {
            int[] numArray = new int[2];
            char[] array = numString.ToCharArray();
            for (int i = 0; i < 2; i++)
            {
                char letter = array[i];
                numArray[i] = (int)Char.GetNumericValue(letter);
            }
            if (numArray[0] == 2)
            {
                Console.Write("Twenty ");
                switch (numArray[1])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[0] == 3)
            {
                Console.Write("Thirty ");
                switch (numArray[1])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[0] == 4)
            {
                Console.Write("Forty ");
                switch (numArray[1])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[0] == 5)
            {
                Console.Write("Fifty ");
                switch (numArray[1])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[0] == 6)
            {
                Console.Write("Sixty ");
                switch (numArray[1])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[0] == 7)
            {
                Console.Write("Seventy ");
                switch (numArray[1])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[0] == 8)
            {
                Console.Write("Eighty ");
                switch (numArray[1])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[0] == 9)
            {
                Console.Write("Ninety ");
                switch (numArray[1])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
        }


        // 100 - 999
        else if (d >= 100 && d <= 999)
        {

            int[] numArray = new int[3];
            char[] array = numString.ToCharArray();
            for (int i = 0; i < 3; i++)
            {
                char letter = array[i];
                numArray[i] = (int)Char.GetNumericValue(letter);
            }
            switch (numArray[0])
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }
            if (numArray[1] == 0)
            {
                switch (numArray[2])
                {
                    case 1: Console.WriteLine("and one"); break;
                    case 2: Console.WriteLine("and two"); break;
                    case 3: Console.WriteLine("and three"); break;
                    case 4: Console.WriteLine("and four"); break;
                    case 5: Console.WriteLine("and five"); break;
                    case 6: Console.WriteLine("and six"); break;
                    case 7: Console.WriteLine("and seven"); break;
                    case 8: Console.WriteLine("and eight"); break;
                    case 9: Console.WriteLine("and nine"); break;
                }
            }
            else if (numArray[1] == 1)
            {
                switch (numArray[2])
                {
                    case 0: Console.WriteLine("and ten"); break;
                    case 1: Console.WriteLine("and eleven"); break;
                    case 2: Console.WriteLine("and twelve"); break;
                    case 3: Console.WriteLine("and thirteen"); break;
                    case 4: Console.WriteLine("and fourteen"); break;
                    case 5: Console.WriteLine("and fifteen"); break;
                    case 6: Console.WriteLine("and sixteen"); break;
                    case 7: Console.WriteLine("and seventeen"); break;
                    case 8: Console.WriteLine("and eighteen"); break;
                    case 9: Console.WriteLine("and nineteen"); break;
                }
            }
            else if (numArray[1] == 2)
            {
                Console.Write("and twenty ");
                switch (numArray[2])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[1] == 3)
            {
                Console.Write("and thirty ");
                switch (numArray[2])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[1] == 4)
            {
                Console.Write("and forty ");
                switch (numArray[2])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[1] == 5)
            {
                Console.Write("and fifty ");
                switch (numArray[2])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[1] == 6)
            {
                Console.Write("and sixty ");
                switch (numArray[2])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[1] == 7)
            {
                Console.Write("and seventy ");
                switch (numArray[2])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[1] == 8)
            {
                Console.Write("and eighty ");
                switch (numArray[2])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (numArray[1] == 9)
            {
                Console.Write("and ninety ");
                switch (numArray[2])
                {
                    case 0: Console.Write("\n"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
        }
    }
}