using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassArbol;
using ClassNodo;

namespace Aweb
{
    public partial class index : System.Web.UI.Page
    {


        
       Arbol arbol1 = new Arbol();
        List<Arbol> listArbol = new List<Arbol>();

        protected void Page_Load(object sender, EventArgs e)
        {
           // Arbol arbol1 = new Arbol();
            arbol1.insertarNodo(10);
            arbol1.insertarNodo(5);
            arbol1.insertarNodo(15);
            arbol1.insertarNodo(3);
            arbol1.insertarNodo(7);
            arbol1.insertarNodo(12);
            arbol1.insertarNodo(20);
            Label1.Text = arbol1.inOrden();
            Boolean b = arbol1.eliminar(7);
            Label2.Text = arbol1.inOrden();
           /* if (arbol1.eliminar(7)==true)
            {
                Label1.Text = "El elemento fue eliminado exitosamente";
            }
            else {
                Label1.Text = "el elemento no se encuentra en el arbol";
            }*/
        }
        /*private void insertarRaiz(int ele)
        {
            arbol1.Raiz1 = new Nodo(ele);
            listArbol.Add(arbol1);
            Session["dato"] = listArbol[0];
            Label1.Text = listArbol[0].inOrden();
        }*/
       protected void Button1_Click(object sender, EventArgs e)
        {
            /*arbol1.insertarNodo(10);
            arbol1.insertarNodo(5);
            arbol1.insertarNodo(15);
            arbol1.insertarNodo(3);
            arbol1.insertarNodo(7);
            arbol1.insertarNodo(12);
            arbol1.insertarNodo(20);
            Nodo rpta = arbol1.obtenerNodoReemplazo(arbol1.Raiz1);
            Label1.Text = Convert.ToString( rpta.Elem);
           
           /* arbol1.insertarNodo(int.Parse(TextBox1.Text));
            listArbol.Add(arbol1);
            Session["dato"] = listArbol[0];
            Label1.Text = listArbol[0].inOrden();
            /*
             if(listaArbol.Count()==0){
               insertarRaiz(TextBox1.Text);
              } else
              {
              listArbol.Add((Arbol)Session["dato"]);
               listArbol[0].insertarNodo(int.Parse(TextBox1.Text));
               Label1.Text = listArbol[0].inOrden();
              }*/
             
             
        }
           
        protected void Button2_Click(object sender, EventArgs e)
        {/*
            listArbol.Add((Arbol)Session["dato"]);
            listArbol[0].insertarNodo(int.Parse(TextBox1.Text));
            Label1.Text = listArbol[0].inOrden();
         */
        }
       
            
        }


    }
