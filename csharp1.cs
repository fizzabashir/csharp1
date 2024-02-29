     
//QNO1

{
        Console.WriteLine("Grade Calculator\n");
        double averageMarks = (GetValidMarks("Computer") + GetValidMarks("Science") + GetValidMarks("English")) / 3.0;

        Console.WriteLine($"\nAverage marks: {averageMarks}\n");
        char finalGrade;
        switch ((int)averageMarks / 10)
        {
         
            case 1:
                finalGrade = 'A';
                break;
            case 2:
                finalGrade = 'B';
                break;
            case 3:
                finalGrade = 'C';
                break;
            case 4:
                finalGrade = 'D';
                break;
            default:
                finalGrade = 'F';
                break;
        }

        Console.WriteLine($"Final Grade: {finalGrade}");
    }

    static int GetValidMarks(string subject)
    {
        int marks;
        do
        {
            Console.Write($"Enter marks for {subject}: ");
        } while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100);

        return marks;
}

//qno2

 
{
    
    {
        char choice;

        do
        {
            Console.WriteLine("Choose the temperature scale to convert from:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.Write("Enter your choice: ");

            int scaleChoice;
            if (!int.TryParse(Console.ReadLine(), out scaleChoice) || scaleChoice < 1 || scaleChoice > 2)
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
     
            }

            double inputTemp;
            double convertedTemp;
            string fromScale, toScale;

            if (scaleChoice == 1)
            {
                Console.Write("Enter the temperature in Celsius: ");
                inputTemp = Convert.ToDouble(Console.ReadLine());
                convertedTemp = (inputTemp * 9 / 5) + 32;
                fromScale = "Celsius";
                toScale = "Fahrenheit";
            }
            else
            {
                Console.Write("Enter the temperature in Fahrenheit: ");
                inputTemp = Convert.ToDouble(Console.ReadLine());
                convertedTemp = (inputTemp - 32) * 5 / 9;
                fromScale = "Fahrenheit";
                toScale = "Celsius";
            }

            Console.WriteLine($"{inputTemp}°{fromScale} is equal to {convertedTemp}°{toScale}.");

            Console.Write("Do you want to convert another temperature? (Y/N): ");
            choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

        }
        while (choice == 'Y');

        Console.WriteLine("Thank you for using the temperature converter!");
    }
}


