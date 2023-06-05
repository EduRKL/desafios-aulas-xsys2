// See https://aka.ms/new-console-template for more information
using MyVillage.Model;

Console.WriteLine("Bem vindo ao vilarejo EduTown");

Person eduardo = new("12312312312", "Eduardo", 'M', 1.80, new DateTime(1988, 9, 11));
Person bruna = new("12312312313", "Bruna", 'F', 1.60, new DateTime(1989, 10, 5));
Person fernanda = new("12312312314", "Fernanda", 'F', 0.84, new DateTime(2021, 9, 10));
Person clara = new("12312312315", "Clara", 'F', 0.50, new DateTime(2023, 2, 2));
Person vera = new("12312312316", "Vera", 'F', 1.61, new DateTime(1957, 9, 14));
Person carol = new("12312312317", "Carol", 'F', 1.69, new DateTime(1985, 9, 6));
Person felipe = new("12312312318", "Felipe", 'M', 1.70, new DateTime(1986, 6, 18));
Person julia = new("12312312319", "Julia", 'F', 0.65, new DateTime(2021, 11, 5));
Person ricardo = new("12312312310", "Ricardo", 'M', 1.80, new DateTime(1960, 11, 22));
Person elaine = new("12312312311", "Elaine", 'F', 1.72, new DateTime(1962, 5, 15));

List<Person> casa1 = new();
casa1.Add(eduardo);
casa1.Add(bruna);
casa1.Add(fernanda);
casa1.Add(clara);

List<Person> casa2 = new();
casa2.Add(felipe);
casa2.Add(carol);
casa2.Add(julia);

List<Person> casa3 = new();
casa3.Add(vera);

List<Person> casa4 = new();
casa4.Add(ricardo);
casa4.Add(elaine);

eduardo.Height(1.81);
eduardo.Height(1.81);

HouseProperties casaComDoisBanheiros = new(2, 4, 1, false, false, false);
HouseProperties casaComDoisQuartos = new(1, 2, 1, false, false, false);
HouseProperties casaSemSala = new(1, 1, 0, false, false, false);
HouseProperties casaComQuintal = new(3, 5, 1, true, false, false);
HouseProperties umaCasaSemMoradorAVenda = new(2, 2, 0, true, false, true);
HouseProperties umTerrenoVazio = new();

casaComDoisBanheiros.addOccupantList(casa1);
casaComDoisBanheiros.TamanhoDoTerreno = 1800;
casaComDoisQuartos.addOccupantList(casa2);
casaSemSala.addOccupantList(casa3);
casaComQuintal.addOccupantList(casa4);

Console.WriteLine(casaComDoisBanheiros);
Console.WriteLine(casaComDoisQuartos);
Console.WriteLine(casaSemSala);
Console.WriteLine(casaComQuintal);
Console.WriteLine(umaCasaSemMoradorAVenda);
Console.WriteLine(umTerrenoVazio);

Console.WriteLine(casaComDoisBanheiros.mediaIdadesDasPessoasNaCasa());


casaComDoisBanheiros.SwapOnePerson(eduardo, casaComQuintal);
Console.WriteLine();
Console.WriteLine(casaComDoisBanheiros);
Console.WriteLine();
Console.WriteLine(casaComQuintal);


