using System;
using System.IO;
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

            for (int i=0;i<vals.Length;i++){
                suma=suma+vals[i];
            }
            media=suma/vals.Length;
            return media;
        }

        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, double n) { 
            
            double raizEnesima = Math.Pow(x,1/n);
            
            return raizEnesima;
        }

        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public  double mediaGeometrica(params int[] vals) {
           
            double producto =1;
            double size = vals.Length;

            for (int i=0;i<vals.Length;i++){
               producto = producto * vals[i];
            }
            
            double mediaGeometrica= raizEnesima(producto,size); 
            return mediaGeometrica;
         }

        /**
         * Este método no está implementado
         */
        public static double mediaArmonica(params int[] vals) { 
        return 0;
        }
    }
    
}