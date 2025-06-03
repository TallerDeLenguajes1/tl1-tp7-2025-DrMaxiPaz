namespace Personal
{
    public enum EstadoCivil
        {
            Soltero,
            Casado
        }
        public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
    public class Empleado(string nombre, string apellido, DateTime fechaNacimiento, EstadoCivil estado, Cargo posicion, DateTime fechaIngreso, double sueldo)
    {
        private string nombre = nombre;
        private string apellido = apellido;
        private DateTime fechaNacimiento = fechaNacimiento;

        private EstadoCivil estado = estado;
        private DateTime fechaIngreso = fechaIngreso;
        private double sueldo = sueldo;

        private Cargo posicion = posicion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public EstadoCivil Estado { get => estado; set => estado = value; }
        public Cargo Posicion { get => posicion; set => posicion = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public int Antiguedad()
        {
            return DateTime.Now.Year - fechaIngreso.Year;
        }

        public int Edad()
        {
            return DateTime.Now.Year - fechaNacimiento.Year;
        }
        public int Jubilacion()
        {
            return 65 - Edad();
        }

        public double Salario()
        {
            double adicional = sueldo * 0.01;
            if (Antiguedad() > 20)
            {
                adicional *= 0.25;
            }
            else
            {
                adicional *= Antiguedad();
            }

            switch (posicion)
            {
                case Cargo.Ingeniero:
                case Cargo.Especialista:
                    adicional *= 1.5;
                    break;
                default:
                    break;
            }
            if (estado == EstadoCivil.Casado)
            {
                adicional += 150000;
            }
            return Sueldo += adicional;
        }


    }
}