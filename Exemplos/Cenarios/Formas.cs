namespace BoasPraticas.Service.Cenarios
{
    public class Retangulo
    {
        public virtual int Altura { get; set; }
        public virtual int Largura { get; set; }

        public int CalcularArea()
        {
            return Altura * Largura;
        }
    }

    public class Quadrado : Retangulo
    {
        public override int Altura
        {
            get { return base.Altura; }
            set
            {
                base.Altura = value;
                base.Largura = value;
            }
        }

        public override int Largura
        {
            get { return base.Largura; }
            set
            {
                base.Altura = value;
                base.Largura = value;
            }
        }
    }



}
