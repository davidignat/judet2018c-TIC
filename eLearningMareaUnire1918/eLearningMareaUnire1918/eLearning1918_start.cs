using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace eLearningMareaUnire1918
{
    public partial class eLearning1918_start : Form
    {

        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\eLearning1918.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private SqlConnection conn;
        /// De facut cu parola alt formular pt database
        public eLearning1918_start()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
            conn.Open();
            deleteDatabase();
            dataUpload();
        }

        private void dataUpload()
        {
            StreamReader sr = new StreamReader(Application.StartupPath + @"\bin\..\date.txt");
            string row;
            string switcher = string.Empty;

            while ((row = sr.ReadLine()) != null)
            {
                if (row == "Utilizatori:")
                {
                    switcher = "Utilizatori";
                    row = sr.ReadLine();
                }
                else if (row == "Itemi:")
                {
                    switcher = "Itemi";
                    row = sr.ReadLine();
                }
                else if (row == "Evaluari:")
                {
                    switcher = "Evaluari";
                    row = sr.ReadLine();
                }

                string[] data = row.Split(';');
                SqlCommand cmd;

                if (switcher == "Utilizatori")
                {
                    cmd = new SqlCommand("INSERT INTO Utilizatori (NumePrenumeUtilizator, ParolaUtilizator, EmailUtilizator, ClasaUtilizator) VALUES (@n, @p, @e, @c)", conn);
                    cmd.Parameters.AddWithValue("n", data[0]);
                    cmd.Parameters.AddWithValue("p", data[1]);
                    cmd.Parameters.AddWithValue("e", data[2]);
                    cmd.Parameters.AddWithValue("c", data[3]);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                } else if (switcher == "Itemi")
                {
                    cmd = new SqlCommand("INSERT INTO Itemi (TipItem, EnuntItem, Raspuns1Item, Raspuns2Item, Raspuns3Item, Raspuns4Item, RaspunsCorectItem) VALUES (@t, @e, @r1, @r2, @r3, @r4, @rc)", conn);
                    cmd.Parameters.AddWithValue("t", data[0]);
                    cmd.Parameters.AddWithValue("e", data[1]);
                    cmd.Parameters.AddWithValue("r1", data[2]);
                    cmd.Parameters.AddWithValue("r2", data[3]);
                    cmd.Parameters.AddWithValue("r3", data[4]);
                    cmd.Parameters.AddWithValue("r4", data[5]);
                    cmd.Parameters.AddWithValue("rc", data[6]);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                else if (switcher == "Evaluari")
                {
                    cmd = new SqlCommand("INSERT INTO Evaluari (IdElev, DataEvaluare, NotaEvaluare) VALUES (@i, @d, @n)", conn);
                    cmd.Parameters.AddWithValue("i", data[0]);
                    cmd.Parameters.AddWithValue("d", data[1]);
                    cmd.Parameters.AddWithValue("n", data[2]);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
        }

        private void deleteDatabase()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Evaluari", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new SqlCommand("DBCC CHECKIDENT (Evaluari, RESEED, 0)", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new SqlCommand("DELETE FROM Utilizatori", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new SqlCommand("DBCC CHECKIDENT (Utilizatori, RESEED, 0)", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new SqlCommand("DELETE FROM Itemi", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new SqlCommand("DBCC CHECKIDENT (Itemi, RESEED, 0)", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }

        int maxNumberOfImages;

        private void imageHandler(int n)
        {
            Dictionary<int, string> numberPhotos = new Dictionary<int, string>();
            Dictionary<string, int> photosNumber = new Dictionary<string, int>();
            {
                string[] pics = Directory.GetFiles(Application.StartupPath + @"\imaginislideshow", "*.jpg");

                int c = 0;

                foreach (var pic in pics)
                {
                    numberPhotos.Add(++c, pic);
                    photosNumber.Add(pic, c);
                }

                maxNumberOfImages = c;
            }

            string imgPath = numberPhotos[n];
            pictureBox1.ImageLocation = imgPath;
            progressBar1.Value = photosNumber[numberPhotos[n]];
        }


        private void eLearning1918_start_Load(object sender, EventArgs e)
        {
            imageHandler(currentImage);
            timer.Enabled = true;
        }

        int currentImage = 1;

        private void auto_manualButton_Click(object sender, EventArgs e)
        {
            if(auto_manualButton.Text == "Auto")
            {
                auto_manualButton.Text = "Manual";
                nextButton.Enabled = true;
                previousButton.Enabled = true;

                if (currentImage == maxNumberOfImages) nextButton.Enabled = false;
                if (currentImage == 1) previousButton.Enabled = false;

            } else
            {
                auto_manualButton.Text = "Auto";
                nextButton.Enabled = false;
                previousButton.Enabled = false;

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(auto_manualButton.Text == "Auto")
            {
                if(currentImage == maxNumberOfImages)
                {
                    currentImage = 0;
                    imageHandler(maxNumberOfImages);
                    return;
                }
                currentImage++;

                imageHandler(currentImage);

            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentImage--;
            if (currentImage == 1) previousButton.Enabled = false; 

            imageHandler(currentImage);
            nextButton.Enabled = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentImage++;
            if (currentImage == maxNumberOfImages) nextButton.Enabled = false;

            imageHandler(currentImage);
            previousButton.Enabled = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            email = "elev1@yahoo.com"; // Faster
          
            string password = parolaTB.Text;
            password = "elev1"; // Faster

            SqlCommand cmd = new SqlCommand("SELECT IdUtilizator FROM Utilizatori WHERE EmailUtilizator = @email AND ParolaUtilizator = @pass", conn);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("pass", password);
            var reader = cmd.ExecuteScalar();
            if(reader != null)
            {
                eLearning1918_Elev elevForm = new eLearning1918_Elev(email, connString);
                elevForm.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Eroare de autentificare!");
                parolaTB.Text = emailTB.Text = "";
            }

        }
    }
}
