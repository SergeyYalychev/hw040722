// Задача 29

Console.Write("Задайте длинну массива - ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте размер ячеек массива - ");
int b = Convert.ToInt32(Console.ReadLine());
 
 int[] myArray = new int[a];
         Random rand = new Random();
            
         for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(b);
                Console.WriteLine("Значение элемента массива " + i + " = " + myArray[i]);
            }