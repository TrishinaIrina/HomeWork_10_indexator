using System;

namespace HomeWork_10_indexator
{
    class Program
    {
        /*1.	Создать индексатор для одномерного массива который при установке значения будет возводить
        в квадрат передаваемое значение переменной и устанавливать его для указанного индекса. 
        При получении элемента массива по индексу будет возвращаться его текущее значение.*/
        static void Main(string[] args)
        {
            Array arr = new Array(3);
            for (int i = 0; i < arr.size; i++)
            {
                Console.WriteLine("Передаем в " + i + " элемент массива цифру " + (i + 2));
                arr[i] = i + 2;
                Console.WriteLine("Значение " + i + " элемента, благодаря индексатору: " + arr[i]);
                Console.WriteLine();
            }
        }

        public class Array
        {
            public int size { get; set; }
            public int[] arr;
            public Array(int size)
            {
                try
                {
                    if (size > 0)
                        this.size = size;
                    else
                        throw new Exception("размер массива не может быть меньше 0");
                    arr = new int[size];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public int this[int index]
            { 
                get { return arr[index]; }
                set { arr[index] = value * value; }
            }


        }
    }
}
