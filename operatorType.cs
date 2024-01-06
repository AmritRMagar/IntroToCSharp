using System;

class OperatorExample
{
    static void Main()
    {
        // Arithmetic Operators
        int a = 10;
        int b = 5;
        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        int quotient = a / b;
        int remainder = a % b;

        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
        Console.WriteLine();

        // Relational Operators
        int x = 10;
        int y = 5;
        bool isEqual = x == y;
        bool isNotEqual = x != y;
        bool greaterThan = x > y;
        bool lessThan = x < y;
        bool greaterOrEqual = x >= y;
        bool lessOrEqual = x <= y;

        Console.WriteLine("Relational Operators:");
        Console.WriteLine($"Is Equal: {isEqual}");
        Console.WriteLine($"Is Not Equal: {isNotEqual}");
        Console.WriteLine($"Greater Than: {greaterThan}");
        Console.WriteLine($"Less Than: {lessThan}");
        Console.WriteLine($"Greater Or Equal: {greaterOrEqual}");
        Console.WriteLine($"Less Or Equal: {lessOrEqual}");
        Console.WriteLine();

        // Logical Operators
        bool p = true;
        bool q = false;
        bool logicalAnd = p && q;
        bool logicalOr = p || q;
        bool logicalNot = !p;

        Console.WriteLine("Logical Operators:");
        Console.WriteLine($"Logical AND: {logicalAnd}");
        Console.WriteLine($"Logical OR: {logicalOr}");
        Console.WriteLine($"Logical NOT: {logicalNot}");
        Console.WriteLine();

        // Assignment Operators
        int c = 10;
        c += 5;
        c -= 3;
        c *= 2;
        c /= 4;
        c %= 3;

        Console.WriteLine("Assignment Operators:");
        Console.WriteLine($"Final value of c: {c}");
        Console.WriteLine();

        // Increment and Decrement Operators
        int num = 10;
        num++;
        num--;

        Console.WriteLine("Increment and Decrement Operators:");
        Console.WriteLine($"Incremented num: {num}");
        Console.WriteLine();

        // Conditional Operator
        int value1 = 5;
        int value2 = 10;
        int max = (value1 > value2) ? value1 : value2;

        Console.WriteLine("Conditional Operator:");
        Console.WriteLine($"Max value: {max}");
        Console.WriteLine();

        // Bitwise Operators
        int bitwiseAnd = 3 & 6;
        int bitwiseOr = 3 | 6;
        int bitwiseXor = 3 ^ 6;
        int bitwiseComplement = ~3;
        int leftShift = 3 << 1;
        int rightShift = 3 >> 1;

        Console.WriteLine("Bitwise Operators:");
        Console.WriteLine($"Bitwise AND: {bitwiseAnd}");
        Console.WriteLine($"Bitwise OR: {bitwiseOr}");
        Console.WriteLine($"Bitwise XOR: {bitwiseXor}");
        Console.WriteLine($"Bitwise Complement: {bitwiseComplement}");
        Console.WriteLine($"Left Shift: {leftShift}");
        Console.WriteLine($"Right Shift: {rightShift}");
    }
}