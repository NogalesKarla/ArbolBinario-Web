using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassNodo;

namespace ClassArbol
{
    public class Arbol
    {
        //ATRIBUTOS
        Nodo Raiz;

        public Nodo Raiz1
        {
            get { return Raiz; }
            set { Raiz = value; }
        }
        int cantNodo;

        //SETTERS GETTERS
        public int CantNodo
        {
            get { return cantNodo; }
            set { cantNodo = value; }
        }

        //CONSTRUCTOR
        public Arbol()
        {
            this.Raiz = null;
            cantNodo = 0;
        }
        public Boolean vacio()
        {
            return this.Raiz == null;
        }

        //METODOS
        //ITERATIVO
        public void insertarNodo(int x)
        {
            Nodo nuevoNodo = new Nodo(x);
            if (Raiz == null)
            {
                Raiz = nuevoNodo;
                cantNodo++;
            }
            else
            {
                Nodo aux = this.Raiz;
                Nodo padre;
                while (true)
                {
                    padre = aux;
                    if (x < aux.Elem)
                    {
                        aux = aux.izq;
                        if (aux == null)
                        {
                            padre.izq = nuevoNodo;
                            cantNodo++;
                            return;
                        }
                    }
                    else
                    {
                        aux = aux.der;
                        if (aux == null)
                        {
                            padre.der = nuevoNodo;
                            cantNodo++;
                            return;
                        }
                    }
                }
            }
        }

        //RECURSIVO
        public void insertarNodoR(int x)
        {
            this.Raiz = insertarNodoR(this.Raiz, x);
        }
        private Nodo insertarNodoR(Nodo p, int x)
        {
            if (p == null) return new Nodo(x);
            if (x < p.Elem)
            {
                p.izq = insertarNodoR(p.izq, x);
            }
            else
            {
                p.der = insertarNodoR(p.der, x);
            }
            return p;
        }

        // MOSTRAR ELEMENTOS DEL ARBOL IN ORDEN
        public string inOrden()
        {
            string s = inOrden(this.Raiz);
            return s;
        }
        private string inOrden(Nodo p)
        {
            string s = "";
            if (p == null)
            {
                return s;
            }
            s = s + inOrden(p.izq) + "  " + p.Elem + "  " + inOrden(p.der);

            return s;
        }

        // MOSTRAR ELEMENTOS DEL ARBOL EN PRE ORDEN
        public string preOrden()
        {
            string s = preOrden(this.Raiz);
            return s;
        }
        private string preOrden(Nodo p)
        {
            string s = "";
            if (p == null)
            {
                return s;
            }
            s = s + p.Elem + "  " + preOrden(p.izq) + "  " + preOrden(p.der);

            return s;
        }

        // MOSTRAR ELEMENTOS DEL ARBOL EN POST ORDEN
        public string postOrden()
        {
            string s = postOrden(this.Raiz);
            return s;
        }
        private string postOrden(Nodo p)
        {
            string s = "";
            if (p == null)
            {
                return s;
            }
            s = s + postOrden(p.izq) + "  " + postOrden(p.der) + "  " + p.Elem;

            return s;
        }

        // mostrar elementos de la rama izq
        public string imprimirRamaIzq()
        {
            return "Los elementos de la rama izquierda son: " + imprimirRamaIzq(this.Raiz.izq);
        }

        private string imprimirRamaIzq(Nodo p)
        {
            string s = "";
            if (p == null)
            {
                return s;
            }
            else
            {
                this.inOrden();
                s = s + imprimirRamaIzq(p.izq) + "  " + p.Elem + "  " + imprimirRamaIzq(p.der);

            }
            return s;
        }

        // mostrar todas las hojas

        public string imprimirHojas()
        {
            return "Las hojas del arbol son: " + imprimirHojas(this.Raiz);
        }

        private string imprimirHojas(Nodo p)
        {
            string s = "";
            if (p == null)
            {
                return s;
            }
            else
            {
                if (p.izq == null && p.der == null)
                {
                    s = s + "  " + imprimirHojas(p.izq) + "  " + p.Elem + "  " + imprimirHojas(p.der);
                }
                else
                {
                    s = s + imprimirHojas(p.izq) + imprimirHojas(p.der);
                }
            }
            return s;
        }

        //imprimir todos los hijos derechos

        public string imprimirHijosDer()
        {
            return "Los hijos derechos son:" + imprimirHijosDer(this.Raiz);
        }

