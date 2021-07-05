using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using OpenQA.Selenium.Interactions;

namespace Registros
{
    class Class_Matriz
    {
        int[,] matriz = new int[12, 12];
        int fila, columna, i, j;

        public void tablademultiplicar (TextBox filas, TextBox columnas)
        {
            fila = int.Parse(filas.Text);
            columna = int.Parse(columnas.Text);

            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    matriz[i, j] = int.Parse(Interaction.ReferenceEquals("Dato en i", "Dato en j", "", fila, columna));
                }
            }
        }
    }
}
