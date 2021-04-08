using System;
using System.Collections.Generic;
using System.Text;

namespace Editor_de_Grafos
{
    public class Grafo : GrafoBase, iGrafo
    {
        private bool[] visitado;

        public void AGM(int v)
        {

        }

        public void caminhoMinimo(int i, int j)
        {

        }

        public void completarGrafo()
        {

        }

        // IS EULERIANO

        public bool isEuleriano()
        {
            int i;
            for (i = 0; i < getN(); i++)
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
