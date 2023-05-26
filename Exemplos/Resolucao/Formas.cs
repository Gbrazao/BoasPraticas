namespace BoasPraticas.Service.Resolucao
{
    public abstract class FormaGeometrica
    {
        public abstract int CalcularArea();
    }

    public class Retangulo : FormaGeometrica
    {
        public int Altura { get; set; }
        public int Largura { get; set; }

        public override int CalcularArea()
        {
            return Altura * Largura;
        }
    }

    public class Quadrado : FormaGeometrica
    {
        public int Lado { get; set; }

        public override int CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
