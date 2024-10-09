using GC4_OOP_Ex1_ClawMachine;

Console.WriteLine("Welcome to the claw machine!");
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Cost to play is $1.50. Hit ENTER to PLAY");
    Console.ReadLine();
    ClawMachine.Play();
    Console.WriteLine("Would you like to go again? ENTER Y or N");
    string playAgain = Console.ReadLine().Trim().ToLower();
    if (playAgain == "n")
    {
        runProgram = false;
    }
}
