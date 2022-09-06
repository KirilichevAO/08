// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());

void CreateArray(int[,,] array3D)
{
    int[] tmp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    for (int i = 0; i < tmp.GetLength(0); i++)
    {
        tmp[i] = new Random().Next(10, 100);
        int num = tmp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tmp[i] == tmp[j])
                {
                    tmp[i] = new Random().Next(10, 100);
                    j = 0;
                    num = tmp[i];
                }
                num = tmp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = tmp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i}, {j}, {k}); ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintArray(array3D);