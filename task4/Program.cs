// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

Random rnd = new Random();
int value = rnd.Next(1, 100001);
Console.WriteLine(value);

char[] arr = value.ToString().ToCharArray();

void Main(char[] arr){
    Array.Sort(arr);
    Array.Reverse(arr);
    Console.WriteLine(String.Join(", ", arr));
}

Main(arr);