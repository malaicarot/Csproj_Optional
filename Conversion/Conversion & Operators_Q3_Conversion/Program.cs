// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.


//Part 1

// Create a program to get the users height in meters and weight in kilograms and calculate the BMI of the user.
// The formula to calculate the BMI is weight / (height * height).
// The program should then display the BMI of the user and display the following message based on the BMI:
// BMI < 18.5: Underweight
// 18.5 <= BMI < 25: Normal
// 25 <= BMI < 30: Overweight
// BMI >= 30: Obese

//Test Data
//Enter your height in meters: 1.75
//Enter your weight in kilograms: 68
//Your BMI is 22.2
//You are Normal

void CalculateBMI(){
    Console.Write("Enter your height in meters(m): ");
    string input_1 = Console.ReadLine();
    
    Console.Write("Enter your weight in kilograms(kg): ");
    string input_2 = Console.ReadLine();

    float height = float.Parse(input_1);
    float weight = float.Parse(input_2);

    float BMI = weight / (height * height);

    Console.WriteLine($"Your BMI is: {BMI}");

    if(BMI >= 18.5 && BMI < 25){
        Console.WriteLine("You are Normal!");

    }else if(BMI >= 25 && BMI < 30){
        Console.WriteLine("You are Overweight!");

    }else if(BMI >= 30){
        Console.WriteLine("You are Obese!");
    }else{
        Console.WriteLine("You are Underweight!");
    }

}
// CalculateBMI();


//Part 2

// Modify the program to get the users height in feet and inches and weight in pounds and calculate the BMI of the user.
// The formula to calculate the BMI is (weight * 703) / (height * height).
// The program should then display the BMI of the user and display the following message based on the BMI:
// BMI < 18.5: Underweight
// 18.5 <= BMI < 25: Normal
// 25 <= BMI < 30: Overweight
// BMI >= 30: Obese

//Test Data
//Enter your height in feet: 5
//Enter your height in inches: 9
//Enter your weight in pounds: 150
//Your BMI is 22.1
//You are Normal

void CalculateBMI_2(){
    Console.Write("Enter your height in feet(ft): ");
    string input_1 = Console.ReadLine();

    Console.Write("Enter your height in inches(in): ");
    string input_2 = Console.ReadLine();
    
    Console.Write("Enter your weight in pounds(Lbs): ");
    string input_3 = Console.ReadLine();

    float height_ft = float.Parse(input_1);
    float height_in = float.Parse(input_2);
    float weight = float.Parse(input_3);

    float total_Height = (height_ft * 12 + height_in);



    float BMI = (weight * 703) / (total_Height * total_Height);

    Console.WriteLine($"Your BMI is: {Math.Round(BMI, 1)}");

    if(BMI >= 18.5 && BMI < 25){
        Console.WriteLine("You are Normal!");

    }else if(BMI >= 25 && BMI < 30){
        Console.WriteLine("You are Overweight!");

    }else if(BMI >= 30){
        Console.WriteLine("You are Obese!");
    }else{
        Console.WriteLine("You are Underweight!");
    }

}
// CalculateBMI_2();



//Part 3

//In a game, the player's score is stored as an integer, but you need to display it with one decimal place. Convert the player's score from an integer to a double and print the result.

//Test Data
//Player's Score: 100
//Player's Score with one decimal place: 100.0

void playerScore(){
    Console.Write("Enter player's score: ");
    string input = Console.ReadLine();


    int scoreInt = int.Parse(input);

    double scoreDouble = scoreInt * 1.0;

    Console.WriteLine($"Player's Score with one decimal place: {scoreDouble:F1}");

}
// playerScore();

//Part 4
//In a game, the player's health is stored as a double, but you need to display it as a percentage (integer value). Convert the player's health from a double to an integer representing a percentage and print the result.

//Test Data
//Player's Health: 0.75
//Player's Health as a percentage: 75%

void playerHealth(){

    double playerHealth = 0.75d;

    int playerHealthPercen = (int)(playerHealth * 100);

    Console.WriteLine($"Player's Health: {playerHealth}");
    Console.WriteLine($"Player's Health as a percentage: {playerHealthPercen}%");
}
// playerHealth();

//Part 5

//In a game, the player's coins are stored as a double, but you need to display them as an integer (rounded down). Convert the player's coins from a double to an integer and print the result.

//Test Data
//Player's Coins: 123.45
//Player's Coins as an integer: 123

void playerCoin(){
    double coin = 123.45;

    int coinReal = (int) coin;


    Console.WriteLine($"Player's Coins as an integer: {coinReal}");
}
// playerCoin();



//Part 6

//In a game, the player's progress is stored as a boolean (true for completed, false for incomplete), but you need to display it as a string ("Completed" or "Incomplete").
//Convert the player's progress from a boolean to a string representing the status and print the result.
//Hint: Use a conditional statement to check the boolean value and return the appropriate string. e.g ., if (progress) { return "Completed"; } else { return "Incomplete"; }

//Test Data
//Player's Progress: true
//Player's Progress as a string: Completed

string playerProgress(){

    bool isCompleted = true;

    if(isCompleted){
        return "Completed";

    }else{
       return "Incomplete";
    }
}

string status = playerProgress();
Console.WriteLine(status);


