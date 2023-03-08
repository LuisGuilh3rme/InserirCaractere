Console.WriteLine("Informe o texto a ser modificado:");
string texto = Console.ReadLine();

Console.WriteLine("Informe o caractere a ser inserido:");
char.TryParse(Console.ReadLine(), out char caractere);

string textoFinal = InserirAntes(texto, caractere);
Console.WriteLine("Texto original: {0}", texto);
Console.WriteLine("Texto modificado: {0}", textoFinal);


string InserirAntes (string texto, char caractere)
{
    string textoEmMinusculo = texto.ToLower();
    char[] consoantes = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
    string textoFinal = "";

    for (int i = 0; i < texto.Length; i++)
    {
        for (int j = 0; j < consoantes.Length; j++)
        {
            if (textoEmMinusculo[i] == consoantes[j])
            {
                textoFinal += caractere;
                break;
            }
        }
        textoFinal += texto[i];
    }

    return textoFinal;
}