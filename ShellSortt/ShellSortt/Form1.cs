using System;
using System.Linq;
using System.Windows.Forms;

namespace Shellsortt
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int tamaño = int.Parse(txtTamaño.Text);

                if (tamaño <= 0)
                {
                    MessageBox.Show("Ingresa un tamaño mayor a 0.");
                    return;
                }

                // Generar arreglo aleatorio
                int[] arreglo = new int[tamaño];
                for (int i = 0; i < tamaño; i++)
                    arreglo[i] = rnd.Next(1, 101); // números entre 1 y 100

                txtArreglo.Text = string.Join(", ", arreglo);

                // Guardamos temporalmente para ordenar después
                txtArreglo.Tag = arreglo;
            }
            catch
            {
                MessageBox.Show("Ingresa un tamaño válido (solo números enteros).");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (txtArreglo.Tag == null)
            {
                MessageBox.Show("Primero genera el arreglo.");
                return;
            }

            int[] arreglo = (int[])txtArreglo.Tag;

            ShellSort(arreglo);

            txtResultado.Text = string.Join(", ", arreglo);
        }

        // Shellsort
        private void ShellSort(int[] arr)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArreglo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

