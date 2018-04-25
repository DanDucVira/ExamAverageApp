using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamResultAverage
{
    public partial class ExamResults : Form
    {
        public ExamResults()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int exam1, exam2, average;


            exam1 = Convert.ToInt32(txtExam1.Text);
            exam2 = Convert.ToInt32(txtExam2.Text);
            average = (exam1 + exam2) / 2;

            listStudentName.Items.Add(txtStudentName.Text);
            listExam1.Items.Add(txtExam1.Text);
            listExam2.Items.Add(txtExam2.Text);

            listAverage.Items.Add(average);

            if (average >= 60)
            {
                listResult.Items.Add("Passed");
            }
            else {
                listResult.Items.Add("Failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtExam1.Clear();
            txtExam2.Clear();
            listStudentName.Items.Clear();
            listExam1.Items.Clear();
            listExam2.Items.Clear();
            listAverage.Items.Clear();
            listResult.Items.Clear();
        }
    }
}
