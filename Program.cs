using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes1 = new List<Pessoa> {
    new Pessoa(nome: "João", sobrenome:"Silva"),
    new Pessoa(nome: "Maria", sobrenome:"Oliveira"),
    new Pessoa(nome: "Lucas", sobrenome: "Carvalho"),
    new Pessoa(nome: "Tiago", sobrenome: "Coelho")
};

List<Pessoa> hospedes2 = new List<Pessoa> {
    new Pessoa(nome: "Alice", sobrenome: "Barros"),
    new Pessoa(nome: "Adriano", sobrenome: "Almeida"),
    new Pessoa(nome: "Eduardo", sobrenome: "Silva")
};

List<Pessoa> hospedes3 = new List<Pessoa> {
    new Pessoa(nome: "Amanda", sobrenome: "Carvalho"),
    new Pessoa(nome: "Pedro", sobrenome: "Nunes")
};

// Cria as suítes
Suite suite1 = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 300);
Suite suite2 = new Suite(tipoSuite: "Simples", capacidade: 3, valorDiaria: 150);
Suite suite3 = new Suite(tipoSuite: "Simples", capacidade: 2, valorDiaria: 100);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new Reserva(diasReservados: 15);
reserva1.CadastrarSuite(suite1);
reserva1.CadastrarHospedes(hospedes1);

Reserva reserva2 = new Reserva(diasReservados: 10);
reserva2.CadastrarSuite(suite2);
reserva2.CadastrarHospedes(hospedes2);

Reserva reserva3 = new Reserva(diasReservados: 3);
reserva3.CadastrarSuite(suite3);
reserva3.CadastrarHospedes(hospedes3);

// Exibe a quantidade de hóspedes e o valor da diária.
//Hospedagem da suíte 1:
Console.WriteLine($"Suíte 1: {suite1.TipoSuite}");
Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
foreach (var hospede in hospedes1)
{
    Console.WriteLine(hospede.NomeCompleto);
}
Console.WriteLine($"Valor diária: {reserva1.CalcularValorDiaria()}\n");

//Hospedagem da suíte 2:
Console.WriteLine($"Suíte 2: {suite2.TipoSuite}");
Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
foreach (var hospede in hospedes2)
{
    Console.WriteLine(hospede.NomeCompleto);
}
Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}\n");

//Hospedagem da suíte 3:
Console.WriteLine($"Suíte 3: {suite3.TipoSuite}");
Console.WriteLine($"Hóspedes: {reserva3.ObterQuantidadeHospedes()}");
foreach (var hospede in hospedes3)
{
    Console.WriteLine(hospede.NomeCompleto);
}
Console.WriteLine($"Valor diária: {reserva3.CalcularValorDiaria()}\n");