        private string imprimirHijosDer(Nodo p)
        {
            string s = "";
            if (p == null)
            {
                return s;
            }
            else
            {
                if (p.der != null)
                {
                    s = s + "  " + imprimirHijosDer(p.izq) + "  " + p.der.Elem + "  " + imprimirHijosDer(p.der);
                }
                else
                {
                    s = s + imprimirHijosDer(p.izq) + imprimirHijosDer(p.der);
                }
            }
            return s;
        }

        ///Mostrar elementos por nivel

        public string imprimirPorNivel(int n)
        {
            return "los elementos del nivel" + " " + n + " son:" + imprimirPorNivel(this.Raiz, 0, n);
        }

        private string imprimirPorNivel(Nodo p, int nivel, int n)
        {
            string s = "";
            if (p == null)
            {
                return s;
            }
            else
            {
                if (nivel == n)
                {
                    s = s + imprimirPorNivel(p.izq, nivel + 1, n) + "  " + p.Elem + "  " + imprimirPorNivel(p.der, nivel + 1, n);
                }
                else
                {
                    s = s + imprimirPorNivel(p.izq, nivel + 1, n) + imprimirPorNivel(p.der, nivel + 1, n);
                }
            }
            return s;
        }

        // Mostrar todas las ramas Espejo

        public string imprimirEspejo()
        {
            return "las ramas espejo son :" + imprimirEspejo(this.Raiz);
        }

        private string imprimirEspejo(Nodo p)
        {
            string s = "";
            if (p == null)
            {
                return s;
            }
            else
            {

            } return s;
        }

        /* Arbol arbolEspejo(Arbol arbol)
         {
             Arbol temp;

             if (arbol != null)
             {
                 temp = arbol.izq;
                 arbol->izq = arbolEspejo(arbol->der);
                 arbol->der = arbolEspejo(temp);
             }
             return arbol;
         }*/
        public string busqueda(int ele)
        {
            if (busqueda(this.Raiz, ele))
            {
                return "El elemento " + ele + " se encuentra en el arbol";
            } return "El elemento " + ele + " no se encuentra";
        }
        private Boolean busqueda(Nodo p, int ele)
        {
            if (p != null)
            {
                if (p.Elem == ele) return true;
                Boolean ok1 = busqueda(p.izq, ele);
                Boolean ok2 = busqueda(p.der, ele);
                if (ok1 || ok2) return true;
            }
            return false;
        }

        public Nodo obtenerNodoReemplazo(Nodo nodoReemplazo)
        {
            Nodo reemplazarPadre = nodoReemplazo;
            Nodo reemplazo = nodoReemplazo;
            Nodo auxiliar = nodoReemplazo.der;
            while (auxiliar != null) {
                reemplazarPadre = reemplazo;
                reemplazo = auxiliar;
                auxiliar = auxiliar.izq;
            }
            if (reemplazo != nodoReemplazo.der) {
                reemplazarPadre.izq = reemplazarPadre;
                reemplazo.der = nodoReemplazo.der;
            }
            return reemplazo;
        }

        public Boolean eliminar(int d) {
            Nodo auxiliar = Raiz;
            Nodo padre = Raiz;
            Boolean esHijoIzq = true;
            while (auxiliar.Elem != d) {
                padre = auxiliar;
                if (d < auxiliar.Elem)
                {
                    esHijoIzq = true;
                    auxiliar = auxiliar.izq;
                }
                else {
                    esHijoIzq = false;
                    auxiliar = auxiliar.der;
                }
                if (auxiliar == null) {
                    return false;
                }
            }//fin del while

            if (auxiliar.izq == null  && auxiliar.der == null) {
                if (esHijoIzq)
                {
                    padre.izq = null;
                }
                else {
                    padre.der = null;
                }
            }
            else if (auxiliar.der == null) {
                if (esHijoIzq)
                {
                    padre.izq = auxiliar.izq;
                }
                else
                {
                    padre.der = auxiliar.izq;
                }
            }
            else if (auxiliar.izq == null)
            {
                if (esHijoIzq)
                {
                    padre.izq = auxiliar.der;
                }
                else
                {
                    padre.der = auxiliar.izq;
                }
            }
            else {
                Nodo reemplazo = obtenerNodoReemplazo(auxiliar);
                if (esHijoIzq)
                {
                    padre.izq = reemplazo;
                }
                else {
                    padre.der = reemplazo;
                }
                reemplazo.izq = auxiliar.izq;
            }
            return true;
         }
    
    
    
    
    
    
    }
}
