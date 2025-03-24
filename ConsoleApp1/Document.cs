using System;
using System.Collections.Generic;

class Document
{
    public string Title { get; }
    public int Pages { get; }

    public Document(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public override string ToString()
    {
        return $"{Title} ({Pages} pages)";
    }
}
