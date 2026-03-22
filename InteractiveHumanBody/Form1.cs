//By: Carlos David Ramírez Santiago

//Módulo de aplicación de escritorio que permite a los usuarios seleccionar regiones del cuerpo a través de un diagrama interactivo del cuerpo humano mediante el mapeo de colores de píxeles.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace InteractiveHumanBody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            imagenDefault = LoadPicture.Image; //Se guarda la imagen por defaul que contiene el componente para cargar imagenes, esto para el boton limpiar y quitar la imagen cargada por el usuario
        }

        string inCoordenadas; //Coordenadas del clic del mouse
        int imageTest = 0; // Esta variable se utiliza para saber si una imagen fue cargada por el usuario: 0=Ninguna imagen cargada, 1=Imagen cargada
        Image imagenDefault; // Variable para la imagen por default si el usuario no carga ninguna imagen
        
        List<Regist> lista = new List<Regist>(); // Lista definida por la clase Regist para definir los datos de cada campo
        
        private void listBox1_DoubleClick(object sender, EventArgs e) //Boton para mostrar los detalles del objeto en la lista seleccionado en otra ventana
        {
            if (listBox1.SelectedItem is Regist seleccionado) //Se verifica si se selecciono una fila de la tabla
            {
                FormDetail detail = new FormDetail(seleccionado); //Se llama la clase FormDetail
                detail.ShowDialog(); // ventana modal
            }
        }

        private void Save(object sender, EventArgs e) //Boton Guardar
        {
            if (BodyName.Text != "Región cuerpo" && FaceList.Text != "Lado" && AmountList.Text != "Cantidad" 
                && ViewList.Text != "Vista" && DescriptionBox.Text != "Descripción" && imageTest != 0) //Validar si ningun campo esta vacio
            {
                Regist other = new Regist() //Se crea un nuevo registro
                {
                    Data1 = BodyName.Text,
                    Data2 = FaceList.Text,
                    Data3 = ViewList.Text,
                    Data4 = AmountList.Text,
                    Data5 = DescriptionBox.Text,
                    SaveImage = LoadPicture.Image
                };
                
                lista.Add(other); //Se guarda los datos completos en la lista
                listBox1.Items.Add(other); //Se guarda una preview de los datos guardados y se muestran en el ListBox1
                
                MessageBox.Show("Se guardo la informacion correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                CleanAction(null, null); //Accion para limpiar los campos
            }
            else
            {
                MessageBox.Show("Llena los campos requeridos y carga una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CleanAction(object sender, EventArgs e) // Accion  para limpiar todos los campos y cargar la imagen por default
        {
            BodyName.Text = "Parte del cuerpo";
            
            ViewList.Items.Add("Vista");
            ViewList.Text = "Vista";
            ViewList.ForeColor = System.Drawing.Color.LightGray;
            
            FaceList.Items.Add("Lado");
            FaceList.Text = "Lado";
            FaceList.ForeColor = System.Drawing.Color.LightGray;
            
            AmountList.Items.Add("Cantidad");
            AmountList.Text = "Cantidad";
            AmountList.ForeColor = System.Drawing.Color.LightGray;
            
            DescriptionBox.Text = "Descripción";
            DescriptionBox.ForeColor = System.Drawing.Color.LightGray;

            imageTest = 0;
            LoadPicture.Image = imagenDefault;
        }

        private void Load(object sender, EventArgs e) //Accion para cagar una imagen
        {
            // Configurar el OpenFileDialog
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter= "Archivos de imagen|*.jpg;*.jpeg;*.png;*";
            OpenFileDialog1.Title = "Seleccionar una imagen";
            
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK) // Mostrar el cuadro de diálogo y comprobar si se seleccionó un archivo
            {
                string FileDirection = OpenFileDialog1.FileName; // Obtener la ruta del archivo seleccionado
                
                ShowPicture(FileDirection); // Mostrar la imagen en el PictureBox
            }
        }

        private void ShowPicture(string rutaArchivo) //Accion remplazar imagen
        {
            try
            {
                if (File.Exists(rutaArchivo)) // Verificar si el archivo existe
                {
                    LoadPicture.Image = Image.FromFile(rutaArchivo); // Cargar la imagen en el PictureBox
                    imageTest = 1;
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception e) { MessageBox.Show("Error al cargar la imagen\n\nPosibles causas:\n- La extencion no es la correcta (.jpg, .png, .jpeg)\n- El archivo es muy pesado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void Delete(object sender, EventArgs e) //Accion para borrar un elemento de la lista
        {
            if (listBox1.SelectedItem is Regist selection)
            {
                lista.Remove(selection);
                listBox1.Items.Remove(selection);
            }
        }

        private void ColorPicker(object sender, EventArgs e) //Imagen del cuerpo
        {
            //Cambia el color del TextBox por negro
            BodyName.ForeColor = System.Drawing.Color.Black;

            // Obtener coordenadas del clic del mouse
            MouseEventArgs xy = e as MouseEventArgs;
            int x = xy.X;
            int y = xy.Y;

            label1.Text = $"Coordenadas: {x}, {y}";
            inCoordenadas = $"{x}, {y}";

            // Obtener colores de la posición del clic del mouse
            Bitmap map1 = new Bitmap(pictureBox1.Image);
            Bitmap map2 = new Bitmap(pictureBox2.Image);
            Color colorPicture1 = map1.GetPixel(x, y);
            Color colorPicture2 = map2.GetPixel(x, y);

            //Obtener dato en HEX del color y convertir a String
            string hexColor1 = $"{colorPicture1.R:X2}{colorPicture1.G:X2}{colorPicture1.B:X2}";
            string hexColor2 = $"{colorPicture2.R:X2}{colorPicture2.G:X2}{colorPicture2.B:X2}";

            //Mostrar en texto el color HEX en los Labels
            label2.Text = $"HEX Map1: {hexColor1}";
            label3.Text = $"HEX Map2: {hexColor2}";
            
            switch (hexColor2.ToLowerInvariant()) //Switch para comparar el color obtenido por el clic del usuario con los elementos del switch para la imagen de lado del cuerpo
            {
                case "ed1c24":
                    FaceList.Text = "Derecho";
                    break;
                case "00a2e8":
                    FaceList.Text = "Izquierdo";
                    break;
                default:
                    FaceList.Text = "No especifica";
                    break;
            }

            switch (hexColor1.ToLowerInvariant()) //Switch para comparar el color obtenido por el clic del usuario con los elementos del switch para la imagen de partes del cuerpo
            {
                case "880015":
                    BodyName.Text = "Cabeza";
                    break;
                
                case "b97a57":
                    BodyName.Text = "Cara";
                    break;
                
                case "ed1c24":
                    BodyName.Text = "Frente";
                    break;
                
                case "ff7f27":
                    BodyName.Text = "Oreja";
                    break;
                
                case "fff200":
                    BodyName.Text = "Ojos";
                    break;
                
                case "22b14c":
                    BodyName.Text = "Nariz";
                    break;
                
                case "00a2e8":
                    BodyName.Text = "Boca";
                    break;
                
                case "3f48cc":
                    BodyName.Text = "Mejilla";
                    break;
                
                case "a349a4":
                    BodyName.Text = "Menton";
                    break;
                
                case "ffaec9":
                    BodyName.Text = "Cuello";
                    break;
                
                case "ffc90e":
                    BodyName.Text = "Pecho";
                    break;
                
                case "b5e61d":
                    BodyName.Text = "Pezon";
                    break;
                
                case "99d9ea":
                    BodyName.Text = "Ombligo";
                    break;
                
                case "7092be":
                    BodyName.Text = "Abdomen";
                    break;
                
                case "a8ffef":
                    BodyName.Text = "Pubis";
                    break;
                
                case "ff9fd9":
                    BodyName.Text = "Ingle";
                    break;
                
                case "bfff90":
                    BodyName.Text = "Zona pubica";
                    break;
                
                case "efe4b0":
                    BodyName.Text = "Hombro";
                    break;
                
                case "5cbe90":
                    BodyName.Text = "Axila";
                    break;
                
                case "ffc05d":
                    BodyName.Text = "Brazo";
                    break;
                
                case "daff68":
                    BodyName.Text = "Codo";
                    break;
                
                case "6fff9e":
                    BodyName.Text = "Antebrazo";
                    break;
                
                case "55eeff":
                    BodyName.Text = "Muñeca";
                    break;
                
                case "5658ff":
                    BodyName.Text = "Mano";
                    break;
                
                case "b24aff":
                    BodyName.Text = "Dedos";
                    break;
                
                case "ffce65":
                    BodyName.Text = "Cadera";
                    break;
                
                case "966ebe":
                    BodyName.Text = "Muslo";
                    break;
                
                case "6e96be":
                    BodyName.Text = "Rodilla";
                    break;
                
                case "be3a3c":
                    BodyName.Text = "Pierna";
                    break;
                
                case "bea12d":
                    BodyName.Text = "Tobillo";
                    break;
                
                case "be9c66":
                    BodyName.Text = "Pie";
                    break;
                
                default:
                    BodyName.Text = "Ninguna selección";
                    break;
            }
        }
        
        //A partir de este punto las acciones definidas solo estan hechas con el proposito de que el formulario de la interaz se vea mas detallada y no cumple ningun objetivo logistico

        private void FaceList_Enter(object sender, EventArgs e)
        {
            FaceList.Items.Remove("Lado");
            FaceList.ForeColor = System.Drawing.Color.Black;
        }

        private void FaceList_Leave(object sender, EventArgs e)
        {
            if (FaceList.Text == "")
            {
                FaceList.Items.Add("Lado");
                FaceList.Text = "Lado";
                FaceList.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void ViewList_Enter(object sender, EventArgs e)
        {
            ViewList.Items.Remove("Vista");
            ViewList.ForeColor = System.Drawing.Color.Black;
        }

        private void ViewList_Leave(object sender, EventArgs e)
        {
            if (ViewList.Text == "")
            {
                ViewList.Items.Add("Vista");
                ViewList.Text = "Vista";
                ViewList.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void AmountList_Enter(object sender, EventArgs e)
        {
            AmountList.Items.Remove("Cantidad");
            AmountList.ForeColor = System.Drawing.Color.Black;
        }

        private void AmountList_Leave(object sender, EventArgs e)
        {
            if (AmountList.Text == "")
            {
                AmountList.Items.Add("Cantidad");
                AmountList.Text = "Cantidad";
                AmountList.ForeColor = System.Drawing.Color.LightGray;
            }
        }
        
        private void DescriptionBox_Enter(object sender, EventArgs e)
        {
            if (DescriptionBox.Text == "Descripción")
            {
                DescriptionBox.Text = "";
                DescriptionBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void DescriptionBox_Leave(object sender, EventArgs e)
        {
            if (DescriptionBox.Text == "")
            {
                DescriptionBox.Text = "Descripción";
                DescriptionBox.ForeColor = System.Drawing.Color.LightGray;
            }
        }
    }
}