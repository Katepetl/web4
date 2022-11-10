// See https://aka.ms/new-console-template for more information Напишите программу, которая 
//принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
//452 -> 11
void sum(){
Console.WriteLine("Vvedite chislo");
int a= int.Parse (Console.ReadLine()!);
int sum=0;
while (a>0){
    sum=sum+a%10;
    a=a/10;
}
Console.WriteLine(sum);
}
sum();