// Напишите программу, 
//которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Введите 8 целых чисел");
int[] array = new int[8];
for (int i=0; i<array.Length; i++){
    Console.WriteLine($"Введите элемент массива {i}");
    array[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("{0}", string.Join(",",array));