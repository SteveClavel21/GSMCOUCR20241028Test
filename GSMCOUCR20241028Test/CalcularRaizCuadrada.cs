namespace GSMCOUCR20241028Test
{
    public class CalcularRaizCuadradaclass
    {
        public double CalcularRaizCuadrada(double num)
        {
            double raiz = Math.Sqrt(num);
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(num), "No se puede calcular la raíz cuadrada de un número negativo.");
            }
            return raiz;
        }
    }
}
