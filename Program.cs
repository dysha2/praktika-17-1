// See https://aka.ms/new-console-template for more information
//17 практическая 1 задание
if (File.Exists("input.txt"))
{
    Console.WriteLine("Введите слово для поиска");
    string wordToFind = Console.ReadLine();
    int count = 0;
    string punctuation = "«.,!<>{}[]:;?-»";
    string[] text = File.ReadAllText("input.txt").Split(" ");
    foreach (char punct in punctuation)
    {
        for (int i=0;i<text.Length; i++)
        {
            text[i] = text[i].Replace(punct.ToString(), "");
        }
    }
    count = text.Where(i => i.ToLower() == wordToFind.ToLower()).Count();
    Console.WriteLine($"Слово {wordToFind} встречается {count} раз");
}
else
{
    Console.WriteLine("Файл с входными данными не найден");
}
