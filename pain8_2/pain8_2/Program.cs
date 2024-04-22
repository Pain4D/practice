int n1, n2;
Coord f = new Coord();
while (true)
{
    Console.WriteLine("Введите градусы широты первых координат");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu >= 0)
        {
            f.deglat = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите минуты широты первых координат");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu >= 0)
        {
            f.minlat = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите полушарие широты первых координат (N/S)");
    string n = Console.ReadLine();
    char t = Convert.ToChar(n);
    if (t == 'N' || t == 'S') { f.dirlong = t; break; }
    Console.WriteLine("Введены некорректные данные");
}
while (true)
{
    Console.WriteLine("Введите градусы долготы первых координат");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu >= 0)
        {
            f.deglong = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите минуты долготы первых координат");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu >= 0)
        {
            f.minlong = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите полушарие долготы первых координат (E/W)");
    string n = Console.ReadLine();
    char t = Convert.ToChar(n);
    if (t == 'E' || t == 'W') { f.dirlong = t; break; }
    Console.WriteLine("Введены некорректные данные");
}
while (true)
{
    Console.WriteLine("Введите номер корабля, находящегося по данным координатам");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu > 0)
        {
            n1 = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
Coord s = new Coord();
while (true)
{
    Console.WriteLine("Введите градусы широты вторых координат");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu >= 0)
        {
            s.deglat = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите минуты широты вторых координат");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu >= 0)
        {
            s.minlat = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите полушарие широты вторых координат (N/S)");
    string n = Console.ReadLine();
    char t = Convert.ToChar(n);
    if (t == 'N' || t == 'S') { f.dirlong = t; break; }
    Console.WriteLine("Введены некорректные данные");
}
while (true)
{
    Console.WriteLine("Введите градусы долготы вторых координат");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu >= 0)
        {
            s.deglong = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите минуты долготы вторых координат");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu >= 0)
        {
            s.minlong = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
while (true)
{
    Console.WriteLine("Введите полушарие долготы вторых координат (E/W)");
    string n = Console.ReadLine();
    char t = Convert.ToChar(n);
    if (t == 'E' || t == 'W') { f.dirlong = t; break; }
    Console.WriteLine("Введены некорректные данные");
}
while (true)
{
    Console.WriteLine("Введите номер корабля, находящегося по данным координатам");
    string n = Console.ReadLine();
    if (int.TryParse(n, out int nu))
    {
        if (nu > 0)
        {
            n2 = nu;
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    else { Console.WriteLine("Введённый символ не является числом"); }
}
Ship first = new Ship(f, n1);
Ship second = new Ship(s, n2);
Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine($"Дистанция между кораблём №{first.num} и кораблём №{second.num}:");
first.Dist(second);
class Ship
{
    Coord coord;
    public int num;
    public Ship(Coord coord, int num)
    {
        this.coord = coord;
        this.num = num;
    }
    public Ship Dist(Ship second)
    {
        double f_lat = Convert.ToDouble($"{coord.deglat},{coord.minlat}");
        double s_lat = Convert.ToDouble($"{second.coord.deglat},{second.coord.minlat}");
        double f_long = Convert.ToDouble($"{coord.deglong},{coord.minlong}");
        double s_long = Convert.ToDouble($"{second.coord.deglong},{second.coord.minlong}");
        double d = 0;
        if (coord.dirlat == second.coord.dirlat && coord.dirlong == second.coord.dirlong)
        {
            d = Math.Acos(Math.Sin(f_lat * 0.0174533) * Math.Sin(s_lat * 0.0174533) + Math.Cos(f_lat * 0.0174533) * Math.Cos(s_lat * 0.0174533) * Math.Cos((f_long - s_long) * 0.0174533));
        }
        if (coord.dirlat != second.coord.dirlat && coord.dirlong != second.coord.dirlong)
        {
            d = Math.Acos(Math.Sin(f_lat * -0.0174533) * Math.Sin(s_lat * 0.0174533) + Math.Cos(f_lat * -0.0174533) * Math.Cos(s_lat * 0.0174533) * Math.Cos((f_long + s_long) * 0.0174533));
        }
        if (coord.dirlat == second.coord.dirlat && coord.dirlong != second.coord.dirlong)
        {
            d = Math.Acos(Math.Sin(f_lat * 0.0174533) * Math.Sin(s_lat * 0.0174533) + Math.Cos(f_lat * 0.0174533) * Math.Cos(s_lat * 0.0174533) * Math.Cos((f_long + s_long) * 0.0174533));
        }
        if (coord.dirlat != second.coord.dirlat && coord.dirlong == second.coord.dirlong)
        {
            d = Math.Acos(Math.Sin(f_lat * -0.0174533) * Math.Sin(s_lat * 0.0174533) + Math.Cos(f_lat * -0.0174533) * Math.Cos(s_lat * 0.0174533) * Math.Cos((f_long - s_long) * 0.0174533));
        }
        int l = Convert.ToInt32(Math.Round(d * 6371));
        Console.WriteLine($"{l} км");
        return null;
    }
    public Ship Cord()
    {
        Console.WriteLine(coord);
        return null;
    }
    public Ship Num()
    {
        Console.WriteLine(num);
        return null;
    }
    public override string ToString()
    {
        return $"Корабль под номером {num} находится по координатам {coord}";
    }
}
struct Coord
{
    public int deglat;
    public float minlat;
    public char dirlat;
    public int deglong;
    public float minlong;
    public char dirlong;
    public override string ToString()
    {
        return $"{deglat}°{minlat}′{dirlat}.lat., {deglong}°{minlong}′{dirlong}.long.";
    }
}
