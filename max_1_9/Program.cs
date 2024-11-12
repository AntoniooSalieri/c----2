int[] array = { 9, 52, 34, 31, 14, 21, 34, 46, 19 };

int answer = 0;

int FMax(int x, int y, int max){
    if (max < x) max = x;
    if (max < y) max = y;
    return max;
}

for (int i = 0; i < 8; i++)
{
    answer = FMax(array[i], array[i+1], answer);
}

Console.WriteLine(answer);