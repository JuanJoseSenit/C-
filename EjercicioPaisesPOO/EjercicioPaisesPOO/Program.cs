using System;
namespace EjercicioPaisesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais España=new Pais("España",46770000,504645);
            Pais Francia=new Pais("Francia",66030000,640679);

            España.toString();
            Francia.toString();
            Console.WriteLine($"España es más grande que Francia?: {España.masGrandeQue(Francia)}");
            Console.WriteLine($"Francia es más grande que España?: {Francia.masGrandeQue(España)}");
        }
    }
   /* class Pais
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
    }*/
    
}

