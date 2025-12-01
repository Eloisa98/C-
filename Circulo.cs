
using System;

namespace ExercíciosCSharp
{
    public class Circulo
    {
        public double Raio;  

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}
