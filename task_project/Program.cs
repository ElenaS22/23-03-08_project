// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина котороых не превышает или равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется использовать коллекции, лучше использовать исключительно массивы.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();


string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};

int MaxLengthOfWord = 3;
		
		string[] TransformToShortWord(string[] array)
		{
			int length = array.Length;			
			string[] result = new string[length];
			int count = 0;
			
			for (int i = 0; i < length; i++)
			{
				if(array[i].Length <= MaxLengthOfWord)
				{
					result[count] = array[i];
					count++;
				}
			}
			Array.Resize(ref result, count);
			
			return result;
		}
		
		void PrintArray(string[] array)
		{
			if(array.Length == 0)
			{
				Console.WriteLine("Массив не содержит символов");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
		
		void PrintTask(string[] array)
		{
			Console.WriteLine("Источник массива слов:");
			PrintArray(array);
			string[] shortArray = TransformToShortWord(array);
			Console.WriteLine($"Итоговый массив (с числом слов меньшим или равным по значению заданной длине символов: {MaxLengthOfWord} )");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		PrintTask(array1);
		PrintTask(array2);
		PrintTask(array3);
	