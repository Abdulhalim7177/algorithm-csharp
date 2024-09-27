public static int FindMin(int[] array)
{
    int min = array[0];
    foreach (var num in array)
    {
        if (num < min)
            min = num;
    }
    return min;
}
