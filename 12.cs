using System; 
using System.Text.RegularExpressions; 
 
class Example 
{ 
 static void Main() 
 { 
 // Массив тестируемых строк 
 string[] test = { 
 "Wuck World", "Hello world", "My wonderful world" 
 }; 
 
 // Проверим, содержится ли в исходных строках слово World 
 // при этом мы не укажем опции RegexOption 
 Regex regex = new Regex("World"); 
 
 Console.WriteLine("Регистрозависимый поиск: "); 
 foreach (string str in test) 
 { 
 if (regex.IsMatch(str)) 
 Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str); 
 } 
 Console.WriteLine(); 
 
 // Теперь укажем поиск, не зависимый от регистра 
 regex = new Regex("World", RegexOptions.IgnoreCase); 
 
 Console.WriteLine("РегистроНЕзависимый поиск: "); 
 foreach (string str in test) 
 { 
 if (regex.IsMatch(str)) 
 Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str); 
 } 
 } 
}