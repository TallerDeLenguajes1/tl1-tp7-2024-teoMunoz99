namespace EspacioEmpleado
{
    // Declaración del enum para los cargos
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    //Clase
    class Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
    {
        //Atributos
        public string Nombre = nombre;
        public string Apellido = apellido;
        public DateTime FechaNacimiento = fechaNacimiento;
        public char EstadoCivil = estadoCivil;
        public DateTime FechaIngresoEmpresa = fechaIngreso;
        public double SueldoBasico = sueldoBasico;
        public Cargos Cargo = cargo;

        //Metodos
        public void CalularAntiguedad(){
            //Guardo la fecha actual
            DateTime fechaActual = DateTime.Now;
            //Muestro la antiguedad
            Console.WriteLine(fechaActual.Year - FechaIngresoEmpresa.Year);
        }

        public void CalcularEdad(){
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine(fechaActual.Year - FechaNacimiento.Year);
        }

        public void TiempoParaJubilarse(){
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine(65-(fechaActual.Year - FechaNacimiento.Year));
        }
    }
}