
int RefDemo(ref int x, ref int y) {
    x++;
    y--;
    return x;
}

int a = 1, b = 10;
int c = RefDemo(ref a, ref b);


Console.WriteLine($"a {a} b {b} c {c}");