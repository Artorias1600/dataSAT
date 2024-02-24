class Program
{
    static void Main(string[] args)
    {
        Contribuyente contribuyente1 = new Contribuyente("1234567-8", "Danilo sosa", "3ra Calle, Zona 1", "12345678", "Danilo@example.com");
        Contribuyente contribuyente2 = new Contribuyente("2345678-9", "Maria jose", "12da Avenida, Zona 11", "23456789", "mariajs@example.com");
        Contribuyente contribuyente3 = new Contribuyente("3456789-0", "Carlos marin", "4ta calle, Zona 6", "34567890", "carlosrm@example.com");
        Contribuyente contribuyente4 = new Contribuyente("4567890-1", "Ana lucia", "4ta Avenida, Zona 1", "45678901", "analu@example.com");
        Contribuyente contribuyente5 = new Contribuyente("5678901-2", "Luis maguil", "4ta Calle, Zona 10", "56789012", "luismag@example.com");

        contribuyente1.ImprimirDatos();
        contribuyente2.ImprimirDatos();
        contribuyente3.ImprimirDatos();
        contribuyente4.ImprimirDatos();
        contribuyente5.ImprimirDatos();
    }
}
