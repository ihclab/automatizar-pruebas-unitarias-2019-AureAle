using System;
using System.IO;
using AutomatizarPruebasUnitarias;

 class Test2{
        
        const int ID_LINEA = 0;
        const int METODO = 1;
        const int INPUT = 2;
        const int OUTPUT = 3;
        const string MEDIA_ARITMETICA = "mediaAritmetica";
        const string MEDIA_GEOMETRICA = "mediaGeometrica";
        const string MEDIA_ARMONICA = "mediaArmonica";

    static void Main(string[] args){


            using (StreamReader sr = new StreamReader("C://Users//gomez//Desktop//automatizar-pruebas-unitarias-2019-AureAle//CasosPrueba.txt"))
            {
                string linea;
                //problema 02
                Console.WriteLine("ID     "+ "Resultado     "+ "Método    "+ "      Detalles    ");
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] lineaSeparada = separaLinea(linea);
                    procesaLinea(lineaSeparada);
                   double  outputEsperado = OutputEsperado(lineaSeparada[OUTPUT]);
                   double outputCalculado = OutputCalculado(lineaSeparada[METODO],lineaSeparada[INPUT]) ;
                   
                   
                   Console.Write("\n" + lineaSeparada[ID_LINEA]+ "   " ) ;
                   imprimeResultadoMedia(lineaSeparada[INPUT], lineaSeparada[METODO], lineaSeparada[OUTPUT]);
                   Console.Write("    "  + lineaSeparada[METODO] + "  "+  "Calculado =  "+ outputCalculado + "   "
                   +"Esperado = " + outputEsperado );
                   

                }
                   
            }        
    }

private static string[] separaLinea(string linea) {//problema 03
      return linea.Split(':');
}

private static int[] parseaInput(string input) {//problema 04




         string[] parametro = input.Split(' ');
            int[] vals = new int[parametro.Length];
            int nums = 0;
            int valor =0;
                for(int j = 0; j < parametro.Length; j++)
                {
                    bool succ = Int32.TryParse(parametro[j],out nums);
                    if(succ){
                        valor = nums;
                        }
                     else{
                        //throw new System.FormatException("Parámetro incorrecto");
                         validarNullEntradas(input);
                     }
                    vals[j] = valor;
                }

    return vals;

}
private static double parseaOutput(string output){//problema 04
    
    double calculado;
    double result=0;
    bool succ = double.TryParse(output, out calculado);
      if(succ){
          result = calculado;
      }
      /* else{
          throw new System.FormatException("Parámetro incorrecto");
      }   */
    
    return result;
}

private static void validarNullEntradas(string entrada){

    if(entrada=="NULL"|| entrada== ""|| entrada=="null"){
        Console.Write(entrada);
    }
}
private static void procesaLinea(string[] lineaSeparada) {
        parseaInput(lineaSeparada[INPUT]);
        parseaOutput(lineaSeparada[OUTPUT]);
}

private static double OutputEsperado(string esperado){
       double outputEsperado = parseaOutput(esperado);
        return outputEsperado;
    }
private static double OutputCalculado(string tipoMedia,string vals){
    Medias md = new Medias();
    
    double result = 0;
        
        switch(tipoMedia) {
                    case MEDIA_ARITMETICA:
                        result = Medias.mediaAritmetica(parseaInput(vals));      
                        break;
                    case MEDIA_GEOMETRICA:
                        result = md.mediaGeometrica(parseaInput(vals));                        
                        break;
                 
        }
        return result;
}
    

private static void imprimeResultadoMedia(string input, string tipoMedia,  string resultadoEsperado) {
                switch(tipoMedia) {
                    case MEDIA_ARITMETICA:
                        imprimeResultadoMediaAritmetica(input,resultadoEsperado);
                        break;
                    case MEDIA_GEOMETRICA:
                        imprimeResultadoMediGeometrica(input, resultadoEsperado);
                        break;
                    case MEDIA_ARMONICA:
                        imprimeResultadoArmonica(input, resultadoEsperado);                      
                        break;

                }
            }

private static void imprimeResultadoMediaAritmetica(string input, string resultadoEsperado) {
        double resultadoObtenido = Medias.mediaAritmetica(parseaInput(input)); 
    if (resultadoObtenido.Equals(parseaOutput(resultadoEsperado))) {
        imprimeResultadoCorrecto();
    } else {
        imprimeResultadoIncorrecto();
    }
   
}

private static void imprimeResultadoMediGeometrica(string input, string resultadoEsperado) {
    Medias md = new Medias();
    double resultadoObtenido = md.mediaGeometrica(parseaInput(resultadoEsperado)); 
    if (resultadoObtenido.Equals(parseaOutput(resultadoEsperado))) {
        imprimeResultadoCorrecto();
    } else {
        imprimeResultadoIncorrecto();
    }
    
}
private static double imprimeResultadoArmonica(string input, string resultadoEsperado) {
    double resultadoObtenido = Medias.mediaArmonica(parseaInput(resultadoEsperado)); 
   return resultadoObtenido;
}

private static void imprimeResultadoIncorrecto() {//problema 05 y actividad 01
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("*Falla*");
    Console.ResetColor();
}

private static void imprimeResultadoCorrecto() {//problema 05 y actividad 01
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Éxito");
    Console.ResetColor();
}


}

