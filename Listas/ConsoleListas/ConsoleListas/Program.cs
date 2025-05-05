// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> lista = new List<string>();

lista.Add("Elemento 1");
lista.Add("Elemento 2");
lista.Add("Elemento 3");
lista.Add("Elemento 4");
lista.Add("Elemento 5");
lista.Add("Elemento 6");
lista.Add("Elemento 7");

Carros gm = new Carros("GM", "Onix", 2020, "Preto");

Console.WriteLine(gm.ToString());




public class Carros
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public Carros(string marca, string modelo, int ano, string cor)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
    }
    public override string ToString()
    {
        return $"Veiculo da Marca: {Marca} Modelo: {Modelo} Fabricação: {Ano} Cor: {Cor}";
    }
}