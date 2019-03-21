using System;
using System.IO;
using AutomatizarPruebasUnitarias;

class Test{
    static void Main(string[] args){

           /*  int[] vals = new int[] { 2, 4, 8};
            int[] geo = new int[] { 1, 2, 4, 8, 16, 32};
            
            Medias md = new Medias();
            Console.WriteLine( "Media: " + Medias.mediaAritmetica(vals));
            //Console.WriteLine( "Raíz: " + raizEnesima(12,3));    
            Console.WriteLine( "MediaGeométrica: " + md.mediaGeometrica(geo));*/

        try {
            
            using (StreamReader sr = new StreamReader("C://Users//gomez//Desktop//automatizar-pruebas-unitarias-2019-AureAle//CasosPrueba.txt")) 
            {
                string text;
                int lineas = 0;
                string[][] texto = new string[13][];
                //problema 02
                while ((text = sr.ReadLine()) != null) 
                {
                    //problema 03
                    string[] partes = text.Split(':');
                    texto[lineas]= partes;
                    lineas++;

                    //Console.WriteLine(text);
                    //Console.WriteLine(partes[0]);
                    
                }
                //problema 04
                //ints 
                for(int i = 0; i < texto.Length; i++) {
                    string parametros = texto[i][2];//posicion 2 del array
                
                        string[] parametro = parametros.Split(' ');
                        for(int j = 0; j < parametro.Length; j++) {
                            int valor = Int32.Parse(parametro[j]);
                            Console.WriteLine(valor);
                        }
                }
            }
        
        }catch (Exception e) 
            {
                
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            } 

    }
}