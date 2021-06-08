using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace uyduDeneme2_excel_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
            
            uygulama.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook deneme = uygulama.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)deneme.Sheets[1];
            Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2][5];
            alan.Value2 = textBox1.Text;
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
