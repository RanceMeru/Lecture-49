class Program
{
    static void Main(string[] args)
    
    {
        /*  
        Prompt the user to input an integer then to have it be squared and cubed using 

        
        */
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        int Squared = Square(number);
        Console.WriteLine("{0} Squared is {1}",number, Squared);
        int cubed = Cubed(number);
        Console.WriteLine("{0} Cubed is {1}",number, cubed);


    }
    public static int Square(int number)
    {
        int answer = number*number;
        return answer;

    }
    public static int Cubed(int number)
    {

        int answer = Square(number)*number;
        return answer;
    }
}