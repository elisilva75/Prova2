namespace Escola
// Classe Aluno, que herda de Pessoa
{
    public class Aluno : Pessoa
    {
        private int matricula;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public override string ToString()
        {
            return $"Aluno: {Nome} - Matrícula: {Matricula}";
        }
    }
}