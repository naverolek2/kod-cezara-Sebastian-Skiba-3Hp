Console.WriteLine("Podaj frazę");
string fraza = Console.ReadLine();
Console.WriteLine("Podaj liczbę o ile ma być przesunięta fraza.");
int przes = Int32.Parse(Console.ReadLine());

char[] frazaChar;
frazaChar = fraza.ToCharArray();
bool upper, space;

for(int i = 0; i < frazaChar.Length; i++)
{
    upper = Char.IsUpper(frazaChar[i]);
    space = Char.IsWhiteSpace(frazaChar[i]);
       
        if (space == true )
    {
        continue;
    }
        else
    {
        // z jakiegoś powodu ten sposób zaczął działać dopiero z 2x(char) więc tak dałem. NIE RUSZAĆ !
        frazaChar[i] = (char)((char)frazaChar[i] + przes);
    }
        // Ten if else zawija max 1 raz więc prosze nie dawać jakiś absurdalnie wielkich liczb typu 123.
    if (upper == true)
    {
        if (frazaChar[i] > 90)
        {
            frazaChar[i] = (char)((char)frazaChar[i] - 26);
        }
    }
    else { 
        if (frazaChar[i] > 122)
        {
            frazaChar[i] = (char)((char)frazaChar[i] - 26);
        }
    }
    
}
string output = new string(frazaChar);

Console.WriteLine("Zaszyfrowany kod to: " + output);
