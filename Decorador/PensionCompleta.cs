namespace Decorador
{
    public class PensionCompleta : Decorador
    {
        public PensionCompleta(IHospedaje hospedaje) : base(hospedaje)
        {
            Hospedaje.Descripcion += " (Pensión completa)";
            Hospedaje.Costo += 65000;
        }
    }
}
