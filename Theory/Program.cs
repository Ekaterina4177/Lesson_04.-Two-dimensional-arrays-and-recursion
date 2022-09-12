//Урок 4. Двумерные массивы и рекурсия.

/*  Как задается двумерный массив: 
string[,] table = new string[2, 5];
   int[,] matrix = new int[5, 8];  */

//Пример 1. Заполнение двумерного массива

//string[,] table = new string[2, 5];
// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]
/* table[1, 2] = "слово";
for(int rows = 0; rows < 2; rows++){
    for(int columns = 0; columns < 5; columns++){
        Console.Write($"-{table[rows, columns]}-");
    }
    Console.WriteLine();
}*/

/* Пример 2. Вывод массива построчно
int[,] matrix = new int[3, 4];
for(int i = 0; i < 3; i++){
    for(int j = 0; j < 4; j++){
      Console.Write($"{matrix[i, j]} ");  
    }
Console.WriteLine();
} */
 
//Пример 3. Добавляем новую переменную .GetLength(). Результат тот же.
/* int[,] matrix = new int[3, 4];
for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
      Console.Write($"{matrix[i, j]} ");  
    }
Console.WriteLine();
} */

//Пример 4. Метод заполнения и вывода на экран двумерного массива.

void PrintArray(int[,] matr){

for(int i = 0; i < matr.GetLength(0); i++){
    for(int j = 0; j < matr.GetLength(1); j++){
      Console.Write($"{matr[i, j]} ");  
    }
Console.WriteLine();
}
}

int[,] matrix = new int[3, 4];

void FillArray(int[,] matr){
   for(int i = 0; i < matr.GetLength(0); i++){
    for(int j = 0; j < matr.GetLength(1); j++){
      matr[i, j] = new Random().Next(1, 10); 
    }
}
}
Console.Clear();
Console.WriteLine("Таблица чисел:");
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);