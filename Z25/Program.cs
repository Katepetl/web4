// See https://aka.ms/new-console-template for more Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
int power(){
Console.WriteLine("Vvedite chislo");
int A=int.Parse(Console.ReadLine())!;
Console.WriteLine("Vvedite stepen");
int B=int.Parse(Console.ReadLine())!;
int A_B=1;
for(int i=0; i<B; i++){
    A_B*=A;
}
Console.WriteLine("{0}^{1}={2}",A,B,A_B);
Console.ReadKey();
return 0;
}
power();