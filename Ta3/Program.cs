

 Console.Clear();
 int[] CreateArr(int number)
{
  Console.Write("Введите первое число: ");
  int start = Convert.ToInt32(Console.ReadLine());
  Console.Write("Выедите второе число: ");
  int stop = Convert.ToInt32(Console.ReadLine());

  int[] Arr = new int[number];
  for (int i = 0; i < Arr.Length; i++)
  {
    Arr[i] = new Random().Next(start, stop + 1);
  }
  return Arr;
}

int[] ReversArr(int[] Array)
{
  for (int i = 0, j = Array.Length - 1; i < Array.Length / 2; i++, j--)
  {
    int tmp = Array[j];
    Array[j] = Array[i];
    Array[i] = tmp;
  }
  return Array;
}

int[] res = CreateArr(5);
Console.WriteLine(String.Join(" ", res));
Console.WriteLine(String.Join(" ", ReversArr(res)));