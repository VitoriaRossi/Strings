// See https://aka.ms/new-console-template for more information;
string cidade = "Mongaguá";
string estado = "SP";

string mensagem = $"A Etec AB fica localizada em {cidade}/{estado}.";

string novaMensagem = mensagem
 .Replace("e","x")
 .Replace("E", "X");

Console.WriteLine(mensagem.ToUpper());
Console.WriteLine(mensagem.ToLower());

Console.WriteLine(novaMensagem);
