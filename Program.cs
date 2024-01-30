double totalscore = 0.0;
int counter = 0;
string answer;

do
{
    Console.WriteLine("Please enter score: ");
    double score = Convert.ToDouble(Console.ReadLine());
    counter++;
    totalscore = totalscore + score;

    Console.WriteLine("Do you have another score to enter? ");
    answer = Console.ReadLine();
}
while (answer == "yes");

double avescore = totalscore / counter;
Console.WriteLine("the number of scores entered: {0}\n", counter);
Console.WriteLine("the average score is {0:F2}\n", avescore);
