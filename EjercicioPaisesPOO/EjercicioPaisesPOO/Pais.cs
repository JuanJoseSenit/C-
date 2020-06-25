using System;
namespace EjercicioPaisesPOO
{
    class Pais
    {
        private string nombre;
        private int poblacion;
        private int area;

        public Pais(string nombre, int poblacion, int area)
        {
            this.nombre = nombre;
            this.poblacion = poblacion;
            this.area = area;
        }
        public bool masGrandeQue(Pais otroPais)
        {
            if (this.poblacion > otroPais.getPoblacion()) return true;
            else return false;
        }
        public int getPoblacion()
        {
            return this.poblacion;
        }

        public int DesnsidadPoblacion()
        {
            return (this.poblacion / this.area);
        }
        public void toString()
        {
            Console.WriteLine($"La densidad de población de {this.nombre} es {this.DesnsidadPoblacion()}");
        }
    }
}