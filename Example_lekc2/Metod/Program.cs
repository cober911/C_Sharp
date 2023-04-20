int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 42;
int b1 = 37;
int c1 = 93;
int a2 = 57;
int b2 = 422;
int c2 = 59;
int a3 = 27;
int b3 = 63;
int c3 = 90;

int Max1 = Max(a1, b1, c1);
int Max2 = Max(a2, b2, c2);
int Max3 = Max(a3, b3, c3);
int max = Max(Max1, Max2, Max3);
Console.WriteLine(max);

