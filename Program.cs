Console.Write("Hisoblamoqchi bo'lgan matematik amalni kiriting (a + b - c): ");
string action = Console.ReadLine();

int count = 0;
int summa = 0;
char sign = '+';

while(count != action.Length)
{
    if(count % 2 == 0 && sign == '+')
    {
        summa += action[count] - '0';
    }
    else if(count % 2 == 0 && sign == '-')
    {
        summa -= action[count] - '0';
    }
    else
    {
        sign = action[count];
    }

    count ++;
}

Console.WriteLine(action + "=" + summa);