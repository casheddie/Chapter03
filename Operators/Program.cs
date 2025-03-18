#region Exploring unary operators
WriteLine("Exploring unary operators");
WriteLine("-------------------------");
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");
int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");
WriteLine();
#endregion

#region Exploring binary arithmetic operators
WriteLine("Exploring binary arithmetic operators");
WriteLine("-------------------------------------");
int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

WriteLine();
#endregion

#region Exploring logical operators

bool p = true;
bool q = false;
WriteLine(($"AND   | p     | q     "));
WriteLine($"p     | {p & p,-5} | {p & q,-5}");
WriteLine($"q     | {q & p,-5} | {q & q,-5}");
WriteLine();
WriteLine(($"OR    | p     | q     "));
WriteLine($"p     | {p | p,-5} | {p | q,-5}");
WriteLine($"q     | {q | p,-5} | {q | q,-5}");
WriteLine();
WriteLine(($"XOR   | p     | q     "));
WriteLine($"p     | {p ^ p,-5} | {p ^ q,-5}");
WriteLine($"q     | {q ^ p,-5} | {q ^ q,-5}");
WriteLine();

#endregion

#region Exploring conditional logical operators

static bool DoStuff()
{
    WriteLine("I am doing some stuff");
    return true;
}
WriteLine();
WriteLine($"p & DoStuff = {p & DoStuff()}");
WriteLine($"q & DoStuff = {q & DoStuff()}");
WriteLine();
WriteLine($"p && DoStuff = {p && DoStuff()}");
WriteLine($"q && DoStuff = {q && DoStuff()}");

WriteLine();
#endregion

#region Exploring bitwise and binary shift operators

int x = 10;
int y = 6;

WriteLine($"Expression     | Decimal | Binary |");
WriteLine($"-----------------------------------");
WriteLine($"x              | {x,7} | {x:B8}");
WriteLine($"y              | {y,7} | {y:B8}");
WriteLine($"x & y          | {x & y,7} | {x & y:B8}");
WriteLine($"x | y          | {x | y,7} | {x | y:B8}");
WriteLine($"x ^ y          | {x ^ y,7} | {x ^ y:B8}");

// Left-Shift x by three bit column.
WriteLine($"x << 3          | {x << 3,7} | {x << 3:B8}");

// Multiply x by 8.
WriteLine($"x * 8           | {x * 8,7} | {x * 8:B8}");

// Right-shift y by one bit column.
WriteLine($"y >> 1          |  {y >> 1,7} | {y >> 1:B8}");

#endregion