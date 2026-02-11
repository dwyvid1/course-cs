Console.WriteLine("## Inferência Tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00M;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

// var limitações

// var salario = null; // Erro: Não pode inicializar var com null
// var titulo;         // Erro: var requer inicialização
// var salario, imposto, total; // Erro: Não pode declarar múltiplas variáveis com var

// não posso mudar o tipo apos inicializar
var num = 10;
num = num + 20;
// num = "Teste"; // Erro de compilação

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}