Console.WriteLine("Hisoblamoqchi bo'lgan qo'shish va ayirish amallarini kiriting.");
Console.Write("(Izoh. Faqat a+b-c-d... ketma-ketligida kiriting): ");

string action = Console.ReadLine();

int count = 0;
int summa = 0;
string number = "0";
char sign = '+';

while (count != action.Length)
{
    if (action[count] == '+' || action[count] == '-')
    {
        switch (sign)
        {
            case '+':
                {
                    summa += int.Parse(number);
                    break;
                }
            case '-':
                {
                    summa -= int.Parse(number);
                    break;
                }
        }
        number = "";
        sign = action[count];
    }
    else
    {
        number += action[count];
    }

    count ++;
}

switch (sign)
{
    case '+':
        {
            summa += int.Parse(number);
            break;
        }
    case '-':
        {
            summa -= int.Parse(number);
            break;
        }    
}

Console.WriteLine(action + "=" + summa);