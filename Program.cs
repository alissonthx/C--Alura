using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // string[] aulas = new string[]
            // {
            //     aulaIntro,
            //     aulaModelando,
            //     aulaSets
            // };

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            System.Console.WriteLine(aulas);
            System.Console.WriteLine(aulas[0]);
            System.Console.WriteLine(aulas[aulas.Length - 1]);

            aulas[0] = "Trabalhando com arrays";
            Print(aulas);
        }

        private static void Print(string[] aulas)
        {
            // foreach (var aula in aulas){
            //     System.Console.WriteLine(aula);
            // }

            for (int i = 0; i < aulas.Length; i++)
            {
                System.Console.WriteLine(aulas[i]);
            }
        }
    }
}
