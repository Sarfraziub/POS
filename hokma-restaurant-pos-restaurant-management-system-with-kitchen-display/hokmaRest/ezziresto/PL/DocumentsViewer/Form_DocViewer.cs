using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezziresto.PL.DocumentsViewer
{
    public partial class Form_DocViewer : DevExpress.XtraEditors.XtraForm
    {
        public Form_DocViewer()
        {
            InitializeComponent();
        }

        public void printReciept()
        {
            Report.Reciept80mm reciept = new Report.Reciept80mm();
            documentViewer.DocumentSource = reciept;
            reciept.CreateDocument();
        }

        public void printInvoiceIngredientPurchase()
        {
            Report.InvoiceIngredient invoice = new Report.InvoiceIngredient();
            documentViewer.DocumentSource = invoice;
            invoice.CreateDocument();
        }

        public void printInvoiceFoodPurchase()
        {
            Report.InvoiceFood invoice = new Report.InvoiceFood();
            documentViewer.DocumentSource = invoice;
            invoice.CreateDocument();
        }
        
        private void Form_DocViewer_Load(object sender, EventArgs e)
        {
            // load
        }
    }
}