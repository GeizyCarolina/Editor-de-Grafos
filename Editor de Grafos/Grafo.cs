using System;
using System.Collections.Generic;
using System.Text;

namespace Editor_de_Grafos
{
   
    public class Grafo : GrafoBase, iGrafo
    {
        Random aleatorio = new Random();
        private bool[] visitado;

        public void AGM(int v)
        {

        }

        public void caminhoMinimo(int i, int j)
        {

        }

        public void completarGrafo()
        {
            for (int i = 0; i < getN(); i++)
            {
                for (int j = 0; j < getN(); j++)
                {
                    if (getN() != 0)
                    {
                        setAresta(i, j, 1);
                        
                        if (pesosAleatorios == true)
                        {
                            int rand = aleatorio.Next(1, 20);
                            setAresta(i, j, rand);

                        }
                    }
                    
                }
            }
        }

        // IS EULERIANO

        public bool isEuleriano()
        {
            
            for (int i = 0; i < getN(); i++)
            {
                if (grau(i) % 2 != 0)
                    return false;
            }
            if (getN() != 0)
                return true;
            else
                return false;
        }

        // IS UNICURSAL

        public bool isUnicursal()
        {
            int contimpar = 0;

            for (int i = 0; i < getN(); i++)
            {
                if (grau(i) % 2 != 0)
                    contimpar++;
            }

            if(contimpar == 2) 
            {
                return true;
            }
              
            else
              return false;
            
           
        }

        public void largura(int v)
        {

        }

        public void numeroCromatico()
        {

        }

        // PARES ORDENADOS
        public String paresOrdenados()
        {
            string msg = "E{ ";

            for (int i = 0; i < getN(); i++)
            {
                for (int j = 0; j < getN(); j++)
                {
                    if (getN() != 0)
                    {
                        msg += ("(" + i + "," + j + ")");
                    }                
                }
            }
            msg += " }";
            return msg;
        }
        public void profundidade(int v)
        {

        }
    }
}
