using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grades
{
    public partial class frmGrades : Form
    {
        int count = 0;
        double sum = 0;
        string[] Students = new string[20];
        double[] Grades = new double[20];
        public frmGrades()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strFirst, strLast, strGrade;
            double dblGrade;
            strFirst = txtBxFirst.Text;
            strLast = txtBxLast.Text;
            strGrade = txtBxGrade.Text;
            dblGrade = double.Parse(strGrade);
            Students[count] = strLast + ", " + strFirst;
            Grades[count] += dblGrade;
            sum += dblGrade;
            count++;
            txtBxFirst.Text = "";
            txtBxGrade.Text = "";
            txtBxLast.Text = "";
            txtBxFirst.Focus();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            double dblAverage;
            string strOutput;
            //Use PadLeft, PadRight
            strOutput = "Name\t\tGrade\tAverage\n";
            dblAverage=sum/count;
            for (int i = 0; i < count; ++i)
            {
                strOutput += Students[i] + "\t\t" + Grades[i].ToString("n1") + "\t" + dblAverage.ToString("n1") + "\n";
            }
            txtBxResults.Text = strOutput;
        }
    }
}
