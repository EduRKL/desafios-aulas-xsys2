using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyVillage.Model
{
    internal class Person
    {
        public String Cpf { get; set; }
        private String _name { get; set; }
        
        public char Gender { get; }
        public DateTime BirthDate { get;}
        private double _height { get; set; }
        public float Weight { get; set; }

        public int calculaIdade (DateTime birthDate)
        {
            DateTime dataAtual = DateTime.Now.Date;

            int idade = dataAtual.Year - birthDate.Year;

            return idade;
        }

        public Person(string cpf)
        {
            Cpf = cpf;
        }

        public Person(string cpf, string name, char gender, double height, DateTime birthDate)
        {
            Cpf = cpf;
            _name = name;
            Gender = gender;
            _height = height;
            BirthDate = birthDate;
            
        }

        public string Name()
        {
            return _name;
        }
        public void Name(string name)
        {
            if (calculaIdade(BirthDate) < 18)
            {
                _name = name;
                return;
            }
            Console.WriteLine("Menor de 18 anos não pode trocar o nome");
            
        }

        public double Height()
        {
            return _height;
        }

        public void Height(double height)
        {
            if (calculaIdade(BirthDate) < 21)
            {
                _height = height;
                return;
            }
            Console.WriteLine("Só é possível alteração de altura até 21 anos");
            
        }

       

    }

}
