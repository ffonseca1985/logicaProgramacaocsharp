namespace Aula3
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunDictinary();
            RunVetor();
            RunMatriz();

            Console.WriteLine("Hello, World!");
        }

        static void RunDictinary()
        {
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("mesa", 2.3);

            Dictionary<string, double> valores2 = new Dictionary<string, double>() { { "mesa", 2 } };

            List<string> keys = new List<string>(valores2.Keys);
            for (int i = 0; i < keys.Count(); i++)
            {
                var key = keys[i];
                var valor = valores2[key];

                Console.WriteLine(valor);
            }

            foreach (var item in valores2)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            valores.TryGetValue("mesa", out double result);
            valores.Remove("mesa");

            valores.Clear();
            Console.WriteLine(result);
        }

        static void RunMatriz()
        {
            int[,] vetorInteiro = {
                {1, 2},
                {4, 5},
                { 4, 5}
            };


            int[,] vetorInteiro1 = new int[,] {
                {1, 2},
                {4, 5},
                { 4, 5}
            };

            int[,] multidimensionalArray = new int[3, 3] { { 16, 52, 3 }, { 91, 43, 2 }, { 77, 28, 1 } };

            Console.WriteLine(multidimensionalArray.Rank); //Dimensoes

            foreach (var item in multidimensionalArray)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < multidimensionalArray.GetLength(0); i++)
            {
                for(int j = 0; j < multidimensionalArray.GetLength(1); j++)
                {
                    int elemento = multidimensionalArray[i, j];
                }
            }
        }
        static void RunVetor()
        {
            int[] vetorInteiro = new int[5];
            vetorInteiro[0] = 1;
            vetorInteiro[1] = 2;
            vetorInteiro[2] = 3;
            vetorInteiro[3] = 4;
            vetorInteiro[4] = 5;

            //Resize
            Array.Resize(ref vetorInteiro, vetorInteiro.Length + 5);
            vetorInteiro[5] = 1;

            int[] vetorInteiroInicializado = new int[] { 1, 2, 4, 3, 5 };
            Console.WriteLine(vetorInteiroInicializado.Length);

            var novo = (int[])vetorInteiroInicializado.Clone();
            Console.WriteLine(novo);

            Array.Sort(novo);
            int[] newSort = novo.OrderBy(x => x).ToArray();
            int[] newSortDesc = novo.OrderByDescending(x => x).ToArray();

            IEnumerable<int> newList = novo.Where(x => x > 3);
            var se = Array.IndexOf(vetorInteiro, 5);
            var se2 = Array.IndexOf(vetorInteiro, 7);

            Array.Exists(vetorInteiro, x => x == 1);

            string join = string.Join(',', vetorInteiro);

            //juntar 2 arrays

            int[] vetorInteiro2 = vetorInteiro.Concat(vetorInteiroInicializado).ToArray();
            Array.Copy(vetorInteiro, vetorInteiro2, 3);// sorce, dest, n first elements
        }
    }

    class Teste
    {
        public int[]  data = new int[5] {1, 2, 3, 4, 5};
        public int this[int index] { get { return data[index]; }}
    }
}