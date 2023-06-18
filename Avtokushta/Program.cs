using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtokushta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CarDealerShip> list = new List<CarDealerShip>();
            Console.Write($"Vuvedi broi: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                CarDealerShip car = new CarDealerShip();
                car.Input();
                list.Add(car);
            }

            Console.WriteLine($"1. Printirai vsichki koli");
            Console.WriteLine($"2. Printirai vsichki koli po zadadena marka");
            Console.WriteLine($"3. Printirai vsichki koli po zadaden cenovi diapazon");
            Console.WriteLine($"4. Aktualizirai ili iztrii informaciq za avtomobil po dadena marka");
            Console.WriteLine($"5. Iztrii kola po zadadena marka");
            Console.WriteLine($"6. Printirai  srednata vuzrast na kolite kola");
            Console.WriteLine($"8. Printirai  informaciq za nai-novata kola po zadadena marka");
            Console.WriteLine($"9. Printirai  vsichki koli sortirani po cenite im");
            Console.WriteLine($"10. Izhod");
            Console.WriteLine();

            Console.Write($"Vuvedi nomer na komanda: ");
            int command = int.Parse(Console.ReadLine());

            while (command < 10)
            {
                switch (command)
                {
                    case 1:
                        foreach (var item in list)
                        {
                            item.Print();
                        }
                        break;

                    case 2:
                        Console.Write($"Marka za tursene: ");
                        string brandSearch = Console.ReadLine().ToLower();
                        foreach (var item in list)
                        {
                            if (item.Brand.ToLower() == brandSearch)
                            {
                                item.Print();
                            }
                        }
                        break;

                    case 3:
                        Console.Write($"Minimalna cena: ");
                        int down = int.Parse(Console.ReadLine());
                        Console.Write($"Maksimalna cena: ");
                        int up = int.Parse(Console.ReadLine());
                        foreach (var item in list)
                        {
                            if (item.Price >= down && item.Price <= up)
                            {
                                item.Print();
                            }
                        }
                        break;

                    case 4:
                        Console.Write($"Aktualizaciq ili iztrivane: ");
                        string cmd = Console.ReadLine().ToLower();
                        if (cmd == "Aktualizaciq ")
                        {
                            Console.Write("Marka za aktualizaciq: ");
                            string brandAct = Console.ReadLine().ToLower();
                            foreach (var item in list)
                            {
                                if (item.Brand.ToLower() == brandAct)
                                {
                                    item.Input();
                                }
                            }
                        }
                        else
                        {
                            Console.Write("Marka za iztrivane: ");
                            string brandDel = Console.ReadLine().ToLower();
                            list.RemoveAll(item => item.Brand.ToLower() == brandDel);
                        }
                        break;

                    case 5:
                        Console.Write($"Marka za iztrivane: ");
                        string brandDelete = Console.ReadLine().ToLower();
                        list.RemoveAll(item => item.Brand.ToLower() == brandDelete);
                        break;

                    case 6:
                        var avg = 0.0;
                        foreach (var item in list)
                        {
                            avg += item.Year;
                        }
                        avg = avg / list.Count;
                        Console.WriteLine($"Sredna vuzrast na kolite: {avg:f2} godina.");
                        break;

                    case 7:
                        var oldest = 99999999;
                        foreach (var item in list)
                        {
                            if (item.Year < oldest)
                            {
                                oldest = item.Year;
                            }
                        }

                        foreach (var item in list)
                        {
                            if (item.Year == oldest)
                            {
                                item.Print();
                            }
                        }
                        break;

                    case 8:
                        var newest = -99999999;
                        Console.Write($"Marka: ");
                        string brandSearch2 = Console.ReadLine().ToLower();
                        foreach (var item in list)
                        {
                            if (item.Brand.ToLower() == brandSearch2)
                            {
                                if (item.Year > newest)
                                {
                                    newest = item.Year;
                                }
                            }
                        }

                        foreach (var item in list)
                        {
                            if (item.Year == newest)
                            {
                                item.Print();
                            }
                        }
                        break;

                    case 9:
                        list.Sort((x, y) => x.Price.CompareTo(y.Price));
                        foreach (var item in list)
                        {
                            item.Print();
                        }
                        break;

                    default:
                        break;
                }
                Console.Write($"Natisni kopche za da produljish!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"1. Printirai vsichki koli");
                Console.WriteLine($"2. Printirai vsichki koli po zadadena marka");
                Console.WriteLine($"3. Printirai vsichki koli po zadaden cenovi diapazon");
                Console.WriteLine($"4. Aktualizirai ili iztrii informaciq za avtomobil po dadena marka");
                Console.WriteLine($"5. Iztrii kola po zadadena marka");
                Console.WriteLine($"6. Printirai  srednata vuzrast na kolite kola");
                Console.WriteLine($"8. Printirai  informaciq za nai-novata kola po zadadena marka");
                Console.WriteLine($"9. Printirai  vsichki koli sortirani po cenite im");
                Console.WriteLine($"10. Izhod");
                Console.WriteLine();

                Console.Write($"Vuvedi nomer na komanda: ");
                command = int.Parse(Console.ReadLine());
            }
        }
    }
}
