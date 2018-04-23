using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
// ...

namespace CustomCollectionDesignTime {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            List<Invoice> invoices = new List<Invoice>(10);

            invoices.Add(new Invoice(0, "Invoice1", 10.0m));
            invoices.Add(new Invoice(1, "Invoice2", 15.0m));
            invoices.Add(new Invoice(2, "Invoice3", 20.0m));

            XtraReport1 report = new XtraReport1();
            report.DataSource = invoices;

            ReportPrintTool pt = new ReportPrintTool(report);
            pt.ShowPreviewDialog();
        }
    }

    public class Invoice {
        private int id;

        public int Id {
            get { return id; }
            set { id = value; }
        }
        private string description;

        public string Description {
            get { return description; }
            set { description = value; }
        }
        private decimal price;

        public decimal Price {
            get { return price; }
            set { price = value; }
        }

        public Invoice(int id, string description, decimal price) {
            this.Id = id;
            this.Description = description;
            this.price = price;
        }
    }

}
