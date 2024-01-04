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
using System.Net.Http.Headers;

namespace eLearningMareaUnire1918
{
    public partial class eLearning1918_Elev : Form
    {

        private SqlConnection conn;

        public eLearning1918_Elev(string email, string connString)
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
            conn.Open();
        }
        int punctaj;
        int currentQNumber = 0;
        List<int> questions = new List<int>();
        List<int> qtypes = new List<int>();

        private void testStartButton_Click(object sender, EventArgs e)
        {
            questions.Clear();
            qtypes.Clear();
            punctaj = 1;
            punctajLabel.Text = $"Punctaj: {punctaj}";
            testStartButton.Enabled = false;

            while (questions.Count < 6)
            {
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdItem, TipItem FROM Itemi ORDER BY NEWID()", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (questions.Contains((int)reader["IdItem"]) == false)
                {
                    questions.Add((int)reader["IdItem"]);
                    qtypes.Add((int)reader["TipItem"]);
                }

                reader.Close();
            }

            while (questions.Count < 9)
            {
                if (qtypes.Contains(1) == false)
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdItem FROM Itemi WHERE TipItem = 1 ORDER BY NEWID()", conn);
                    questions.Add((int)cmd.ExecuteScalar());
                    qtypes.Add(1);
                }
                else if (qtypes.Contains(2) == false)
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdItem FROM Itemi WHERE TipItem = 2 ORDER BY NEWID()", conn);
                    questions.Add((int)cmd.ExecuteScalar());
                    qtypes.Add(2);
                }
                else if (qtypes.Contains(3) == false)
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdItem FROM Itemi WHERE TipItem = 3 ORDER BY NEWID()", conn);
                    questions.Add((int)cmd.ExecuteScalar());
                    qtypes.Add(3);
                }
                else if (qtypes.Contains(4) == false)
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdItem FROM Itemi WHERE TipItem = 4 ORDER BY NEWID()", conn);
                    questions.Add((int)cmd.ExecuteScalar());
                    qtypes.Add(4);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdItem, TipItem FROM Itemi ORDER BY NEWID()", conn);
                    SqlDataReader reader = cmd.ExecuteReader(); reader.Read();
                    questions.Add((int)reader["IdItem"]);
                    qtypes.Add((int)reader["TipItem"]);
                    reader.Close();
                }
            }

            questionable(currentQNumber);
            ansButton.Enabled = true;
            nextButton.Enabled = true;

            //var message = string.Join(" ", questions);
            //MessageBox.Show(message);
            //message = string.Join(" ", qtypes); MessageBox.Show(message);
        }

        private string[] responses = new string[9];
        private string[] cAnswers = new string[9];

        string CorrectAnswer;

        List<int> corA = new List<int>(); // pt checkboxes
        private void questionable(int currentQuestionNumber)
        {
            int currentQuestionId = questions[currentQuestionNumber]; // first question
            var cmd = new SqlCommand("SELECT * FROM Itemi WHERE IdItem = @i", conn);
            cmd.Parameters.AddWithValue("i", currentQuestionId);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string question = reader["EnuntItem"].ToString();
            questionBox.Text = question;
            
            MessageBox.Show($"{currentQuestionNumber.ToString()}, tip: {qtypes[currentQuestionNumber].ToString()}");

            CorrectAnswer = reader["RaspunsCorectItem"].ToString();
            cAnswers[currentQNumber] = CorrectAnswer;

            if (qtypes[currentQNumber] == 1)
            {
                paneltype1.Visible = true;
                paneltype2.Visible = false;
                paneltype3.Visible = false;
                paneltype4.Visible = false;

                // textBox

            }
            else if(qtypes[currentQNumber] == 2)
            {
                paneltype1.Visible = false;
                paneltype2.Visible = true;
                paneltype3.Visible = false;
                paneltype4.Visible = false;

                // formatare radio buttons

                rB1.Text = reader["Raspuns1Item"].ToString();
                rB2.Text = reader["Raspuns2Item"].ToString();
                rB3.Text = reader["Raspuns3Item"].ToString();
                rB4.Text = reader["Raspuns4Item"].ToString();
            }
            else if(qtypes[currentQNumber] == 3)
            {
                paneltype1.Visible = false;
                paneltype2.Visible = false;
                paneltype3.Visible = true;
                paneltype4.Visible = false;

                // formatare checkboxes

                cB1.Text = reader["Raspuns1Item"].ToString();
                cB2.Text = reader["Raspuns2Item"].ToString();
                cB3.Text = reader["Raspuns3Item"].ToString();
                cB4.Text = reader["Raspuns4Item"].ToString();

                int ra = int.Parse(CorrectAnswer);
                while (ra > 0)
                {
                    corA.Add(ra % 10);
                    ra /= 10;
                }

                //string message = string.Join(" ", corA);
                //MessageBox.Show(message);
            }
            else if(qtypes[currentQuestionNumber] == 4)
            {
                paneltype1.Visible = false;
                paneltype2.Visible = false;
                paneltype3.Visible = false;
                paneltype4.Visible = true;
            }

            
            MessageBox.Show(CorrectAnswer);
            reader.Close();
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            currentQNumber++;
            if (currentQNumber == 8) nextButton.Enabled = false;

            ansButton.Enabled = true;
            type1TB.ForeColor = Color.Black;
            type1TB.Text = "";
            rB1.ForeColor = Color.Black;
            rB2.ForeColor = Color.Black;
            rB3.ForeColor = Color.Black;
            rB4.ForeColor = Color.Black;
            rB1.Checked = false;
            rB2.Checked = false;
            rB3.Checked = false;
            rB4.Checked = false;
            cB1.ForeColor = Color.Black;
            cB2.ForeColor = Color.Black;
            cB3.ForeColor = Color.Black;
            cB4.ForeColor = Color.Black;
            cB1.Checked = false;
            cB2.Checked = false;
            cB3.Checked = false;
            cB4.Checked = false;
            rBFalse.ForeColor = Color.Black;
            rBTrue.ForeColor = Color.Black;

            questionable(currentQNumber);
        }

        private void ansButton_Click(object sender, EventArgs e)
        {
            ansButton.Enabled = false;
            if (qtypes[currentQNumber] == 1)
            {
                string response = type1TB.Text;
                response = response.ToLower();

                if (response == CorrectAnswer.ToLower())
                {
                    punctaj++;
                    punctajLabel.Text = $"Punctaj: {punctaj}";
                    type1TB.ForeColor = Color.Green;
                    ansButton.Enabled = false;
                }
                else
                {
                    type1TB.ForeColor = Color.Red;
                }

                responses[currentQNumber] = response;
            }
            else if (qtypes[currentQNumber] == 2)
            {
                if (CorrectAnswer == "1" && rB1.Checked == true)
                {
                    rB1.ForeColor = Color.Green;
                    punctaj++;
                    punctajLabel.Text = $"Punctaj: {punctaj}";
                    responses[currentQNumber] = "1";
                }
                else if (CorrectAnswer == "2" && rB2.Checked == true)
                {
                    rB2.ForeColor = Color.Green;
                    punctaj++;
                    punctajLabel.Text = $"Punctaj: {punctaj}";
                    responses[currentQNumber] = "2";

                }
                else if (CorrectAnswer == "3" && rB3.Checked == true)
                {
                    rB3.ForeColor = Color.Green;
                    punctaj++;
                    punctajLabel.Text = $"Punctaj: {punctaj}";
                    responses[currentQNumber] = "3";
                }
                else if (CorrectAnswer == "4" && rB4.Checked == true)
                {
                    rB4.ForeColor = Color.Green;
                    punctaj++;
                    punctajLabel.Text = $"Punctaj: {punctaj}";
                    responses[currentQNumber] = "4";
                }
                else
                {
                    if (rB1.Checked == true) { rB1.ForeColor = Color.Red; responses[currentQNumber] = "1"; }
                    if (rB2.Checked == true) { rB2.ForeColor = Color.Red; responses[currentQNumber] = "2"; }
                    if (rB3.Checked == true) { rB3.ForeColor = Color.Red; responses[currentQNumber] = "3"; }
                    if (rB4.Checked == true) { rB4.ForeColor = Color.Red; responses[currentQNumber] = "4"; }
                }
            }
            else if (qtypes[currentQNumber] == 3)
            {
                Dictionary<int, bool> vAfc = new Dictionary<int, bool>(); // value and field checked, retine daca pentru valorile 1, 2.., caseta este marcata sau nu
                if (cB1.Checked == true) vAfc.Add(1, true); else vAfc.Add(1, false);
                if (cB2.Checked == true) vAfc.Add(2, true); else vAfc.Add(2, false);
                if (cB3.Checked == true) vAfc.Add(3, true); else vAfc.Add(3, false);
                if (cB4.Checked == true) vAfc.Add(4, true); else vAfc.Add(4, false);

                bool verif = true;

                foreach (int i in corA)
                {
                    if (vAfc[i] == false) verif = false;
                }


                if (verif == true)
                {
                    MessageBox.Show("Raspuns corect, felicitari!");
                    punctaj++;
                    punctajLabel.Text = $"Punctaj: {punctaj}";
                }

                string sentResponse = "";
                if(cB1.Checked == true) { sentResponse += "1 "; }
                if(cB2.Checked == true) { sentResponse += "2 "; }
                if(cB3.Checked == true) { sentResponse += "3 "; }
                if(cB4.Checked == true) { sentResponse += "4 "; }

                responses[currentQNumber] = sentResponse;
            }
            else if (qtypes[currentQNumber] == 4)
            {
                if (rBFalse.Checked == true && CorrectAnswer == "0")
                {
                    rBFalse.ForeColor = Color.Green;
                    punctaj++;
                    punctajLabel.Text = $"Punctaj: {punctaj}";
                    responses[currentQNumber] = "0";
                }
                else if (rBTrue.Checked == true && CorrectAnswer == "1")
                {
                    rBTrue.ForeColor = Color.Green;
                    punctaj++;
                    punctajLabel.Text = $"Punctaj: {punctaj}";
                    responses[currentQNumber] = "1";
                }
                else
                {
                    if(rBFalse.Checked == true) rBFalse.ForeColor = Color.Red;
                    if(rBTrue.Checked == true) rBTrue.ForeColor = Color.Red;
                }
            }
        
            if(currentQNumber == 8)
            {
                string message = $"    Raspuns utilizator -- Raspuns corect \n" +
                                 $"Q1: {responses[0]} -- {cAnswers[0]} \n" +
                                 $"Q2: {responses[1]} -- {cAnswers[1]} \n" +
                                 $"Q3: {responses[2]} -- {cAnswers[2]} \n" +
                                 $"Q4: {responses[3]} -- {cAnswers[3]} \n" +
                                 $"Q5: {responses[4]} -- {cAnswers[4]} \n" +
                                 $"Q6: {responses[5]} -- {cAnswers[5]} \n" +
                                 $"Q7: {responses[6]} -- {cAnswers[6]} \n" +
                                 $"Q8: {responses[7]} -- {cAnswers[7]} \n" +
                                 $"Q9: {responses[8]} -- {cAnswers[8]} \n";

                MessageBox.Show(message);
            }
        }
    }
}
