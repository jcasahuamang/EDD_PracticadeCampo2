using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo2
{
    public class ListaProductos
    {
        NodoProducto nuevo, ptr, ptr1, raiz1, raiz2;

        public ListaProductos() 
        {
            raiz1 = raiz2 = null;
        }

        public void Insertar(Productos dato)
        {
            nuevo = new NodoProducto();
            nuevo.info = dato;
            if (raiz1 == null)
            {
                nuevo.sig = nuevo;
                nuevo.ant = nuevo;
                raiz1 = raiz2 = nuevo;
            }
            else
            {
                nuevo.ant = raiz2;
                nuevo.sig = raiz1;

                raiz2.sig = nuevo;
                raiz1.ant = nuevo;

                raiz2 = nuevo;

            }
        }

        
        public void Listar() //Responsable: Yeni Lloclle
        {
        }
        public void Buscar(int IdProducto) //Responsable: Bryan Becerra
        {
        }

        public void Eliminar(int IdProducto)//Responsable: Bryan Benavides
        {
        }
        public void Ordenar()//Responsable: Alessandra Ventura
        {
        }
    }
    }
