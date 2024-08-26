

//Part 1
//Write a C# program to add and subtract days from the date.
//Test Data:
//Enter the date: 12/10/2020
//Enter the number of days to add or subtract: 5
//Expected Output:
//Date after 5 days: 17/10/2020
//Date before 5 days: 07/10/2020

bool CheckLeapYear(int year)
{

    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    {
        return true;
    }

    return false;

}


void afterAndBeforeTheDate()
{
    Console.Write("Enter the date(dd/mm/y): ");
    string input1 = Console.ReadLine();

    Console.Write("Enter the number of days to add or subtract: ");
    string input2 = Console.ReadLine();

    int day = int.Parse(input1.Substring(0, 2));

    int month = int.Parse(input1.Substring(3, 2));

    int year = int.Parse(input1.Substring(6));

    int dayToHandle = int.Parse(input2);

    int addDay = day + dayToHandle;

    int subDay = day - dayToHandle;

    int addMonth = 0;
    int subMonth = 0;

    int addYear = 0;

    int subYear = 0;


    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
    {
        if (day >= 1 && day <= 31)
        {
            addMonth = month;
            subMonth = month;
            addYear = year;
            subYear = year;
            if (addDay > 31)
            {
                addDay -= 31;
                addMonth = month + 1;
                if (month == 12)
                {
                    addYear = year + 1;
                }
            }
            if (subDay < 1)
            {
                subMonth = month - 1;
                if (month == 8)
                {
                    subDay = 31 + subDay;

                }
                else if (month == 3)
                {
                    if (CheckLeapYear(year))
                    {
                        subDay = 29 + subDay;
                    }
                    else
                    {
                        subDay = 28 + subDay;

                    }
                }
                else if(month == 1)
                {
                    subDay = 31 + subDay;
                    subYear = year - 1;
                }else{
                    subDay = 30 + subDay;

                }
            }

        }
    }
    else if (month == 2)
    {
        addMonth = month;
        subMonth = month;
        addYear = year;
        subYear = year;
        if (CheckLeapYear(year))
        {
            if (day >= 1 && day <= 29)
            {
                if (addDay > 29)
                {
                    addDay -= 29;
                    addMonth = month + 1;
                }
                if(subDay < 1){
                    subDay = 31 + subDay;
                    subMonth = month - 1;
                }
            }
          
        }
        else
        {
            
            if (day >= 1 && day <= 28)
            {
                if (addDay > 28)
                {
                    addDay -= 28;
                    addMonth = month + 1;
                }
                if(subDay < 1){
                    subDay = 31 - subDay;
                    subMonth = month - 1;
                }
            }
        }
    }
    else
    {
        addMonth = month;
        subMonth = month;
        addYear = year;
        subYear = year;
        if (day >= 1 && day <= 30)
        {
            if (addDay > 30)
            {
                addDay -= 30;
                addMonth = month + 1;
            }
            if (subDay < 1)
            {
                subMonth = month - 1;
                subDay = 31 + subDay;
               
            }
        }
    }

    Console.WriteLine($"Date after 5 days: {addDay}/{addMonth}/{addYear}");
    Console.WriteLine($"Date before 5 days: {subDay}/{subMonth}/{subYear}");
}
// afterAndBeforeTheDate();



//Part 2
//Write a C# program to take input from the user and calculate the age of the user.
//Test Data:
//Enter your date of birth: 12/10/1990
//Expected Output:
//You are 30 years, 1 months, 21 days old

void calculateAge(){
    Console.Write("Enter your date of birth(dd / MM / yyyy): ");
    string input = Console.ReadLine();

    int ageOfYear = 0;
    int ageOfMonth = 0;
    int ageOfDay = 0;

    DateTime dateTime = DateTime.Now;
    string date = dateTime.ToString("dd / MM / yyyy");

    int day = int.Parse(input.Substring(0, 2));
    int month = int.Parse(input.Substring(3, 2));
    int year = int.Parse(input.Substring(6));

    Console.WriteLine($"Current Date: {date}");

    int currentDay = dateTime.Day;
    int currentMonth = dateTime.Month;
    int currentYear = dateTime.Year;


    ageOfYear = currentYear - year;

    if(currentDay < day){
        ageOfYear--;
    }


    ageOfMonth = currentMonth - month;

    ageOfDay = currentDay - day;

    if(ageOfDay < 0){
        ageOfMonth--;

        ageOfDay +=  DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1);

    }
    if(ageOfMonth < 0){
        ageOfYear--;
        ageOfMonth += 12;
    }

    Console.WriteLine($"You are {ageOfYear} years, {ageOfMonth} months, {ageOfDay} days old");
}
// calculateAge();


//Part 3
//Write a C# program to take input from the user and calculate the difference between two dates.
//Test Data:
//Enter the first date: 12/10/2020
//Enter the second date: 16/10/2020
//Expected Output:
//The difference between two dates is: 4 days

void calculateDifference(){
    Console.Write("Enter the first date: ");
    string input1 = Console.ReadLine();

    Console.Write("Enter the second date: ");
    string input2 = Console.ReadLine();

    DateTime firstDate = DateTime.ParseExact(input1, ("dd/mm/yyyy"), null);
    DateTime secondDate = DateTime.ParseExact(input2, ("dd/mm/yyyy"), null);


    TimeSpan difference = secondDate - firstDate;

    int daysDifference = Math.Abs(difference.Days);

    Console.WriteLine($"The difference between two dates is: {difference} days");

   
}

// calculateDifference();

//Part 4
//Write a C# program to take the input (days) from the user and Convert days into years, weeks and days.
//Test Data:
//Enter the number of days: 1329
//Expected Output:
//Years: 3
//Weeks: 33
//Days: 3

void convertDays(){

    Console.Write("Enter the number of days: ");
    string input = Console.ReadLine();

    int dayInput = int.Parse(input);

    int years = dayInput / 365;

    dayInput %= 365;

    int week = dayInput / 7;

    int days =  dayInput %= 7;

    Console.WriteLine($"Years: {years}\n Weeks: {week}\n Days: {days}");


}
// convertDays();

//Part 5
//Write a C# program to take the input from the user and print day name of week.
//Test Data:
//Enter the number of day: 4
//Expected Output:
//Thursday

void weekDay(){
    Console.Write("Enter the number of day: ");
    string input = Console.ReadLine();

    int numberOfDay = int.Parse(input);

    switch (numberOfDay)
    {
        case 1:
        Console.WriteLine("Monday");
        break;
        case 2:
        Console.WriteLine("Tuesday");
        break;
        case 3:
        Console.WriteLine("Wednesday");
        break;
        case 4:
        Console.WriteLine("Thursday");
        break;
        case 5:
        Console.WriteLine("Friday");
        break;
        case 6:
        Console.WriteLine("Saturday");
        break;
        case 7:
        Console.WriteLine("Sunday");
        break;
        default:
        Console.WriteLine("One week is only 7 days!");
        break;
    }

}
// weekDay();

//Part 6
//Write a C# Sharp program to retrieve the current date.
//Expected Output:
//The current date is: 12/10/2020

void currentDate(){
    DateTime currentDate = DateTime.Now;

    Console.WriteLine($"The current date is: {currentDate:dd/MM/yyy}");
}
// currentDate();
//Part 7
//Write a C# program to retrieve the current date and time.
//Expected Output:
//The current date and time is: 12/10/2020 10:30:50
void currentDateAndTime(){
    DateTime currentDate = DateTime.Now;

    Console.WriteLine($"The current date and time is: {currentDate}");
}
// currentDateAndTime();

