using CapaEntidad;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Procedimientos
    {
        CD_Conexion conexion = new CD_Conexion();
        public List<T> cargarDatos<T>(string tabla)
        {
            var client = conexion.Abrir();
            FirebaseResponse response = client.Get(tabla);

            if (response == null || response.Body == "null")
            {
                // Si no hay respuesta o la respuesta está vacía, devolver una lista vacía
                return new List<T>();
            }

            // Deserializar los datos en un diccionario de ID y objetos del tipo T
            Dictionary<string, T> data = response.ResultAs<Dictionary<string, T>>();
            List<T> objetos = new List<T>();

            // Recorrer el diccionario y agregar cada objeto al modelo T con su respectivo ID
            foreach (var item in data)
            {
                T objeto = item.Value; // Obtener el objeto del diccionario
                PropertyInfo property = typeof(T).GetProperty("id"); // Obtener la propiedad "Id" del modelo T
                if (property != null) // Verificar si la propiedad "Id" existe en el modelo T
                {
                    property.SetValue(objeto, item.Key); // Establecer el valor de la propiedad "Id" como la clave del diccionario
                }
                objetos.Add(objeto); // Agregar el objeto al resultado
            }

            // Devolver la lista de objetos del tipo T con sus IDs
            return objetos;
        }

        public string generarCodigo(string tipoCodigo)
        {
            string codigo = null;
            // Crear una instancia de la clase Random
            Random random = new Random();

            // Generar un número aleatorio entre 1000000 y 9999999 (7 dígitos)
            codigo = random.Next(1000000, 10000000).ToString();
            return tipoCodigo + codigo;
        }
        public void llenarComboBox<T>(ComboBox comboBox, string nombreTabla, string nombreElemento) where T : class
        {
            // Limpiar el ComboBox antes de llenarlo para evitar duplicados
            comboBox.Items.Clear();

            // Obtener la lista de objetos del tipo T
            List<T> datos = cargarDatos<T>(nombreTabla);

            // Verificar si se encontraron datos
            if (datos?.Any() == true)
            {
                // Agregar cada elemento al ComboBox
                foreach (T elemento in datos)
                {
                    // Suponiendo que T tiene una propiedad "nombreCat" que deseas mostrar en el ComboBox
                    // Puedes cambiar "nombreCat" a cualquier propiedad que desees mostrar
                    var valorNombre = elemento.GetType().GetProperty(nombreElemento)?.GetValue(elemento)?.ToString();
                    if (!string.IsNullOrEmpty(valorNombre))
                    {
                        comboBox.Items.Add(valorNombre);
                    }
                }
                // Seleccionar el primer elemento del ComboBox
                comboBox.SelectedIndex = 0;

            }
            else
            {
                // Mostrar un mensaje indicando que no hay datos
                MessageBox.Show("No se encontraron datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public byte[] comprimirQR(System.Drawing.Image codigoQR, long calidadDeseada)
        {
            // Configurar los parámetros de compresión JPEG
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, calidadDeseada);

            // Obtener el códec JPEG
            ImageCodecInfo jpegCodec = getEncoderInfo("image/jpeg");

            // Convertir la imagen original a un arreglo de bytes comprimido
            using (MemoryStream ms = new MemoryStream())
            {
                // Guardar la imagen original en el stream de memoria utilizando la compresión JPEG
                codigoQR.Save(ms, jpegCodec, encoderParameters);

                // Convertir el arreglo de bytes en una cadena base64 para almacenarlo en Firebase
                string codigoQRBase64 = Convert.ToBase64String(ms.ToArray());

                // Guardar la cadena base64 en Firebase Realtime Database
                // Código para guardar en Firebase aquí...

                // Devolver el arreglo de bytes comprimido
                return ms.ToArray();
            }
        }

        // Método auxiliar para obtener el códec de imagen adecuado
        private ImageCodecInfo getEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == mimeType)
                {
                    return codec;
                }
            }
            return null;
        }
        public System.Drawing.Image descomprimirImagen(byte[] imagenComprimida)
        {
            // Crear un MemoryStream a partir del arreglo de bytes comprimido
            using (MemoryStream ms = new MemoryStream(imagenComprimida))
            {
                // Crear una imagen a partir del MemoryStream
                System.Drawing.Image imagenDescomprimida = System.Drawing.Image.FromStream(ms);

                // Devolver la imagen descomprimida
                return imagenDescomprimida;
            }
        }
        public void limpiarControles(Form form)
        {
            foreach (var xCtrl in form.Controls)
                if (xCtrl is TextBox)
                {
                    ((TextBox)xCtrl).Text = string.Empty;
                }
            {

            }
        }




    }
}
