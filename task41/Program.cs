//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int kolPol = 0;
int M = 5;
int[] GetArray (int size, int min, int max)
{
   int [] res = new int [size];
   for (int i = 0; i < size; i++)
   {
      Console.WriteLine("Введите " +(i+1) +"-е число");
      res[i] = int.Parse(Console.ReadLine());
   }
   return res;
}

int[] array = GetArray (M, -100, 100);
Console.WriteLine(String.Join(", ", array));

for (int i = 0; i < M; i++)
{
   if (array[i] > 0)
   kolPol++;
}
Console.WriteLine("Всего положительных чисел - " +kolPol);
