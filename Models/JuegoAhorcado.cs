public static class JuegoAhorcado
{
    public static string PalabraSecreta;
    public static int Intentos;
    public static bool JuegoFinalizado;
    public static bool Gano;
    public static string PalabraAdivinada;
    public static string tablero = "" ;



    public static void iniciarGrupo()
    {
        PalabraSecreta =   "majestuoso";
        PalabraAdivinada = "__________";
        Intentos = 0;
        JuegoFinalizado = false;
        Gano = false;
        
        foreach (char item in PalabraSecreta)
        {
            tablero = tablero + "_";
            
        }


    }

    public static List<int> posicion(string letra, string palabra)
    {
        List<int> posiciones = new List<int>();

        char letraChar = letra[0];

        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == letraChar)
            {
                posiciones.Add(i);
            }
        }

        return posiciones;
    }

    
    public static int arriesgoLetra(string Letra)
    {
       Intentos++;
        if(Letra.Length == 1 && Letra != null && PalabraAdivinada.Contains(Letra) == false)
        {
            
            if(PalabraSecreta.Contains(Letra)){

                
                List<int> posiciones = posicion(Letra, PalabraSecreta);
                tablero = "";
                for (int i=0;i<PalabraSecreta.Length;i++)
                {
                    if (posiciones.Contains(i))
                    {
                        tablero = tablero + Letra;
                    }
                    else
                    {
                        tablero = tablero + PalabraAdivinada[i];
                    }
                }
                PalabraAdivinada = tablero;
             
                return 1;
            }
            else{

                return 2;

            }
            
        }else 
        {
            return 3;
        }
    
        
       
    }

    public static int arriesgoPalabra(string Palabra)
    {
        if(Palabra==PalabraSecreta)
        {
            PalabraAdivinada=PalabraSecreta;
            return 4;
            
        }else{return 5;}
    }
    
    

}