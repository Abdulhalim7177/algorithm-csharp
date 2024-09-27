public static int FindMax(int[] array)
{
    int max = array[0];
    foreach (var num in array)
    {
        if (num > max)
            max = num;
    }
    return max;
}
