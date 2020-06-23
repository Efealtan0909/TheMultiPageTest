using System;

namespace TheMultiPageTest
{
    class Program
    {
        static void Main()
        {
            bool mainpage = true;
            bool firstpage = false;
            bool secondpage = false;
            bool close = false;
            while (close == false)
            {
                if (mainpage == true)
                {
                    Console.Clear();
                    Console.WriteLine("----| Main Menu |----");
                    Console.WriteLine("\n(1) Firstpage");
                    Console.WriteLine("(2) secondpage");
                    Console.WriteLine("(3) close\n");
                    Console.Write("Selection>");
                    string selection = Console.ReadLine();
                    if (selection == "1")
                    {
                        mainpage = false;
                        firstpage = true;
                        secondpage = false;
                        close = false;
                    }
                    else if (selection == "2")
                    {
                        mainpage = false;
                        firstpage = false;
                        secondpage = true;
                        close = false;
                    }
                    else if (selection == "3")
                    {
                        mainpage = false;
                        firstpage = false;
                        secondpage = false;
                        close = true;
                    }
                    else
                    {
                        Console.Clear();
                        mainpage = true;
                        firstpage = false;
                        secondpage = false;
                        close = false;
                        Console.WriteLine("Error");
                    }
                }
                else if (firstpage == true)
                {
                    Console.Clear();
                    Console.WriteLine("----| First Page |----");
                    Console.WriteLine("that is the first page");
                    Console.WriteLine("(1) go back\n");
                    Console.Write("Selection>");
                    string fpselection = Console.ReadLine();
                    if(fpselection == "1")
                    {
                        Console.Clear();
                        mainpage = true;
                        firstpage = false;
                        secondpage = false;
                        close = false;
                    } else
                    {
                        Console.Clear();
                        mainpage = false;
                        firstpage = true;
                        secondpage = false;
                        close = false;
                        Console.WriteLine("Error");
                    }
                }
                else if (secondpage == true)
                {
                    Console.Clear();
                    Console.WriteLine("----| Second Page |----");
                    Console.WriteLine("that is the second page");
                    Console.WriteLine("(1) close\n");
                    Console.Write("Selection>");
                    string spselection = Console.ReadLine();
                    if(spselection == "1")
                    {
                        Console.Clear();
                        mainpage = true;
                        firstpage = false;
                        secondpage = false;
                        close = false;
                    } else
                    {
                        Console.Clear();
                        mainpage = false;
                        firstpage = false;
                        secondpage = true;
                        close = false;
                        Console.WriteLine("Error");
                    }
                }
                else if (close == true)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    mainpage = true;
                    firstpage = false;
                    secondpage = false;
                    close = false;
                    Console.WriteLine("Error");
                }
            }
        }
    }
}