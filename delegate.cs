using System;


class delegateEg
{
    delegate void MyDelegate(int x, int y);

    static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    static void Main()
    {
        MyDelegate operation1 = new MyDelegate(Add);
        MyDelegate operation2 = new MyDelegate(Subtract);

        operation1(10, 5);
        operation2(5, 2);
    }
}