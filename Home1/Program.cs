/*Показать натуральные числа от M до N, N и M заданы
Найти сумму элементов от M до N, N и M заданы*/

void f(int m, int n){
    for (int i = m; i <= n; i++){
        Console.WriteLine("{i} ");
    }
}






Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()?? "");
f(m,n);


