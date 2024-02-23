class Program
{
    static void Main(string[] args)
    {
        Contribuyente contribuyente1 = new Contribuyente("1234567-8", "Juan Perez", "1ra Calle, Zona 1", "12345678", "juanperez@example.com");
        Contribuyente contribuyente2 = new Contribuyente("2345678-9", "Maria Lopez", "2da Avenida, Zona 2", "23456789", "marialopez@example.com");
        Contribuyente contribuyente3 = new Contribuyente("3456789-0", "Carlos Ramirez", "3ra Callejón, Zona 3", "34567890", "carlosramirez@example.com");
        Contribuyente contribuyente4 = new Contribuyente("4567890-1", "Ana Fernández", "4ta Avenida, Zona 4", "45678901", "anafernandez@example.com");
        Contribuyente contribuyente5 = new Contribuyente("5678901-2", "Luis Méndez", "5ta Calle, Zona 5", "56789012", "luismendez@example.com");

        contribuyente1.ImprimirDatos();
        contribuyente2.ImprimirDatos();
        contribuyente3.ImprimirDatos();
        contribuyente4.ImprimirDatos();
        contribuyente5.ImprimirDatos();
    }
}
