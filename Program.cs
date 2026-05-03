Console.WriteLine("Hisoblamoqchi bo'lgan qo'shish va ayirish amallarini kiriting.");
Console.Write("(Izoh. Faqat bir xonali sonlar va a+b-c-d... ketma-ketligida): ");

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