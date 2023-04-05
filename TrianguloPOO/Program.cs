namespace TrianguloPOO {
    internal class Program {
        static void Main(string[] args) {
            Triangulo triangulo= new Triangulo();
            Console.WriteLine("Informe o lado 1: ");
            triangulo.lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado 2: ");
            triangulo.lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado 3: ");
            triangulo.lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine(triangulo.VerificarLados());
        }
    }
}