using System;
using System.IO;
using AutomatizarPruebasUnitarias;

class Test{
    static void Main(string[] args){
        
        Medias md = new Medias();
           /*  int[] vals = new int[] { 2, 4, 8};
            int[] geo = new int[] { 1, 2, 4, 8, 16, 32};
            
            
            Console.WriteLine( "Media: " + Medias.mediaAritmetica(vals));
            //Console.WriteLine( "Raíz: " + raizEnesima(12,3));    
            Console.WriteLine( "MediaGeométrica: " + md.mediaGeometrica(geo));*/

            
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
                for(int i = 0; i < texto.Length; i++) 
                {
                    string parametros = texto[i][2];//posicion 2 del array
                    string resultado = texto[i][3];
                    string metodo = texto[i][1];                 
                    double result =0;

                    bool success = double.TryParse(resultado, out result);
                    if(!success){
                        Console.WriteLine("Exception");
                    }
                    if(parametros == "NULL") 
                    {   //problema 06
                    
                        Console.WriteLine("No hay parámetros");
                    }
                    
                    string[] parametro = parametros.Split(' ');
                    int[] vals = new int[parametro.Length];
                    int nums = 0;
                    int valor =0;
                    for(int j = 0; j < parametro.Length; j++) 
                    {
                        bool succ = Int32.TryParse(parametro[j],out nums);
                        if(succ){valor = nums;}                      
                        // Console.WriteLine(valor);
                        //Console.WriteLine("["+ j + "]"+ valor);
                        //Console.WriteLine("["+i+ "]"+ valor);
                            vals[j] = valor;
                    }
                    
                    //Console.WriteLine(resultado);
                    
                    

                    //problema 05
                    if(metodo=="mediaAritmetica" && result==Medias.mediaAritmetica(vals))
                    {
                        //Console.WriteLine(Medias.mediaAritmetica(vals)); 
                        Console.WriteLine("Resultado Correcto ;)");
                    }
                    else if(metodo== "mediaAritmetica"){
                        //Console.WriteLine(Medias.mediaAritmetica(vals)); 
                        Console.WriteLine("Resultado Incorrecto :(");
                    }
                    if(metodo=="mediaGeometrica" && result== md.mediaGeometrica(vals))
                    {
                       // Console.WriteLine(md.mediaGeometrica(vals)); 
                        Console.WriteLine("Resultado Correcto ;)");
                    }
                    else if(metodo== "mediaGeometrica"){
                        //Console.WriteLine(md.mediaGeometrica(vals)); 
                        Console.WriteLine("Resultado Incorrecto :(");
                    }
                    if(metodo=="mediaArmonica"){
                        Medias.mediaArmonica(vals);
                    }
                    if(metodo=="mediaNoExiste"){
                        Console.WriteLine("pos no existe");
                    }
                
                    
                        

                }
            }        
        
 


    }

}