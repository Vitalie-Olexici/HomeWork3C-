// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[7];
FillArray(array);
PrintArray(array);



void FillArray(double[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().NextDouble();
        index ++;
    }
}

void PrintArray(double [] col){
    int count = col.Length;
    int position = 0;
    while (position < count){
    Console.Write(col[position] +" ");
    position++;
    }
}


void FindNumberResult(double [] array){
    double maxValue = array.Max();
    Console.WriteLine();
    Console.Write("Max: ");
    Console.Write(maxValue);
    double minValue = array.Min();
    Console.WriteLine();
    Console.Write("Min: ");
    Console.Write(minValue);
    double result = maxValue - minValue;
    Console.WriteLine();
    Console.Write("Result: ");
    Console.Write(result);
}
FindNumberResult(array);