// Найти сумму элементов от M до N, N и M заданы

int f(int m, int n, int sum){
    if (m == n){
        return sum + m;
    }
    return f(m+1,n,sum+m);
}






Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()?? "");
int sum = 0;
Console.WriteLine(f(m,n,sum));



