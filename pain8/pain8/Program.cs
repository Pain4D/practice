int a, b, c, d, choice;
while (true)
{
    Console.WriteLine("Введите числитель первого числа: ");
    string t = Console.ReadLine();
    if (int.TryParse(t, out int nu))
    {
        if (nu != 0)
        {
            a = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите знаменатель первого числа: ");
    string t = Console.ReadLine();
    if (int.TryParse(t, out int nu))
    {
        if (nu != 0)
        {
            b = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите числитель второго числа: ");
    string t = Console.ReadLine();
    if (int.TryParse(t, out int nu))
    {
        if (nu != 0)
        {
            c = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите знаменатель второго числа: ");
    string t = Console.ReadLine();
    if (int.TryParse(t, out int nu))
    {
        if (nu != 0)
        {
            d = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
Ratio first = new Ratio(a, b);
Ratio second = new Ratio(c, d);
Option:
while (true)
{
    Console.WriteLine("Выбирите операцию:\r\n1.Сложение\r\n2.Вычитание\r\n3.Умножение\r\n4.Деление\r\n5.Сравнение (выводит наибольшее число)\r\n6.Выход");
    string t = Console.ReadLine();
    if (int.TryParse(t, out int nu))
    {
        if (nu > 0 && nu < 7)
        {
            choice = nu;
            break;
        }
    }
}
switch (choice)
{
    case 1: Console.WriteLine($"{first} + {second} = {first.Add(second)}"); break;
    case 2: Console.WriteLine($"{first} - {second} = {first.Sub(second)}"); break;
    case 3: Console.WriteLine($"{first} * {second} = {first.Mul(second)}"); break;
    case 4: Console.WriteLine($"{first} / {second} = {first.Div(second)}"); break;
    case 5: Console.WriteLine($"Наибольшее число - {first.Com(second)}"); break;
    case 6: Environment.Exit(0); break;
}
goto Option;
class Ratio
{
    private int a;
    private int b;
    private int p(int p, int g)
    {
        while (g != 0)
        {
            var temp = g;
            g = p % g;
            p = temp;
        }
        return p;
    }
    public Ratio Add(Ratio temp)
    {
        int res_a = 0;
        int res_b = 0;
        if (b == temp.b)
        {
            res_a = a + temp.a;
            res_b = b;
        }
        if (b > temp.b && b % temp.b == 0)
        {
            res_a = a + temp.a * b / temp.b;
            res_b = b;
        }
        if (b < temp.b && temp.b % b == 0)
        {
            res_a = a * temp.b / b + temp.a;
            res_b = temp.b;
        }
        if (b % temp.b != 0)
        {
            res_a = a * temp.b + temp.a * b;
            res_b = b * temp.b;
        }
        return new Ratio(res_a, res_b);
    }
    public Ratio Sub(Ratio temp)
    {
        int res_a = 0;
        int res_b = 0;
        if (b == temp.b)
        {
            res_a = a - temp.a;
            res_b = b;
        }
        if (b > temp.b && b % temp.b == 0)
        {
            res_a = a - temp.a * b / temp.b;
            res_b = b;
        }
        if (b < temp.b && temp.b % b == 0)
        {
            res_a = a - temp.b / b + temp.a;
            res_b = temp.b;
        }
        if (b % temp.b != 0)
        {
            res_a = a * temp.b - temp.a * b;
            res_b = b * temp.b;
        }
        return new Ratio(res_a, res_b);
    }
    public Ratio Mul(Ratio temp)
    {
        int res_a = a * temp.a;
        int res_b = b * temp.b;
        return new Ratio(res_a, res_b);
    }
    public Ratio Div(Ratio temp)
    {
        int res_a = a * temp.b;
        int res_b = b * temp.a;
        return new Ratio(res_a, res_b);
    }
    public Ratio Com(Ratio temp)
    {
        int res_a = 0;
        int res_b = 0;
        int[] c = new int[2];
        if (b == temp.b)
        {
            c[0] = a; c[1] = temp.a;
            res_a = c.Max();
            res_b = b;
        }
        if (b > temp.b && b % temp.b == 0)
        {
            c[0] = a; c[1] = temp.a * b / temp.b;
            res_a = c.Max();
            res_b = b;
        }
        if (b < temp.b && temp.b % b == 0)
        {
            c[0] = a * temp.b / b; c[1] = temp.a;
            res_a = c.Max();
            res_b = temp.b;
        }
        if (b % temp.b != 0)
        {
            c[0] = a * temp.b; c[1] = temp.a * b;
            res_a = c.Max();
            res_b = b * temp.b;
        }
        return new Ratio(res_a, res_b);
    }
    public Ratio(int A, int B) { a = A / p(A, B); b = B / p(A, B); }
    public override string ToString()
    {
        string res = "";
        if (b != 1)
        {
            res = $"{a}/{b}";
        }
        if (b == 1)
        {
            res = $"{a}";
        }
        return res;
    }
}