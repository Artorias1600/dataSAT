using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contribuyente
{
    public string Nit { get; set; }
    public string Nombre { get; set; }
    public string DireccionFiscal { get; set; }
    public string Telefono { get; set; }
    public string CorreoElectronico { get; set; }

    public Contribuyente(string nit, string nombre, string direccionFiscal, string telefono, string correoElectronico)
    {
        Nit = nit;
        Nombre = nombre;
        DireccionFiscal = direccionFiscal;
        Telefono = telefono;
        CorreoElectronico = correoElectronico;
    }

    public void ImprimirDatos()
    {
        Console.WriteLine($"Nit: {Nit}, Nombre: {Nombre}, Teléfono: {Telefono}, Correo Electrónico: {CorreoElectronico}");
    }
}