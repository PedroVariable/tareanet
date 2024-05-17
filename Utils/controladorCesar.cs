namespace codigoCesar.Utils
{
public static class encriptacionCesar
{
    public static string Cifrar(string input, int n)
    {
        return TextoValor(input, n);
    }

    public static string Descifrar(string input, int n)
    {
        return TextoValor(input, -n);
    }

    private static string TextoValor(string texto, int n)
{
    char[] buffer = texto.ToCharArray();
    for (int i = 0; i < buffer.Length; i++)
    {
        char letter = buffer[i];
        
        if (char.IsLetter(letter))
        {
            char offset = char.IsUpper(letter) ? 'A' : 'a';
            int alphaPosition = (letter - offset + n) % 26;
            letter = (char)(alphaPosition + offset);

            if (alphaPosition < 0)
            {
                letter = (char)(letter + 26);
            }
        }
        
        buffer[i] = letter;
    }
    return new string(buffer);
}
}
}