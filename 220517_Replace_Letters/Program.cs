// Заменить в тексте ПРОБЕЛ на  "|", с на С

string text = "В лесу родилась Ёлочка, В лесу она росла.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++) 
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;    
}

string NewText = Replace(text, ' ', '|');
NewText = Replace(NewText, 'с', 'С');
Console.WriteLine(NewText);

