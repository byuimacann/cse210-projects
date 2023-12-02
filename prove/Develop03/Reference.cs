using System.Dynamic;

public class Reference
{
    private string _book;
    private int _chapterNumber;
    private int _verseNumber;
    private int _endVerseNumber;


    public Reference(string book, int chapterNumber, int verseNumber)
    {
        _book = book;
        _chapterNumber = chapterNumber;
        _verseNumber = verseNumber;
    }

    public Reference(string book, int chapterNumber, int verseNumber, int endVerseNumber)
    {
        _book = book;
        _chapterNumber = chapterNumber;
        _verseNumber = verseNumber;
        _endVerseNumber = endVerseNumber;

    }

    public string GetDisplayReferenceOne()
    {
        string verseReference = $"{_book} {_chapterNumber}: {_verseNumber} ";
        return verseReference;
    }

    public string GetDisplayReferenceTwo()
    {
        string verseReferenceTwo = $"{_book} {_chapterNumber}:{_verseNumber}-{_endVerseNumber} ";
        return verseReferenceTwo;
    }
}