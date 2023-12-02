using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _verseWords = new List<Word>();

    public Scripture(Reference reference, string verseText)
    { 
        _reference = reference;
        string[] verseWords = verseText.Split();    // ["for", "God"...]
       
        foreach(string word in verseWords)
        {
            Word verseWord = new Word(word);
            _verseWords.Add(verseWord); 
        }
        
        // Console.Write(_reference.GetDisplayReferenceOne());
        // Console.WriteLine(verseWords);   
    }

    public void HideRandWords(int numberToHide)
    {

        for (int i = 0; i < numberToHide; i++)
            {
                    Random rand = new Random();
                    int wordIndex = rand.Next(_verseWords.Count);
                    Word randWord = _verseWords[wordIndex];
                    randWord.Hide();   
            }
    }

    public string GetDisplayText()
    {   
        Word word = new Word("For God so loved the world, that He gave His only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        return $"{_reference.GetDisplayReferenceOne()} {word.GetDisplayVerseText()}"; 
          
    }

    public bool IsCompletelyHidden()
    {    
        foreach (Word word in _verseWords)
        {
            return true;    
        }
        return true;
    }
    
}