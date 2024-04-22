string t;
double a = 0, b = 0, c = 0, d = 0, al = 0, be = 0;
int choice;
Option:
while (true)
{
    Console.WriteLine("Выбирите фигуру:\r\n1.Произвольный четырёхугольник\r\n2.Произвольный треугольник\r\n3.Квадрат\r\n4.Равнобедренный треугольник\r\n5.Прямоугольный треугольник\r\n6.Равносторонний треугольник\r\n7.Выход");
    t = Console.ReadLine();
    if (int.TryParse(t, out int nu))
    {
        if (nu > 0 && nu < 8)
        {
            choice = nu;
            break;
        }
    }
}
switch(choice)
{
    case 1:
        {
            while (true)
            {
                Console.WriteLine("Введите первую сторону произвольного четырёхугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
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
                Console.WriteLine("Введите вторую сторону произвольного четырёхугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
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
                Console.WriteLine("Введите третью сторону произвольного четырёхугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
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
                Console.WriteLine("Введите четвёртую сторону произвольного четырёхугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
                    {
                        d = nu;
                        break;
                    }
                    Console.WriteLine("Некорректное число");
                }
                else { Console.WriteLine("Введённый символ не является числом"); }
            }
            while (true)
            {
                Console.WriteLine("Введите угол произвольного четырёхугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
                    {
                        al = nu;
                        break;
                    }
                    Console.WriteLine("Некорректное число");
                }
                else { Console.WriteLine("Введённый символ не является числом"); }
            }
            while (true)
            {
                Console.WriteLine("Введите противолежащий угол произвольного четырёхугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
                    {
                        be = nu;
                        break;
                    }
                    Console.WriteLine("Некорректное число");
                }
                else { Console.WriteLine("Введённый символ не является числом"); }
            }
            Quadrilateral temp = new Quadrilateral(a, b, c, d, al, be);
            Console.WriteLine($"Площадь данной фигуры = {temp.Area()}");
            break;
        }
    case 2:
        {
            while (true)
            {
                Console.WriteLine("Введите первую сторону произвольного треугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
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
                Console.WriteLine("Введите вторую сторону произвольного треугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
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
                Console.WriteLine("Введите третью сторону произвольного треугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
                    {
                        c = nu;
                        break;
                    }
                    Console.WriteLine("Некорректное число");
                }
                else { Console.WriteLine("Введённый символ не является числом"); }
            }
            Triangle temp = new Triangle(a, b, c);
            Console.WriteLine($"Площадь данной фигуры = {temp.Area()}");
            break;
        }
    case 3:
        {
            while (true)
            {
                Console.WriteLine("Введите сторону квадрата");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
                    {
                        a = nu;
                        break;
                    }
                    Console.WriteLine("Некорректное число");
                }
                else { Console.WriteLine("Введённый символ не является числом"); }
            }
            Square temp = new Square(a);
            Console.WriteLine($"Площадь данной фигуры = {temp.Area()}");
            break;
        }
    case 4:
        {
            while (true)
            {
                Console.WriteLine("Введите сторону равнобедренного треугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
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
                Console.WriteLine("Введите основание равнобедренного треугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
                    {
                        b = nu;
                        break;
                    }
                    Console.WriteLine("Некорректное число");
                }
                else { Console.WriteLine("Введённый символ не является числом"); }
            }
            IsoscelesTriangle temp = new IsoscelesTriangle(a, b);
            Console.WriteLine($"Площадь данной фигуры = {temp.Area()}");
            break;
        }
    case 5:
        {
            while (true)
            {
                Console.WriteLine("Введите первую сторону прямоугольного треугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
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
                Console.WriteLine("Введите вторую сторону прямоугольного треугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
                    {
                        b = nu;
                        break;
                    }
                    Console.WriteLine("Некорректное число");
                }
                else { Console.WriteLine("Введённый символ не является числом"); }
            }
            RightTriangle temp = new RightTriangle(a, b);
            Console.WriteLine($"Площадь данной фигуры = {temp.Area()}");
            break;
        }
    case 6:
        {
            while (true)
            {
                Console.WriteLine("Введите сторону треугольника");
                string n = Console.ReadLine();
                if (int.TryParse(n, out int nu))
                {
                    if (nu > 0)
                    {
                        a = nu;
                        break;
                    }
                    Console.WriteLine("Некорректное число");
                }
                else { Console.WriteLine("Введённый символ не является числом"); }
            }
            EquilateralTriangle temp = new EquilateralTriangle(a);
            Console.WriteLine($"Площадь данной фигуры = {temp.Area()}");
            break;
        }
    case 7: { Environment.Exit(0); break; }
}
goto Option;
abstract class Figure
{
    public abstract double Area();
}
class Quadrilateral : Figure
{
    public double a { get; }
    public double b { get; }
    public double c { get; }
    public double d { get; }
    public double An1 { get; }
    public double An2 { get; }
    public Quadrilateral(double side1, double side2, double side3, double side4, double angle1, double angle2)
    {
        a = side1;
        b = side2;
        c = side3;
        d = side4;
        An1 = angle1 * Math.PI / 180;
        An2 = angle2 * Math.PI / 180;
    }
    public override double Area()
    {
        double p = (a + b + c + d) / 2;
        return Math.Sqrt((p-a)*(p-b)*(p-c)*(p-d) - a*b*c*d * Math.Pow(Math.Cos((An1 + An2) / 2), 2));
    }
}
class Triangle : Figure
{
    public double a { get; }
    public double b { get; }
    public double c { get; }
    public Triangle(double side1, double side2, double side3)
    {
        a = side1;
        b = side2;
        c = side3;
    }
    public override double Area()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
class Square : Quadrilateral
{
    public Square(double a) : base(a, a, a, a, 1, 1) { }
    public override double Area()
    {
        return a * a;
    }
}
class IsoscelesTriangle : Triangle
{
    public IsoscelesTriangle(double a, double b) : base(a, a, b) { }
}
class RightTriangle : Triangle
{
    public RightTriangle(double a, double b) : base(a, b, 1) { }
    public override double Area()
    {
        return a * b / 2;
    }
}
class EquilateralTriangle : Triangle
{
    public EquilateralTriangle(double a) : base(a, a, a) { }
}