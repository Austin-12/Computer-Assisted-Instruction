using System;

class CAI
{
    private enum Status { Correct, Wrong }; //enum to represent if the quesitons are correct or not./
    static void Main(String[] args)
    {

        //ask the question continuesly
        Console.WriteLine("Welcome to the multiplication learning program");
        while(true)
        {
            askQuestion();
        }
}

    //method used to generate each new question. called once the app begins execution and each time the user answers the question correctly
    static int randomNum()
    {
        Random random = new Random(); //random generate
        int num = random.Next(1, 10);
        return num;
    }

    //method to ask the math question
    static void askQuestion()
    {
        int num1 = randomNum(); //1st operand
        int num2 = randomNum(); //2nd operand
        int answer = num1 * num2; //the correct answer
        Status question = Status.Wrong; //question can be wrong or correct

        while (question == Status.Wrong) //While the question is wrong
        {
            Console.WriteLine($"How much is {num1} x {num2}?");
            int guess = int.Parse(Console.ReadLine()); //get answer from the user

            if (answer == guess) //if the answer is correct 
            {
                Console.WriteLine("very good!");
                question = Status.Correct;
            }
            else if (answer != guess) //if the answer is wrong
            {
                Console.WriteLine("No. please try again");
                question = Status.Wrong;
            }
        }
    }
}