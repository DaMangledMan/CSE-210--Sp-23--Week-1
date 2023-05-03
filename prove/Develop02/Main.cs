public class Main
{
    // methods
    // menu to select which option you mant
    public void Menu()
    {
        int option;
        while (true)
        {
            try
            {
                Console.Write("Which option would you like to choose ( 1 - 5 )?\n");
                Console.WriteLine(" 1. Write\n 2. Display\n 3. Load\n 4. Save\n 5. Quit\n");
                option = int.Parse(Console.ReadLine());

                if (option >= 1 && option <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your Input was not one of the options.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("the input was not in the correct format. Integers only.");
            }
        }

        if (option == 5)
        {
            Quit();
        }

        if (option == 1)
        {
            Write();
        }
        else if (option == 2)
        {
            Display();
        }
        else if (option == 3)
        {
            Load();
        }
        else if (option == 4)
        {
            Save();
        }
    }

    // option 5: quit
    public void Quit()
    {
        
    }

    // option 1: write
    public void Write()
    {

    }

    // option 2: display
    public void Display()
    {

    }

    // option 3: load
    public void Load()
    {

    }

    // option 4: save
    public void Save()
    {

    }
}