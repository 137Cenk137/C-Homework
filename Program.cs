internal class Program
{
    private static void Main(string[] args)
    {
        Act act = new Act();
        act.Homework1();
        
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
        }
        foreach (var item in ints)
        {
            if  (item%2 == 0)
                Console.WriteLine(item);

        }

    }
}