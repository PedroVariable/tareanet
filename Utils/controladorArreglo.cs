namespace controladorArreglo.Utils{
    public static class Aritmetica{
        public static int[] NewArreglo(){
            Random newRand = new Random();
            return Enumerable.Range(0,20).Select(_=> newRand.Next(1,100)).ToArray();
        }
        public static (int sumaArreglo, double mediaAritmetica, int moda, double mediana) Operacion(int[] arreglo){
            
            int sumaArreglo = arreglo.Sum();
            double mediaAritmetica = arreglo.Average();
            var moda = arreglo.GroupBy(x => x)
                 .OrderByDescending(g => g.Count())
                 .Select(g => g.Key)
                 .First();
            var arregloOrdenado = arreglo.OrderBy(x => x).ToArray();            
            double mediana = (arregloOrdenado[arregloOrdenado.Length / 2 - 1] + arregloOrdenado[arregloOrdenado.Length / 2]) / 2.0;
            
            return (sumaArreglo, mediaAritmetica, moda, mediana);
        }
    }
}
