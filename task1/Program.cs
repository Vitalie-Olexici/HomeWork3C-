// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].


using System.Runtime.CompilerServices;

int[] array = new int[10];
FillArray(array);
PrintArray(array);



void FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().Next(1, 101);
        index ++;
    }
}

void PrintArray(int [] col){
    int count = col.Length;
    int position = 0;
    while (position < count){
    Console.Write(col[position] +" ");
    position++;
    }
}


void FindNumber(int [] array){
    int num = 0;
    for (int i = 0; i < array.Length; i++ ){
            if (90 > array[i]) {
                if (array[i] > 20){
                num++;
            }
        }
    }
    Console.WriteLine();
    Console.Write(num);
        
}





FindNumber(array);


