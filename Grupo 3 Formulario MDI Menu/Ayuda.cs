using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Grupo_3_Formulario_MDI_Menu
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Ayuda_Load(object sender, EventArgs e)
        {
            //Para abrir un archivo para lectura, crear una nueva instancia de un objeto "Archivo" 
            //y pasamos la ruta en el constructor de la manera siguiente:
            StreamReader Archivo = new StreamReader("C:\\Users\\wmedr\\Downloads\\Grupo-3-Formulario-MDI-Menu\\ayuda.txt");

            //Debe tener una variable de cadena en la que se va a almacenar cada línea del archivo 
            //a medida que procesa. 
            string Linea = "";

            //Creamos el objeto "Contenido" para la clase ArrayList, esto almacena el contenido del
            //Archivo de texto en un arreglo llamado --Contenido--.
            ArrayList Contenido = new ArrayList();

            //Existen varios métodos para leer el archivo, incluido el método ReadToEnd que 
            //lee todo el archivo a la vez. Sin embargo, en este ejemplo, puede utilizar el 
            //método ReadLine para poner en la línea de un archivo a la vez. 
            while (Linea != null)
            {
                Linea = Archivo.ReadLine();
                if (Linea != null)
                    Contenido.Add(Linea);
                ayu.Text = Linea;
            }
            Archivo.Close();

            //Debemos inicializar el contenido del control "texto" de modo que esté vacío
            //asignandole doble comilla
            ayu.Text = "";

            //Utilice un bucle For Each para escribir el contenido de su lista de matrices
            foreach (string Linea_mostrar in Contenido)
            {
                //Usamos Strings.Chr(13) para salto de linea, de modo que agrega una luego la otra...;
                ayu.Text = ayu.Text + Linea_mostrar + "\r\n";
            }
        }


    }
}
