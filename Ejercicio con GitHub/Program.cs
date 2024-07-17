Console.WriteLine("---------------------------------");
Console.WriteLine("             WELCOME");
Console.WriteLine("---------------------------------");
while(true)
{
    try
    {
        Console.Clear();
        int option;
        Console.WriteLine("Choose a option: ");
        option = Convert.ToInt32(Console.ReadLine());
        Console.ReadKey();
        switch (option)
        {
            case 1:
                while (true)
                {

                    {
                        
                        try
                        {
                            Console.Clear ();

                        }
                        catch
                        {

                        }


                    }
                    Console.ReadKey ();
                }

                break;
        }
    }
    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid Format");
        Console.ResetColor();

    }

}
