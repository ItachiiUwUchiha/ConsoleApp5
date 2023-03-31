//tekst do zaszyfrowania
string clearText = "GADERYPOLUKI";
//zmienna do przechowywania zaszyfrowanego tekstu
string cypherText = "";
//zamien G na A i zapisz do nowej zmiennej 
cypherText = clearText.Replace('G', 'A');
//wez juz czesciowo zaszyfrowany tekst i zamien A na G
cypherText = clearText.Replace('A', 'G');
//d->e, e->d
cypherText = cypherText.Replace('D', 'E');
cypherText = cypherText.Replace('E', 'D');
//r->, e->d
cypherText = cypherText.Replace('R', 'Y');
cypherText = cypherText.Replace('Y', 'R');
//p->o, o->p
cypherText = cypherText.Replace('P', 'O');
cypherText = cypherText.Replace('O', 'P');
//l->u, o->p
cypherText = cypherText.Replace('L', 'U');
cypherText = cypherText.Replace('U', 'L');
//k->i, i->k
cypherText = cypherText.Replace('K', 'I');
cypherText = cypherText.Replace('I', 'K');

Console.WriteLine("Zaszyfrowany tekst: " + cypherText);