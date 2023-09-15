// See https://aka.ms/new-console-template for more information
using LC_task;


Tasks tasks = new Tasks();
tasks.ProductExceptSelf(new List<int> { 4, 3, 2, 7, 8, 2, 3, 1 }.ToArray());

//char[][] chars = { new char[] { 'A' } };

//char[][] chars = { new char[] { 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
char[][] chars = { new char[] { 'C', 'A', 'A' }, new char[] { 'A', 'A', 'A' }, new char[] { 'B', 'C', 'D' } };
Console.WriteLine(tasks.Exist(chars, "AAB"));
