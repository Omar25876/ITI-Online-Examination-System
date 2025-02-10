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
using System.Security.Cryptography;
using onlineExam;
using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;
using System.Configuration;
using onlineExam.models;
using System.Xml.Linq;

namespace WindowsFormsApp
{
    public partial class ExamsDetails : Form
    {
        private readonly static string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        private List<Questions> questions = new List<Questions>();
        private List<int> myAns = new List<int>();
        private List<int> questionScore = new List<int>();
        private int counter = 0;
        private int EID;
        private string eName;
        private int totalScore = 0;
        private Panel spacerPanel;
        private Timer myTimer;
        private int remainingTime;
        private ReviewModel[] reviewModels ;
        private User user;
        Panel panel;

        public ExamsDetails(int e_id, string EN, User user,Panel panel)
        {
            this.panel = panel;
			InitializeComponent();
            panel1.Dock = DockStyle.Top;
            panel2.Dock= DockStyle.Top;
             spacerPanel = new Panel();
            spacerPanel.Dock = DockStyle.Top;
            spacerPanel.Height = 20; 
            spacerPanel.BackColor = Color.Transparent; 

            // Add panels to the form
            this.Controls.Add(panel2);
            this.Controls.Add(spacerPanel);
            this.Controls.Add(panel1);
            EID = e_id;
            eName = EN;
            this.user = user;
            LoadExams();
            myTimer = new Timer();
            myTimer.Interval = 1000; 
            myTimer.Tick += MyTimer_Tick;

            remainingTime = 30 * 60;
            //remainingTime = 20;
            myTimer.Start();
            this.Resize += ExamsDetails_Resize;
        }
        private void SetSpacerHeight()
        {
            
            spacerPanel.Height = (int)(this.ClientSize.Height * .2);
        }
        private void ExamsDetails_Resize(object sender, EventArgs e)
        {
            SetSpacerHeight(); 
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            // Decrease the remaining time by 1 second
            remainingTime--;

            // Display the remaining time in minutes and seconds format
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;
            timer.Text = $"{minutes:D2}:{seconds:D2}"; // Display in MM:SS format
            if (remainingTime < 600)
            {
                timer.ForeColor = Color.Red;
            }
            
            if (remainingTime == 0)
            {
                myTimer.Stop();
                timer.Text = "Time's Up!";
                for (int i = 0; i < questions.Count; i++)
                {
                    reviewModels[i] = new ReviewModel(questions[i].QID, questions[i].Question, myAns[i], questions[i].ModelAswer);
                }

                ResultForm result = new ResultForm(totalScore, eName, reviewModels, user, eName, EID,panel) { TopLevel = false, Dock = DockStyle.Fill };
              ShowForm(result);

			}
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Wesso_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void LoadExams()
        {
            
            SqlCommand sqlCommand = new SqlCommand("GetExam", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@eName", eName);
            try
            {
                sqlConnection.Open();
                var re = sqlCommand.ExecuteReader();
                while (re.Read())
                {
                    questions.Add(new Questions(int.Parse(re[7].ToString()), int.Parse(re[8].ToString()), int.Parse(re[11].ToString()), re[10].ToString()));
                    myAns.Add(0);
                }
                reviewModels= new ReviewModel[questions.Count];


                myLabel.Text = questions[counter].Question;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            LoadChoises(questions[counter++].QID);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
		private void ShowForm(Form form)
		{
			panel.Controls.Clear();
			panel.Controls.Add(form);
			form.Show();
		}

		private void SaveAnswerInDB()
		{
			try
			{
				sqlConnection.Open();

				for (int i = 0; i < reviewModels.Length; i++)
				{
					SqlCommand sqlCommand = new SqlCommand("InsertAnswer", sqlConnection);

					sqlCommand.CommandType = CommandType.StoredProcedure;

					sqlCommand.Parameters.AddWithValue("@s_ID", user.UserId);
					sqlCommand.Parameters.AddWithValue("@E_Name", eName);
					sqlCommand.Parameters.AddWithValue("@Q_ID", reviewModels[i].QID);
					sqlCommand.Parameters.AddWithValue("@S_Ans", reviewModels[i].Answer);
					sqlCommand.Parameters.AddWithValue("@C_ID", reviewModels[i].RAnswer);
					sqlCommand.Parameters.AddWithValue("@E_ID", EID);

					sqlCommand.ExecuteNonQuery();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in connection: " + ex.Message);
			}
			finally
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
				}
			}
		}


        private void SaveStudentExam()
        {
            try
            {
                float grade = (float)totalScore;

				sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("InsertStudentExam", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@s_ID", user.UserId);
                sqlCommand.Parameters.AddWithValue("@E_ID", EID);
                sqlCommand.Parameters.AddWithValue("@Grade", grade);
                sqlCommand.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connection: " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }



		private void button2_Click(object sender, EventArgs e)
        {
            if (nextbtn.Text == "Finish")
            {
                SaveAnswerInDB();
                SaveStudentExam();

				ResultForm result = new ResultForm(totalScore, eName, reviewModels, user, eName, EID,panel) { TopLevel = false, Dock = DockStyle.Fill };
				ShowForm(result);
			}

            else
            {
                CalculateNexScore();
                AddAnswer();
                if (questions.Count > counter)
                {
                    CheckNext();// to Next Question
                    myLabel.Text = questions[counter].Question;
                    LoadChoises(questions[counter].QID);
                }
                else
                {
                    nextbtn.Text = "Finish";
                }

                ReviewModel reviewModel = new ReviewModel(questions[counter - 1].QID, questions[counter - 1].Question, myAns[counter-1], questions[counter - 1].ModelAswer);
                reviewModels[counter - 1] = reviewModel;
                counter++;
            }
        }

        private void AddAnswer()
        {
            if (radioButton1.Checked)
            {
                myAns[counter - 1] = 1;
            }
            else if (radioButton2.Checked)
            {
                myAns[counter - 1] = 2;
            }
            else if (radioButton3.Checked)
            {
                myAns[counter - 1] = 3;
            }
            else if (radioButton4.Checked)
            {
                myAns[counter - 1] = 4;
            }
        }

        private void CheckNext()
        {
            if (myAns[counter] == 1)
            {
                radioButton1.Checked = true;
            }
            else if (myAns[counter] == 2)
            {
                radioButton2.Checked = true;
            }
            else if (myAns[counter] == 3)
            {
                radioButton3.Checked = true;
            }
            else if (myAns[counter] == 4)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            }
        }

        private void CalculateNexScore()
        {
            if (radioButton1.Checked && questions[counter - 1].ModelAswer == 1)
            {
                //MessageBox.Show("1");
                questionScore.Add(questions[counter - 1].Grade);
                totalScore += questions[counter - 1].Grade;
            }
            else if (radioButton2.Checked && questions[counter - 1].ModelAswer == 2)
            {
                //MessageBox.Show("2");
                questionScore.Add(questions[counter - 1].Grade);
                totalScore += questions[counter - 1].Grade;
            }
            else if (radioButton3.Checked && questions[counter - 1].ModelAswer == 3)
            {
                //MessageBox.Show("3");
                questionScore.Add(questions[counter - 1].Grade);
                totalScore += questions[counter - 1].Grade;
            }
            else if (radioButton4.Checked && questions[counter - 1].ModelAswer == 4)
            {
                //MessageBox.Show("4");
                questionScore.Add(questions[counter - 1].Grade);
                totalScore += questions[counter - 1].Grade;
            }
            else
            {
                //MessageBox.Show("Out");
                questionScore.Add(0);
            }

            //MessageBox.Show("Your Score is : " + totalScore);
        }

        private void LoadChoises(int q_ID)
        {
            
            SqlCommand sqlCommand = new SqlCommand("GetQuestion", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@q_ID", q_ID);
            try
            {
                sqlConnection.Open();
                var re = sqlCommand.ExecuteReader();
                while (re.Read())
                {
                
                    if (re[6].ToString() == "1")
                    {
                        radioButton1.Text = re[7].ToString();
                    }
                    else if (re[6].ToString() == "2")
                    {
                        radioButton2.Text = re[7].ToString();
                    }

                    if (re[2].ToString()== "T/F")
                    {
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                    }
                    else
                    {
                        radioButton3.Visible = true;
                        radioButton4.Visible = true;
                        if (re[6].ToString() == "3")
                        {
                            radioButton3.Text = re[7].ToString();
                        }
                        else if (re[6].ToString() == "4")
                        {
                            radioButton4.Text = re[7].ToString();
                        }
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextbtn.Text = "Next";
            if (counter - 1 > 0)
            {
                totalScore -= questionScore[questionScore.Count - 1];
                questionScore.RemoveAt(questionScore.Count - 1);
                counter--;
                ShowSelected(counter - 1);
                myLabel.Text = questions[counter - 1].Question;
                LoadChoises(questions[counter - 1].QID);
            }
        }

        private void ShowSelected(int index)
        {
            if (myAns[index] == 1)
            {
                radioButton1.Checked = true;
            }
            else if (myAns[index] == 2)
            {
                radioButton2.Checked = true;
            }
            else if (myAns[index] == 3)
            {
                radioButton3.Checked = true;
            }
            else if (myAns[index] == 4)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void timer_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
