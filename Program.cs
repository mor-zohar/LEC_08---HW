internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("-------------------- EX_01 --------------------");
        Console.WriteLine("-----------------------------------------------\n");
        
        Console.WriteLine("Enter A String:");
        string str = Console.ReadLine();

        Ex1(str);
        
        Console.WriteLine("\n-----------------------------------------------\n");
        /***************************************************************************************/

        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("-------------------- EX_02 --------------------");
        Console.WriteLine("-----------------------------------------------\n");
       
        Console.WriteLine("Please Enter A String:\n");
        string str1 = Console.ReadLine();

        Console.WriteLine($"\nYour String Length is: {str1.Length}");
        
        Console.WriteLine("\n-----------------------------------------------\n");
        /***************************************************************************************/

        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("-------------------- EX_03 --------------------");
        Console.WriteLine("-----------------------------------------------\n");
        
        Console.WriteLine("Please Enter 2 Strings:\n");
        string str2 = Console.ReadLine();
        string str3 = Console.ReadLine();

        Ex3(str2, str3);
      
        Console.WriteLine("\n-----------------------------------------------\n");
        /***************************************************************************************/

        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("-------------------- EX_04 --------------------");
        Console.WriteLine("-----------------------------------------------\n");

        Console.WriteLine("Please Enter 2 Equal Strings:\n");
        string str4 = Console.ReadLine();
        string str5 = Console.ReadLine();

        Console.WriteLine($"\nThe Strings Are Equal: {str4.Equals(str5)}");

        Console.WriteLine("\n-----------------------------------------------\n");
        /***************************************************************************************/
    }

    //-------------------- EX_01 --------------------

    static void Ex1(string str)
    {
        if (str[0] >= 'a' && str[0] <= 'z' && str.Length >= 8 && str[str.Length - 1] >= '0' && str[str.Length - 1] <= '9')
        {
            Console.WriteLine("GOOD");
        }
        else
        {
            Console.WriteLine("NOT GOOD");
        }
    }

    //-------------------- EX_03 --------------------

    static void Ex3(string str2, string str3)
    {
        if (str2.Length < str3.Length)
        {
            Console.WriteLine($"\n{str3} Is Longger Then {str2}");

        }
        else if (str2.Length > str3.Length)
        {
            Console.WriteLine($"\n{str2} - Is Longger Then - {str3}");
        }
        else
        {
            Console.WriteLine($"\n{str2} - Is Equal to - {str3}");
        }
    }

}