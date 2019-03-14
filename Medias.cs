using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizarPruebasUnitarias {
    
    class Medias {

        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica(params int[] vals) {
            double suma=0;
            double media = 0; 

            for (int i=0;i<vals.Lenght();i++){
                suma=suma+vals[i];
            }
            media=suma/vals.Lenght();
            return media;
        }

        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n) { 
            double raizEnesima = Math.Pow(x,n);
            
            return raizEnesima;
        }

        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) {
            double mediaGeometrica = 0;
            double producto =0;
            for (int i=0;i<vals.Lenght();i++){
                producto=producto*vals[i];
            }
            mediaGeometrica= Math.Pow(producto,vals.Lenght());
            return mediaGeometrica;
         }

        /**
         * Este método no está implementado
         */
        public static double mediaArmonica(params int[] vals) { 

        }
    }
}