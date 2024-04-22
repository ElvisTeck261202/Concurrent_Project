using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using SpreadsheetLight;

namespace Project
{
    public partial class Form1 : Form
    {

        // imagenes : D:\jonat\Escuela\Cuatrimestre 7\Concurrent Programming\
        // excel : D:\jonat\Escuela\Cuatrimestre 7\Concurrent Programming\death-rate-from-suicides.xlsx

        private CharactersController CharactersController;
        private Characters characters;

        private bool stopThread1 = false;
        private bool stopThread2 = false;

        public Form1()
        {
            InitializeComponent();
            CharactersController = new CharactersController();
            characters = new Characters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 3800;
            this.progressBar2.Maximum = 3;
            this.progressBar3.Maximum = 20;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(PathTextBox.Text);
            this.progressBar1.Value = 0;
            this.DataGridView1.DataSource = null;
            this.DataGridView1.Rows.Clear();
            Thread csvThread = new Thread(new ThreadStart(CSVviewThread));
            csvThread.Start();
        }

        private void CSVviewThread()
        {
            string path = "";
            Invoke((MethodInvoker)delegate { path = PathTextBox.Text; });

            Console.WriteLine(path);

            CSVview(path);
        }

        //Funcion del primer Task
        private void CSVview(string path)
        {
            SLDocument sl = new SLDocument(PathTextBox.Text);


            int row = 2;
            List<FieldsModel> Field = new List<FieldsModel>();


            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(row, 1)) && !stopThread1)
            {
                FieldsModel model = new FieldsModel();
                model.Entity = sl.GetCellValueAsString(row, 1);
                model.Code = sl.GetCellValueAsString(row, 2);
                model.Suicides_per_age = sl.GetCellValueAsString(row, 3);

                Field.Add(model);
                Invoke((MethodInvoker)delegate { progressBar1.Value += 1; });
                row++;
                Thread.Sleep(3/4);
            }


            if (!stopThread1)
            {
                Thread.Sleep(10);
                Invoke((MethodInvoker)delegate { DataGridView1.DataSource = Field; });
                MessageBox.Show("Request Finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Invoke((MethodInvoker)delegate { progressBar1.Value += 0; });
            //DataGridView1.DataSource = Field;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Gif1.ImageLocation = null;
            this.progressBar2.Value = 0;
            Thread gifThread = new Thread(new ThreadStart(GifImageThread));
            gifThread.Start();
        }

        private void GifImageThread()
        {
            // Obtiene la ruta de la imagen desde el hilo de la interfaz de usuario
            string path = "";
            Invoke((MethodInvoker)delegate { path = ImagePath.Text; });

            Console.WriteLine(path);

            // Llama al método GifImage con la ruta obtenida
            GifImage(path);
        }

        // Funcion de la segunda Task
        private void GifImage(string path)
        {
            Console.WriteLine(path);

            using (MagickImageCollection collection = new MagickImageCollection())
            {
                if (stopThread2)
                {
                    MessageBox.Show("Request Finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                collection.Add(path + "1.jpg");
                collection[0].AnimationDelay = 50;
                Invoke((MethodInvoker)delegate { progressBar2.Value += 1; });
                Thread.Sleep(100);

                collection.Add(path + "2.jpg");
                collection[1].AnimationDelay = 50;
                Invoke((MethodInvoker)delegate { progressBar2.Value += 1; });
                Thread.Sleep(100);

                collection.Add(path + "1.jpg");
                collection[2].AnimationDelay = 50;
                Invoke((MethodInvoker)delegate { progressBar2.Value += 1; });
                Thread.Sleep(100);

                collection.Optimize();

                collection.Write(path + "migif.gif");

                string image = path + "migif.gif";

                if (stopThread2)
                {
                    MessageBox.Show("Request Finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Request Finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(1000);
                    Invoke((MethodInvoker)delegate { Gif1.ImageLocation = image; });
                    Invoke((MethodInvoker)delegate { progressBar2.Value = 0; });
                }

                //Gif1.ImageLocation = image;
            }

        }

        // Funcion de la tercera Task
        private async void GetCharacters()
        {
            characters = await CharactersController.GetAllCharacters();

            if (characters != null)
            {
                foreach (var character in characters.results)
                {
                    Invoke((MethodInvoker)delegate { progressBar3.Value += 1; });
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DGVCharacters);
                    row.Cells[0].Value = character.name;
                    row.Cells[1].Value = character.gender;
                    row.Cells[2].Value = character.species;
                    row.Cells[3].Value = character.origin.name;

                    //this.progressBar3.Value += 1;


                    Invoke((MethodInvoker)delegate { DGVCharacters.Rows.Add(row); });
                    Thread.Sleep(1);
                    //DGVCharacters.Rows.Add(row);
                }
                MessageBox.Show("Request Finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Request could not be obtained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.DGVCharacters.DataSource = null;
            this.DGVCharacters.Rows.Clear();
            this.progressBar3.Value = 0;
            Task.Run(() => GetCharacters());
            //GetCharacters();
        }

        private void ThreadStop_Click(object sender, EventArgs e)
        {
            stopThread1 = true;
            MessageBox.Show("Request Stopped", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stopThread1 = false;
        }

        private void ThreadStop2_Click(object sender, EventArgs e)
        {
            stopThread2 = true;
            this.progressBar2.Value = 0;
            MessageBox.Show("Request Stopped", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stopThread2 = false;
        }

        // 3 in 1 Task
        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.progressBar1.Value = 0;
                this.progressBar2.Value = 0;
                this.progressBar3.Value = 0;
                this.Gif1.ImageLocation = null;
                this.DGVCharacters.DataSource = null;
                this.DGVCharacters.Rows.Clear();
                this.DataGridView1.DataSource = null;
                this.DataGridView1.Rows.Clear();


                await Task.Run(() =>
                {
                    Parallel.Invoke(
                        () => GetCharacters(),
                        () => GifImageThread(),
                        () => CSVviewThread()
                    );
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Semaphore Task
        static Semaphore semaforo = new Semaphore(3, 3);
        static int conteo = 0;

        private void SemaphoreBtn_Click(object sender, EventArgs e)
        {
            int n = 0;

            for (n = 0; n < 8; n++)
            {
                new Thread(Method).Start(n);
            }
        }

        static void Method (object n)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("We are in the method, {0}, I invoke", n);
            Random rnd = new Random();

            semaforo.WaitOne();

            conteo++;

            Console.WriteLine("Threads in the section ->{0}", conteo);

            Console.WriteLine("{0} This is the critical section", n);

            Thread.Sleep(1000*rnd.Next(1, 5));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} Leaves the critical section", n);

            semaforo.Release();
            conteo--;
            Console.WriteLine("Threads in the section ->{0}", conteo);

        }
    }
}
