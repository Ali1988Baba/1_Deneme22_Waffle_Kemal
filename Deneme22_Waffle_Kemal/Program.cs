namespace Deneme22_Waffle_Kemal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO KEMAL WAFFLE");
            Console.WriteLine("***********************");
            Console.WriteLine("Enter A Waffle Porsion Quantity :");
            int porsionQuantity2 = Convert.ToInt32(Console.ReadLine());    

            Random rnd3 = new Random();
            int queueNumber1 = rnd3.Next(0, 105);
            Console.WriteLine("QUEUE :" + queueNumber1);
            bool waffleStep3 = true;
            string chiefsNumbers = "1_CHİEF 1\n" + "2_CHİEF 2\n" + "3_CHİEF 3";
            Console.WriteLine(chiefsNumbers);
            if (waffleStep3)
            {
                Console.WriteLine("Next");
                while (true)
                {
                    if (queueNumber1 <= 35 || queueNumber1 == 1)
                    {
                        Console.WriteLine("SELECT A CHİEF");
                        string chiefSelect = Console.ReadLine();
                        waffleStep3 = true;
                        Random rnd4 = new Random();
                        int tableNumber11 = rnd4.Next(0, 100);
                        Console.WriteLine("TABLE NUMBER :" + tableNumber11);
                        Console.WriteLine("Print");
                        break;
                    }
                    if (queueNumber1 <= 70 || queueNumber1 == 36)
                    {
                        Console.WriteLine("SELECT A CHİEF");
                        string chiefSelect = Console.ReadLine();
                        waffleStep3 = true;
                        Random rnd4 = new Random();
                        int tableNumber21 = rnd4.Next(0, 100);
                        Console.WriteLine("TABLE NUMBER :" + tableNumber21);
                        Console.WriteLine("Print");
                        break;
                    }

                    if (queueNumber1 <= 105 || queueNumber1 == 71)
                    {
                        Console.WriteLine("SELECT A CHİEF");
                        string chiefSelect = Console.ReadLine();
                        waffleStep3 = true;
                        Random rnd4 = new Random();
                        int tableNumber31 = rnd4.Next(0, 100);
                        Console.WriteLine("TABLE NUMBER :" + tableNumber31);
                        Console.WriteLine("Print");
                        break;
                    }
                }
            }
        }
    }
}