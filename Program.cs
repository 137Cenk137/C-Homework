internal class Program
{
    private static void Main(string[] args)
    {
        Act act = new Act();
        //act.Homework1();
        //act.Homework2();
        act.Homework3();
    }
}

class Act
{
    public void Homework1(){
        Console.Write("bir sayı giriniz: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] ints= new int[x];
        for (int i = 0; i < x; i++)
        {
            Console.Write($"{i+1} . sayiyi giriniz: ");

            ints[i] = Convert.ToInt32(Console.ReadLine());
            //if(ints[i]%2 == 0)
             //      console.writeline(ints[i]);       
        }
        foreach (var item in ints)
        {
            if  (item%2 == 0)
                Console.WriteLine(item);

        }

    }

    public void Homework2() 
    {
        Console.WriteLine("2 tane sayı giriniz");
        Console.Write("first number: ");
         int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("second number: ");
         int m = Convert.ToInt32(Console.ReadLine());
         int[] ints= new int[n];
         for (int i = 0; i < n; i++)
        {
            Console.Write($"{i+1} . sayiyi giriniz: ");

            ints[i] = Convert.ToInt32(Console.ReadLine());
            if (ints[i]%m == 0 || ints[i] ==m )
                Console.WriteLine(ints[i]);
        }         

    }

    public void Homework3()
    {
        Console.Write("bir sayı giriniz: ");
        Console.Write("first number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] strings= new string[n];
         for (int i = 0; i < n; i++)
        {
            Console.Write($"{i+1} . kelime giriniz: ");

            strings[i] = Console.ReadLine();
        }
       for (int i = n-1; i >=0; i--)
       {
            Console.WriteLine(strings[i]);
       }

    }
}