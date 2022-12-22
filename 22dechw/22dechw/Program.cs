using System;

namespace _22dechw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueStr;
            int value;
            
            Notebook[] notebooks = new Notebook[0];

            do
            {
                Console.WriteLine("1.Notebook elave et");
                Console.WriteLine("2.Notebooklar uzerinde axtaris et");
                Console.WriteLine("0.Menudan cix");
                valueStr = Console.ReadLine();
                value = Convert.ToInt32(valueStr);
                string priceStr;
                int price=0;
                if (value == 1)
                {
                    bool ispricenormal = true;
                    
                    Console.WriteLine("Notebookun Adini daxil edin:");
                    var add = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Notebookun qiymetini daxil edin:");
                        try
                        {
                            priceStr = Console.ReadLine();
                            price = Convert.ToInt32(priceStr);
                            if (price < 0)
                            {
                                Console.WriteLine("Menfi ola bilmez");
                                ispricenormal = false;
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Xeta:" + e.Message);
                        }

                    } while (ispricenormal == false);
                    
                    
                    Console.WriteLine("Notebookun ramini daxil edin:");
                    var ramStr = Console.ReadLine();
                    int ram = Convert.ToInt32(ramStr);
                    bool isramnormal = true;

                    
                    do
                    {
                        Console.WriteLine("Notebookun ramini daxil edin:");
                        try
                        {
                            ramStr = Console.ReadLine();
                            ram = Convert.ToInt32(ramStr);
                            if (price < 0 && price > 128)
                            {
                                Console.WriteLine("Menfi ve 0 ola bilmez ve 128den boyuk ola bilmez");
                                isramnormal = false;
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Xeta:" + e.Message);
                            isramnormal = false;
                        }

                    } while (isramnormal == false);
                    Notebook Laptop = new Notebook(add, price, ram);
                    AddLaptop(ref notebooks, Laptop);

                }

                else if (value == 2)
                {
                    Console.WriteLine("Axtarmaq istediyiniz Notebookun bir deyerini daxil edin:");
                    var deyer = Console.ReadLine();
                    for (int i = 0; i < notebooks.Length; i++)
                    {
                        if (notebooks[i].Name.Contains(deyer))
                        {
                            Console.WriteLine(notebooks[i].GetInfo());
                        }
                    }
                }
                else if (value == 0)
                {
                    break;
                }


            } while (value != 0);

        }
        static void AddLaptop(ref Notebook[] notebooks, Notebook notebook)
        {
            Notebook[] makenewarr = new Notebook[notebooks.Length + 1];

            for (int i = 0; i < notebooks.Length; i++)
            {
                makenewarr[i] = notebooks[i];
            }
            makenewarr[makenewarr.Length - 1] = notebook;
            notebooks = makenewarr;
        }

    }
}
