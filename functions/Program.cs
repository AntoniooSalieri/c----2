int x = 10, y = 9;
int summ(int a, int b){
    int result = a + b;
    return result;
}

void Printer(int count){
    while (count > 0){
        Console.Write(count);
        count--;
    }
}

Printer(y);
Console.WriteLine();
Console.WriteLine(summ(x, y));