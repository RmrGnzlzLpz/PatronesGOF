namespace Decorador
{
    public class DescuentoVIP : Decorador
    {
        public DescuentoVIP(IHospedaje hospedaje) : base(hospedaje)
        {
            Hospedaje.Descripcion += " (Descuento VIP)";
            Hospedaje.Costo *= 0.85;
        }
    }
}
