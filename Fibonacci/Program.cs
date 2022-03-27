// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ",");

    }
    Console.Write(collect[collect.Length - 1] + "]");
}
int[] Fibo(int N)
{
    int[] K = new int[N];
    K[0] = 0;
    K[1] = 1;
    for (int i = 2; i < N; i++)
    {
        K[i] = K[i - 1] + K[i - 2];
    }
    return K;
}
int N = Promt("Введите число => ");
int[] K = Fibo(N);
PrintArray(K);