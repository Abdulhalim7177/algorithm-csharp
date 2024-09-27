public static int LCM(int a, int b)
{
    return Math.Abs(a * b) / GCD(a, b);
}
