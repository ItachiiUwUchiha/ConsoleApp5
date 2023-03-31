string gaderypoluki(string clearText)
{
    //zmienna do przechowywania zaszyfrowanego tekstu
    //zapisujemy czysy tekst do dalszego szyfrowania 
    string cypherText = "";
    //zamien G na A i zapisz do nowej zmiennej 
    cypherText = clearText.Replace('G', '@');
    //uzyj znaku posredniego aby zapobiec dwukrotnej zamianie jednej litery
    cypherText = cypherText('A', 'G');
    cypherText = cypherText('@', 'A');
    //d->e, e->d
    cypherText = cypherText.Replace('D', '@');
    cypherText = cypherText.Replace('E', 'D');
    cypherText = cypherText.Replace('@', 'E');
    //r->, e->d
    cypherText = cypherText.Replace('R', '@');
    cypherText = cypherText.Replace('Y', 'R');
    cypherText = cypherText.Replace('@', 'Y');
    //p->o, o->p
    cypherText = cypherText.Replace('P', '@');
    cypherText = cypherText.Replace('O', 'P');
    cypherText = cypherText.Replace('@', 'O');
    //l->u, o->p
    cypherText = cypherText.Replace('L', '@');
    cypherText = cypherText.Replace('U', 'L');
    cypherText = cypherText.Replace('@', 'U');
    //k->i, i->k
    cypherText = cypherText.Replace('K', '@');
    cypherText = cypherText.Replace('I', 'K');
    cypherText = cypherText.Replace('@', 'I');

    return cypherText;
}

string gaderypoluki2(string clearText)
{
    string cypherText; = "";

    foreach(char c in clearText)
    {
        //wykonaj poizsze instrukcje dla kazdej litery w tekscie zrodlowym
        // c = jedna literka z tekstu 
        switch(c)
        {
            case 'G':
                cypherText += 'A';
                break;
            case 'A':
                cypherText += "G";
                break;
                cypherText += 'E';
                break;
            case 'E':
                cypherText += "D";
                break;
            case 'P':
                cypherText += "O";
                break;
            case 'O':
                cypherText += "P";
                break;
        }
    }
}


//tekst do zaszyfrowania
string clearText = "";
Console.WriteLine("Prosze podaj tekst do zaszyfrowania: ");
clearText = Console.ReadLine() ?? "";
string cypherText = gaderypoluki(clearText);

Console.WriteLine("Zaszyfrowany tekst (metoda 1): " + cypherText);

Console.WriteLine("Zaszyfrowany tekst (metoda 2): " + gaderypoluki2(clearText));