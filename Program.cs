string action = Console.ReadLine();

int firstNumber = action[0] - '0';
int secondNumber = action[0] - '0';

switch (action[1])
{
    case '+':
        {
            Console.WriteLine(firstNumber + secondNumber);
            break;
        }
    case '-':
        {
            Console.WriteLine(firstNumber - secondNumber);
            break;
        }
}