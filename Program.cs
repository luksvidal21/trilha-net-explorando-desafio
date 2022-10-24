using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
List<Pessoa> hospedes2 = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");
Pessoa p5 = new Pessoa(nome: "Hóspede 5");
Pessoa p6 = new Pessoa(nome: "Hóspede 6");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes2.Add(p3);
hospedes2.Add(p4);
hospedes2.Add(p5);
hospedes2.Add(p6);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suite2 = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 100);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
Reserva reserva2 = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
reserva2.CadastrarSuite(suite2);
reserva2.CadastrarHospedes(hospedes2);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes Totais do Hotel: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}");