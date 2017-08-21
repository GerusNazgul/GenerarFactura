using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Generar_Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                string strRutaArchivos = this.txtRutaArchivos.Text.ToString().Trim();

                if (strRutaArchivos == string.Empty)
                {
                    MessageBox.Show("Se requiere de la ruta de los archivos a examinar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRutaArchivos.Focus();
                    return;
                }

                string strArchivos = string.Empty;
                //SE OBTIENEN TODOS LOS ARCHIVOS DE LA RUTA
                string[] arrArchivosPendi = Directory.GetFiles(strRutaArchivos);
                foreach (string strArchivo in arrArchivosPendi)
                {
                    // SE OBTIENE LA INFORMACION DEL ARCHIVO
                    FileInfo infoArchivo = new FileInfo(strArchivo);

                    strArchivos += infoArchivo.Name + "|";

                }

                string[] arrArchivos = strArchivos.Split('|');


                string strRutaArchivoGuardar = this.txtRutaSelec.Text.ToString().Trim();
                if (strRutaArchivoGuardar.Trim() == string.Empty)
                {
                    MessageBox.Show("Antes de generar el archivo, seleccione una carpeta en donde se guardara la factura.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnElegirCarpeta.Focus();
                    return;
                }

                string strFileFactura = "Factura_Generada_" + DateTime.Now.Day +DateTime.Now.Month  + DateTime.Now.Year + DateTime.Now.Minute +".csv";
                string strPathFactura = strRutaArchivoGuardar + "\\" + strFileFactura;

                if (!File.Exists(strPathFactura))
                {
                    try { File.Create(strPathFactura).Dispose(); }
                    catch (Exception exc)
                    { }
                }
                else
                {
                    MessageBox.Show("La Factura '" + strFileFactura + "' ya existe en la ruta '" + strRutaArchivoGuardar + "'. Seleccione otra carpeta para guardar el archivo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnElegirCarpeta.Focus();
                    return;
                }


                try
                {
                    foreach (string strArchivo in arrArchivos)
                    {
                        if (strArchivo == string.Empty)
                            continue;

                        string strArchivosAExaminar = strRutaArchivos + "\\" + strArchivo;
                        using (TextFieldParser tfpParsecsv = new TextFieldParser(strArchivosAExaminar, Encoding.Default,false))
                        {
                            tfpParsecsv.CommentTokens = new string[] { "" };
                            tfpParsecsv.SetDelimiters(new string[] { "," });
                            tfpParsecsv.HasFieldsEnclosedInQuotes = true;

                            

                            int iFila = 0;

                            while (!tfpParsecsv.EndOfData)
                            {
                                string strRenglon = string.Empty;
                                string[] arrColumnas = tfpParsecsv.ReadFields();
                                iFila++;

                                if (iFila == 1)
                                    continue;

                                foreach (string strFields in arrColumnas)
                                {
                                    if (strFields.Contains(","))
                                        strRenglon += "\"" + strFields + "\",";
                                    else
                                        strRenglon += strFields + ",";
                                }
                                strRenglon = strRenglon.Substring(0, strRenglon.Length - 1);

                                System.IO.StreamWriter stArchivosProc = new System.IO.StreamWriter(strPathFactura, true, Encoding.Default);
                                stArchivosProc.WriteLine(strRenglon);
                                stArchivosProc.Close();

                                if (iFila > 10)
                                    break;
                            }
                        }
                    }

                    MessageBox.Show("Se genero la factura correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se puede generar el archivo por el siguiente motivo: \r\n\r\n" + exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception exc)
            {

            }
        }

        private void btnElegirCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbdMostrarBroDialog = new FolderBrowserDialog();

                if (fbdMostrarBroDialog.ShowDialog() == DialogResult.OK)
                {
                    string strRutaElegida = fbdMostrarBroDialog.SelectedPath;
                    this.txtRutaSelec.Text = strRutaElegida;
                }
            }
            catch (Exception exc)
            {

            }
        }

        private void btnElegirCarpetaArchivos_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbdMostrarBroDialog = new FolderBrowserDialog();

                if (fbdMostrarBroDialog.ShowDialog() == DialogResult.OK)
                {
                    string strRutaElegida = fbdMostrarBroDialog.SelectedPath;
                    this.txtRutaArchivos.Text = strRutaElegida;
                }
            }
            catch (Exception exc)
            {
                
            }
        }


    }
}
