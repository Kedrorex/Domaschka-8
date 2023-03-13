// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] NextNumber(int row, int column, int pow)
{
    int[,,] sklad = new int[row, column, pow];
    Random rnd = new Random();
    bool fear;

    for (int i = 0; i < sklad.GetLength(0); i++)
    {
        for (int j = 0; j < sklad.GetLength(1); j++)
        {
            for (int k = 0; k < sklad.GetLength(2);)
            {

                fear = true;
                int random = rnd.Next(10, 100);

                for (int l = 0; l < sklad.GetLength(0); l++)
                {
                    for (int p = 0; p < sklad.GetLength(1); p++)
                    {
                        for (int m = 0; m < sklad.GetLength(2); m++)
                        {
                            if (random == sklad[l, p, m]) // Проверка на уникальность
                            {
                                fear = false;
                                break;
                            }

                        }

                    }
                }

                if (fear)
                {
                    sklad[i, j, k] = random;
                    k++;
                }

                
            }
        }
    }
    return sklad;
}



void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write(matrix[i, j, k] + $" ({i}, {j}, {k}) " );
            }
            Console.WriteLine();
        }

    }
}

int[,,] matrix = NextNumber(2, 2, 2);
PrintMatrix(matrix);

// matrix = NextNumber(matrix);
// PrintMatrix(matrix);