using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAtleta
{
    public class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;

        public string Nome {
            set {
                if (value != string.Empty) {
                    nome = value;
                } else {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return nome; }
        }

        public double Altura {
            set {
                if (value >= 0) {
                    altura = value;
                } else {
                    throw new Exception("O valor da Altura deve ser positiovo.");
                }
            }
            get { return altura; }
        }

        public double Peso {
            set {
                if (value >= 0) {
                    peso = value;
                } else {
                    throw new Exception("O valor do Peso deve ser positiovo.");
                }
            }
            get { return peso; }
        }

        public int Idade
        {
            set {
                if (value >= 0) {
                    idade = value;
                } else {
                    throw new Exception("O valor da Idade deve ser positiovo.");
                }
            }
            get { return idade; }
        }

        public double CalcularIMC() {
            return peso / (altura * altura);
        }
    }
}