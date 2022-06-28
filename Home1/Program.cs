/*Показать натуральные числа от M до N, N и M заданы
Найти сумму элементов от M до N, N и M заданы*/

int f(int n, int m){
    if (n == m ){
        //Console.WriteLine(m);
        return n;
    }
    Console.WriteLine(f(n-1,m));
    return n;
}






Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()?? "");
f(n,m);


