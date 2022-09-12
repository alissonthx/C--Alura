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

            Console.WriteLine(aulas);
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulas[0] = "Trabalhando com arrays";
            Imprimir(aulas);
            Console.WriteLine("Aula modelando está no indice " + Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine("Aula modelando está no indice" + Array.LastIndexOf(aulas, aulaModelando));

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);


            // output array[2] = null
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";

            Array.Sort(aulas);
            Imprimir(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia,0, 2);
            Imprimir(copia);

            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            // output array[2], [3] = null
            Array.Clear(clone, 1, 2);
            Imprimir(clone);
        }

        private static void Imprimir(string[] aulas)
        {
            // foreach (var aula in aulas){
            //     Console.WriteLine(aula);
            // }

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
