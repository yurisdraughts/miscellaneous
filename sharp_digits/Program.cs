Console.Clear();

bool[][,] digits = {
    new bool[5,4] {{false,true,true,false},{true,false,false,true},{true,false,false,true},{true,false,false,true},{false,true,true,false}}, //0
    new bool[5,4] {{false,false,false,true},{false,false,true,true},{false,false,false,true},{false,false,false,true},{false,false,false,true}}, //1
    new bool[5,4] {{false,true,true,true},{true,false,false,true},{false,false,true,false},{false,true,false,false},{true,true,true,true}}, //2
    new bool[5,4] {{true,true,true,true},{false,false,false,true},{true,true,true,true},{false,false,false,true},{true,true,true,true}}, //3
    new bool[5,4] {{true,false,false,true},{true,false,false,true},{true,true,true,true},{false,false,false,true},{false,false,false,true}}, //4
    new bool[5,4] {{true,true,true,true},{true,false,false,false},{true,true,true,true},{false,false,false,true},{true,true,true,true}}, //5
    new bool[5,4] {{true,true,true,true},{true,false,false,false},{true,true,true,true},{true,false,false,true},{true,true,true,true}}, //6
    new bool[5,4] {{true,true,true,true},{false,false,false,true},{false,false,true,false},{false,true,false,false},{true,false,false,false}}, //7
    new bool[5,4] {{true,true,true,true},{true,false,false,true},{true,true,true,true},{true,false,false,true},{true,true,true,true}}, //8
    new bool[5,4] {{true,true,true,true},{true,false,false,true},{true,true,true,true},{false,false,false,true},{true,true,true,true}}, //9
};

void WriteDigit(bool[,] array, int leftIndent, int topIndent = 2)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j])
            {
                Console.SetCursorPosition(j + leftIndent, i + topIndent);
                Console.Write("#");
            }
        }
    }
}

bool[,] IdentifyDigit(char digit)
{
    return digits[Convert.ToInt32($"{digit}")];
}

void WriteNumber()
{
    Console.Write("Введите натуральное число: ");
    string number = Console.ReadLine();

    for
    (
        int i = 0, leftIndent = 0;
        i < number.Length;
        leftIndent += IdentifyDigit(number[i]).GetLength(0), i++
    )
    {
        WriteDigit(IdentifyDigit(number[i]), leftIndent);
    }
}

WriteNumber();