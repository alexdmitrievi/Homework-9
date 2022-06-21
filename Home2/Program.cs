// Найти сумму элементов от M до N, N и M заданы

int f(int m, int n){
    int sum = 0;
    for (int i = m; i <= n; i++){
        sum = sum + i;
    }
    return sum;
}






Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()?? "");
Console.WriteLine(f(m,n));




