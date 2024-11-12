int a1 = 9,
    a2 = 52,
    a3 = 43,
    b1 = 31, 
    b2 = 14,
    b3 = 21,
    c1 = 34,
    c2 = 46,
    c3 = 19;

int max = 0,
    maxA = 0,
    maxB = 0,
    maxC = 0;

int FMax(int x, int y, int z){
    if (max < x) max = x;
    if (max < y) max = y;
    if (max < z) max = z; 
    return max;
}

maxA = FMax(a1, a2, a3);
maxB = FMax(b1, b2, b3);
maxC = FMax(c1, c2, c3);

Console.WriteLine((FMax(maxA, maxB, maxC)));