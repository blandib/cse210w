using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }
    public Reference(string book, int chapter, int startVerse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endverse;
    }
    public string GetDisplayText()
    {
        return _endVerse.HasValue
              ? $"{_book} {_chapter}: {_startVerse}-{_endVerse}"
              : $"{_book} {_chapter}: {_startVerse}";
    }
}