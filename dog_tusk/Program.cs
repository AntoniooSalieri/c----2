using System.Buffers;

int speed0 = 10,
    speed1 = 3;
int x = 0,          //позиция 1ого
    y = 1000;       //позиция 2ого
int distance = y;   //расстояние от 1 до 2
int time = 0;       //время до встерчи
int count = 0;      //кол-во встерч

while (distance > 10){
    distance = y - x;
    time = distance / (speed0 + speed1);
    x = x + time * speed1;
    y = y - time * speed1;
    count++;
}

Console.WriteLine(count);