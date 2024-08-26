// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.





//Part 1
//Write a C# program that concatenates two strings (player's first and last name) and then outputs the result.
//Hint: You can assign a string to a variable using the = operator.
//Hint: You can use the + operator to concatenate two strings.
//Hint: You can use the Console.WriteLine() method to output the result.

string firstName = "Pham";
string lastName = "Anh Khoa";

void ConcatTwoString(string _firstName, string _lastName){

    Console.WriteLine(_firstName + " " + _lastName);

}
// ConcatTwoString(firstName, lastName);

//Part 2
//Modify the program so that it gets the two strings from the user(for username).
//Hint: You can use the Console.ReadLine() method to get a string from the user.
//Hint: You can use the Console.WriteLine() method to prompt the user for input.
//Hint: You can use the Console.WriteLine() method to output the result.

void getName(){
    Console.Write("Enter your class: ");
    string input1 = Console.ReadLine();

    Console.Write("Enter your name: ");
    string input2 = Console.ReadLine();


    Console.WriteLine($"Hello {input1} {input2}!");
}
// getName();

//Part 3
//Modify the program so that it concatenates three strings instead of two (clan name).
//Hint: You can use the + operator to concatenate three strings.
//Hint: You can use the Console.WriteLine() method to output the result.
void ConcatThreeString(string clanName_1, string clanName_2, string clanName_3){

    string clanName = clanName_1 + " " + clanName_2 + " " + clanName_3;

    Console.WriteLine($"Clan name is: {clanName}");
}

string name_1 = "Kimetsu";
string name_2 = "No";
string name_3 = "Yaiba";
// ConcatThreeString(name_1, name_2, name_3);

//Part 4
//Modify the program to concatenate a string and an integer(incase,player name had numebrs).
//Hint: You can use the + operator to concatenate a string and an integer.
//Hint: You can use the Console.ReadLine() method to get an integer from the user.
//Hint: You can use the int.Parse() method to convert a string to an integer.
//Hint: You can use the Console.WriteLine() method to output the result.


void ConcatStringAndNumber(){

    Console.Write("Enter your name: ");
    string input1 = Console.ReadLine();
    Console.Write("Enter your tag number: ");
    string input2 = Console.ReadLine();

    int birth = int.Parse(input2);

    string inGame = input1 + "_" + birth;

    Console.WriteLine($"In game name is: {inGame}");
}

// ConcatStringAndNumber();


