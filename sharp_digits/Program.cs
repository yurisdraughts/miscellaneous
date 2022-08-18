Console.Clear();

int[][,] digits = {
    new int[,] {{1,0},{2,0},   {0,1},{3,1},   {0,2},{3,2},   {0,3},{3,3}, {1,4},{2,4}}, //0
    new int[,] {{3,0},   {2,1},{3,1},   {3,2},   {3,3},   {3,4}}, //1
    new int[,] {{1,0},{2,0},{3,0},   {0,1},{3,1},   {2,2},   {1,3},   {0,4},{1,4},{2,4},{3,4}}, //2
    new int[,] {{0,0},{1,0},{2,0},{3,0},   {3,1},   {0,2},{1,2},{2,2},{3,2},   {3,3},   {0,4},{1,4},{2,4},{3,4}}, //3
    new int[,] {{0,0},{3,0},   {0,1},{3,1},   {0,2},{1,2},{2,2},{3,2},   {3,3},   {3,4}}, //4
    new int[,] {{0,0},{1,0},{2,0},{3,0},   {0,1},   {0,2},{1,2},{2,2},{3,2},   {3,3},   {0,4},{1,4},{2,4},{3,4}}, //5
    new int[,] {{0,0},{1,0},{2,0},{3,0},   {0,1},   {0,2},{1,2},{2,2},{3,2},   {0,3},{3,3},   {0,4},{1,4},{2,4},{3,4}}, //6
    new int[,] {{0,0},{1,0},{2,0},{3,0},   {3,1},   {2,2},   {1,3},   {0,4}}, //7
    new int[,] {{0,0},{1,0},{2,0},{3,0},   {0,1},{3,1},   {0,2},{1,2},{2,2},{3,2},   {0,3},{3,3},   {0,4},{1,4},{2,4},{3,4}}, //8
    new int[,] {{0,0},{1,0},{2,0},{3,0},   {0,1},{3,1},   {0,2},{1,2},{2,2},{3,2},   {3,3},   {0,4},{1,4},{2,4},{3,4}}, //9
};

void WriteDigit(int[,] array, int leftIndent, int topIndent = 1)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.SetCursorPosition(array[i,0] + leftIndent, array[i,1] + topIndent);
        Console.Write("#");
    }
}

int[,] IdentifyDigit(char digit)
{
    return digits[Convert.ToInt32($"{digit}")];
}

void WriteNumber()
{
    Console.Write("Введите натуральное число: ");
    string number = Console.ReadLine();
    int leftIndent = 0;

    for(int i = 0; i < number.Length; i++)
    {
        WriteDigit(IdentifyDigit(number[i]), leftIndent);
        leftIndent += 5;
    }
}

WriteNumber();