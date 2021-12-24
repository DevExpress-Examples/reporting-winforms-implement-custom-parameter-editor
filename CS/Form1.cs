using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var report = new XtraReport1();
            report.ShowPreview();
        }
    }
}
