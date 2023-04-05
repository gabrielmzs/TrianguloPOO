using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloPOO {
    internal class Triangulo {

        public double lado1, lado2, lado3;
        public string mensagem;

        public string VerificarLados() {

            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2) {

                if (lado1 == lado2 && lado2 == lado3) {
                    mensagem = "O triângulo é equilátero.";
                } else 
                    {
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) {
                        mensagem = "O triângulo é isóscele.";
                    } else {
                        mensagem = "O triângulo é escaleno.";
                    }
                }
            } else {
                mensagem = "Os comprimentos informados não formam um triângulo.";
            }

            return mensagem;
        }


    }
}

