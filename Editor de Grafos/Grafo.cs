using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Editor_de_Grafos
{
   
    public class Grafo : GrafoBase, iGrafo
    {
        Random aleatorio = new Random();
        private bool[] visitado;
        private bool[] visitado2;

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

        // LARGURA

        public void largura(int v)
        {
            visitado = new bool[getN()];

            Fila fila = new Fila(getN());

            fila.enfileirar(v);

            visitado[v] = true;

            
            while (!fila.vazia()){

                int d = fila.desenfileirar();

                for (int i = 0; i < getN(); i++)
			    {
                    for (int j = 0; j < getN(); j++)
                    {
                        Aresta a = getAresta(i, j);

                        if (getN() != 0 && !visitado[i])
                        {                          
                            visitado[i] = true;
                            fila.enfileirar(i);
                            getVertice(i).setCor(Color.Yellow);
                                                       
                        }
                        if(a != null)
                        {
                            a.setCor(Color.Red);
                        }
                                            
                    }
                   
			    }
            }
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

        // PROFUNDIDADE

        public void profundidade(int v)
        {
            LimparProfundidade();

            visitado2[v] = true;

            for (int i = 0; i < getN(); i++)
            {
                // se I é adjacente a V e I ainda não foi visitado
                if (getN() != 0 && !visitado[i])
                {
                    // chamada recursiva (vá para o vértice I)
                    profundidade(i);
                    getVertice(i).setCor(Color.Yellow);
                    
                }
            }

        }

        public void LimparProfundidade()
        {
            visitado2 = new bool[getN()];

            for (int i = 0; i < getN(); i++)
            {
                if(getN() != 0 && visitado2[i] == true)
                {
                    visitado2[i] = false;
                }
            }
        }
    }
}
