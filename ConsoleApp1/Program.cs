
class Program
{
    static void Main()
    {
        PrinterQueue printerQueue = new PrinterQueue();

        while (true)
        {
            Console.Write("Команда: ");
            string input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
                continue;

            string[] parts = input.Split(' ', 3);
            string command = parts[0].ToLower();

            switch (command)
            {
                case "add":
                    if (parts.Length < 3 || !int.TryParse(parts[2], out int pages) || pages <= 0)
                    {
                        Console.WriteLine("Грешен формат! Използвайте: add <заглавие> <страници>");
                        continue;
                    }
                    printerQueue.AddDocument(parts[1], pages);
                    break;

                case "print":
                    printerQueue.PrintDocument();
                    break;

                case "history":
                    printerQueue.ShowHistory();
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Непозната команда! Опитайте: add, print, history, exit");
                    break;
            }
        }
    }
}

