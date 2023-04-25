namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um aluno
            Aluno aluno1 = new Aluno();
            aluno1.Nome = "João Silva";
            aluno1.Matricula = 12345;

            // Criando uma disciplina
            Disciplina disciplina1 = new Disciplina();
            disciplina1.Nome = "Matemática";
            disciplina1.CargaHoraria = 80;

            // Criando um professor
            Professor professor1 = new Professor();
            professor1.Nome = "Maria Oliveira";
            professor1.Sexo = 'F';
            professor1.Disciplinas.Add(disciplina1);

            // Demonstrando o polimorfismo, com o professor sendo adicionado em uma lista de Pessoas
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(aluno1);
            pessoas.Add(professor1);

            // Demonstrando a impressão polimórfica da lista de Pessoas
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }
        }
    }
}
