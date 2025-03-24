class PrinterQueue
{
    private Queue<Document> queue = new Queue<Document>();
    private Stack<Document> history = new Stack<Document>();

    public void AddDocument(string title, int pages)
    {
        queue.Enqueue(new Document(title, pages));
        Console.WriteLine($"Документ \"{title}\" добавен в опашката.");
    }

    public void PrintDocument()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Няма документи за печат.");
            return;
        }

        Document doc = queue.Dequeue();
        Console.WriteLine($"Печатане: {doc}");

        history.Push(doc);
        if (history.Count > 3)
        {
            Stack<Document> temp = new Stack<Document>();
            while (history.Count > 3) temp.Push(history.Pop());
            history.Clear();
            while (temp.Count > 0) history.Push(temp.Pop());
        }
    }

    public void ShowHistory()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("Няма отпечатани документи.");
            return;
        }

        Console.WriteLine("Последни 3 отпечатани документа:");
        foreach (var doc in history)
        {
            Console.WriteLine(doc);
        }
    }
}
