using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVillage.Model
{
    internal class House : Terreno
    {
        public int? Bathroom { get; set; }
        public int? Bedroom { get; set; }
        public int? LivingRoom { get; set; }
        public bool HasYard { get; set; }
        public List<Person>? Occupants { get; set; } = new();

        public House()
        {

        }

        public House(int bathroom, int bedroom, int livingRoom, bool hasYard)
        {
            Bathroom = bathroom;
            Bedroom = bedroom;
            LivingRoom = livingRoom;
            HasYard = hasYard;
        }


        public string occupantsList()
        {
            string occupantsNames = string.Empty;
            if(Occupants.Count != 0)
            {
                foreach (Person occupant in Occupants)
                {
                    occupantsNames += occupant.Name() + "\n";
                }
            }

            return occupantsNames;
           
        }

        public bool hasOccupant(List<Person> occupant)
        {
            if(occupant.Count != 0)
            {
                return true;
            }
            return false;
        }

        public string boolResponse (bool boolProperty)
        {
            return boolProperty ? "Sim" : "Não";
        }

        public void addOccupant(Person person)
        {
            if (!searchByCpf(person.Cpf))
            {
                Occupants.Add(person);
                Console.WriteLine($"Morador {person.Name()} adicionado com sucesso!");
                return;
            }

            Console.WriteLine($"Morador {person.Name()} já existente na casa");

        }

        public void removeOccupant(Person person)
        {
            if (searchByCpf(person.Cpf))
            {
                Occupants.Remove(person);
                Console.WriteLine($"Morador {person.Name()} removido com sucesso");
                return;
            }

            Console.WriteLine("Morador não encontrado");
           
        }

        public void addOccupantList (List<Person> persons)
        {
            foreach(Person person in persons)
            {
                addOccupant(person);
            }
        }

        public void removeOccupantList (List<Person> persons)
        {
            foreach(Person person in persons)
            {
                removeOccupant(person);
            }
        }

        public bool searchByCpf(string cpf)
        {
            bool isFounded = false;
            if (Occupants.Count != 0)
            {
                foreach(Person occupant in Occupants)
                {
                    if(occupant.Cpf == cpf)
                    {
                        isFounded = true; 
                        break;
                    }
                }
            }
            return isFounded;
        }

        public float OccupantsMeanAge (List<Person> occupants)
        {
            float meanAge = 0;
            float numberOfOccupants = occupants.Count();
            foreach (Person occupant in occupants)
            {
                meanAge += occupant.calculaIdade(occupant.BirthDate);
            }

            return meanAge/numberOfOccupants;
        }

        public void SwapOnePerson(Person occupant, House to)
        {
            if (searchByCpf(occupant.Cpf))
            {
                removeOccupant(occupant);
                to.addOccupant(occupant);
                Console.WriteLine("Troca de casas realizada com sucesso!");
                return;
            }
            Console.WriteLine("Não foi possível realizar essa operação.");
        }

        public double mediaIdadesDasPessoasNaCasa()
        {
            int totalDePessoas = Occupants.Count;
            double somatorioDeIdades = 0;
            foreach(Person occupant in Occupants)
            {
                somatorioDeIdades += occupant.calculaIdade(occupant.BirthDate);
            }
            return somatorioDeIdades/totalDePessoas;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append($"Número de Banheiro(s): {Bathroom}\n");
            sb.Append($"Número de Quarto(s): {Bedroom}\n");
            sb.Append($"Tem quintal: {boolResponse(HasYard)}\n");
            sb.Append($"Lista de Moradores:\n{occupantsList()}");
            
            return base.ToString() + sb.ToString(); 
        }


    }
}
