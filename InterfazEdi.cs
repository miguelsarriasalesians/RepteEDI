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

namespace Repte
{
    public partial class InterfazEdi : Form
    {
        //Declarar el dialogo de seleccion del archivo
        OpenFileDialog openFile = new OpenFileDialog();
        string line = "";
        public InterfazEdi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Solo si clicka OK
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                //Lector del archivo seleccionado
                String file = openFile.FileName;
                //Inicializar el StreamReader
                StreamReader srContar = new StreamReader(file);
                String[][] matrix;
                int contador = 0;
                //Va leyendo hasta que llega a la ultima linea y da null
                while (line != null)
                {
                    line = srContar.ReadLine();
                    contador++;

                    if (line != null)
                    {
                        lsbLectura.Items.Add(line);
                    }
                }
                //Cerrar el StreamReader
                srContar.Close();

                bool primeraVuelta = true;
                String line2 = "";
                //Inicializar el segundo StreamReader
                StreamReader srGuardar = new StreamReader(file);
                int indexMatrix = 0;
                contador--;
                matrix = new String[contador][];
                //Guardar los elementos en un array
                while (line2 != null)
                {
                    //Leer la linea
                    line2 = srGuardar.ReadLine();
                    if(line2 != null)
                    {
                        String[] arrayCompleto = line2.Split('|');
                        //Eliminar el ultimo elemento que es un string vacio
                        String[] segmentValue = arrayCompleto.Skip(0).Take(arrayCompleto.Length - 1).ToArray();
                        //Añadir el array al array multidimensional
                        matrix[indexMatrix] = segmentValue;
                        indexMatrix++;
                    }
                }
                //Cerrar el segundo StreamReader
                srGuardar.Close();

                bool firstContact = true;
                foreach (var array in matrix)
                {
                    switch (array[0])
                    {
                        case "CON":
                            if(!firstContact)
                            {
                                lsbArray.Items.Add("");
                            } else
                            {
                                firstContact = false;
                            }
                            
                            //Mostrarlo en el ListBox
                            lsbArray.Items.Add("<<Nuevo Contacto>>");
                            lsbArray.Items.Add("Nombre: " + array[1]);
                            lsbArray.Items.Add("Fecha: " + array[2]);
                            lsbArray.Items.Add("Movil: " + array[3]);
                            break;
                        case "SYS":
                            //Mostrarlo en el ListBox
                            lsbArray.Items.Add("<<Sistema de contacto>>");
                            lsbArray.Items.Add("Tipo: " + array[1]);
                            lsbArray.Items.Add("Identificador: " + array[2]);
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }

                    //Guardarlo en la base de datos

                    

                }

               

                //Traemos el contexto, es como el DataSet
                NewContact_ContactSystem_Entities db;
                db = new NewContact_ContactSystem_Entities();

                //Llenar DataGridView de contactos
                List<NewContact> contacts;
                contacts = db.NewContact.ToList();
                dtgContacts.DataSource = contacts;

                //Llenar DataGridView de sistemas
                List<ContactSystem> systems;
                systems = db.ContactSystem.ToList();
                dtgSystems.DataSource = systems;
                int FK_contactId = 0;

                foreach (var array in matrix)
                {
                    //TODO: Aqui se guardara la informacion en la base de datos con Entity Framework
                    switch (array[0])
                    {
                        case "CON":
                            
                            //Crear el contacto
                            NewContact newContact = new NewContact
                            {
                                Name = array[1],
                                BirthDate = array[2]
                            };

                            db.NewContact.Add(newContact);
                            db.SaveChanges();
                            
                            FK_contactId = newContact.idContact;


                            //Crear el system a partir del ultimo segmento de la linea del EDI
                            ContactSystem contactSystem = new ContactSystem()
                            {
                                IdContact = FK_contactId,
                                Description = "Movil",
                                SystemValue = array[3]
                            };

                            db.ContactSystem.Add(contactSystem);
                            db.SaveChanges();


                            break;
                        case "SYS":

                            //Conseguir el ID del ultimo elemento de la tabla NewContact
                            NewContact_ContactSystem_Entities ddbb;
                            ddbb = new NewContact_ContactSystem_Entities();
                            NewContact[] contactsArray = ddbb.NewContact.ToArray();
                            FK_contactId = contactsArray.Last().idContact;
                            //Crear el system a partir del ultimo segmento de la linea del EDI
                            ContactSystem contactSystem2 = new ContactSystem()
                            {
                                IdContact = FK_contactId,
                                Description = array[1],
                                SystemValue = array[2]
                            };

                            db.ContactSystem.Add(contactSystem2);
                            db.SaveChanges();

                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }

                }

                List<NewContact > newContacts = db.NewContact.ToList();
                dtgContactsPost.DataSource = newContacts;


                List<ContactSystem> newSystems = db.ContactSystem.ToList();
                dtgSystemsPost.DataSource = newSystems;



            }
        }

        private void InterfazEdi_Load(object sender, EventArgs e)
        {
            openFile.Filter = "EDI Files (*.edi)|*.edi|All Files (*.*)|*.*";
        }
    }
}
