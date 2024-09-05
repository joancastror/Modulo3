/*namespace Geometria
{
    public class Punto
    {
        private double x;
        private double y;

        // Método para cargar los valores de x e y
        public void CargarValores()
        {
            try
            {
                Console.Write("Ingrese el valor de x: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el valor de y: ");
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }

        // Método para determinar e imprimir el cuadrante en el que se encuentra el punto
        public void ImprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el primer cuadrante.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el segundo cuadrante.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el tercer cuadrante.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el cuarto cuadrante.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("El punto se encuentra sobre el eje Y.");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("El punto se encuentra sobre el eje X.");
            }
            else
            {
                Console.WriteLine("El punto se encuentra en el origen (0,0).");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto();
            punto.CargarValores();
            punto.ImprimirCuadrante();
        }
    }
}
*/