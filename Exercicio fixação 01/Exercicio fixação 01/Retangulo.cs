﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_fixação_01
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return (Largura * Altura);
        }
        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura,2) + Math.Pow(Largura, 2));
        }
    }
}
