using System;
using System.Collections.Generic;
using System.Text;

namespace Editor_de_Grafos
{
    interface iGrafo
    {
        bool isEuleriano(); // ok
        bool isUnicursal(); // ok
        string paresOrdenados(); // ok
        void completarGrafo(); // ok

        void profundidade(int v);
        void largura(int v); // ok
        void AGM(int v);
        void caminhoMinimo(int i, int j);
        void numeroCromatico();
    }
}
