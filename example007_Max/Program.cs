int a1 = 45, b1 = 17, c1 = 56,
    a2 = 38, b2 = 566, c2 = 47,
    a3 = 68, b3 = 24, c3 = 32;
    int Max(int arg1, int arg2, int arg3)
    { 
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }
    //int max1 = Max(a1,b1,c1);
    //int max2 = Max(a2,b2,c2);
    //int max3 = Max(a3,b3,c3);
    //int F_max = Max(max1,max2,max3);
     int F_max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
    Console.WriteLine(F_max);