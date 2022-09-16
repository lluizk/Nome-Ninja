System.Console.WriteLine("---Nome Ninja ---\n");



System.Console.Write("Escreva seu nome: ");
string nomeUsuario = Console.ReadLine()!;

   string nomeNinja = nomeUsuario.Trim().ToLower()
    .Replace("a", "KA")
    .Replace("á", "KA")
    .Replace("à", "KA")
    .Replace("ã", "KA")
    .Replace("b", "ZU")
    .Replace("c", "MI")
    .Replace("d", "TE")
    .Replace("e", "KU")
    .Replace("é", "KU")
    .Replace("ê", "KU")
    .Replace("f", "LU")
    .Replace("g", "JI")
    .Replace("h", "RI")
    .Replace("i", "KI")
    .Replace("í", "KI")
    .Replace("ì", "KI")
    .Replace("j", "ZUS")
    .Replace("k", "ME")
    .Replace("l", "TA")
    .Replace("m", "RIN")
    .Replace("n", "TO")
    .Replace("o", "MO")
    .Replace("ó", "MO")
    .Replace("ô", "MO")
    .Replace("p", "NO")
    .Replace("q", "KE")
    .Replace("r", "SHI")
    .Replace("s", "ARI")
    .Replace("t", "CHI")
    .Replace("u", "DO")
    .Replace("ú", "DO")
    .Replace("v", "RU")
    .Replace("w", "MEI")
    .Replace("x", "NA")
    .Replace("y", "FU")
    .Replace("z", "ZI");

nomeNinja = $"{nomeNinja.Substring(0, 1).ToUpper()}{nomeNinja.Substring(1).ToLower()}";
System.Console.WriteLine($"\nSeu nome ninja é: {nomeNinja}.");