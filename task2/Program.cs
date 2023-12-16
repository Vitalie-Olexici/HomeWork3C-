// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
FillArray(array);
PrintArray(array);



void FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().Next();
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
            if (array[i] % 2 == 0) {
                num++;
            }
        }
    Console.WriteLine();
    Console.Write(num);
        
}

FindNumber(array);
