using System;
using System.Collections.Generic;

namespace Escola
{
    // Classe abstrata Pessoa
    public abstract class Pessoa
    {
        private string nome;
        private int idade;
        private char sexo;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}