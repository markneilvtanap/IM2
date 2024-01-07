using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endterm_IM2
{
    public partial class print_prescription : Form
    {
      //  public Label stud_ffname;
     //   public Label stud_llname;
        public Label stud_aage;
    //    public Label stud_ccontact;
    //    public Label stud_ssex;
     //   public Label stud_bbdate;
    //    public Label stud_emerrcontact;
    //    public Label stud_addresss;
     //   public Label doc_fname;
    //    public Label doc_lname;
    //    public Label doc_contact;
   //     public Label doc_email;
    //    public Label doc_address;
    //    public Label stud_med;
    //    public Label stud_med_take;
   //     public Label stud_med_dousage;
   //     public Label stud_treatment;
   //     public Label stud_diagnosis;
        public print_prescription()
        {
            InitializeComponent();
      //      stud_ffname = this.stud_fname;
     //       stud_llname = this.stud_lname;
      //      stud_aage = this.stud_age;
     //        stud_ccontact = this.stud_contactxl;
      //      stud_ssex = this.stud_sex ;
     //    stud_bbdate = this.stud_bd ;
      //   stud_emerrcontact = this.stud_contact_emer;
     //   stud_addresss = this.stud_address;
     //  doc_fname = this.Doc_fnamee;
    //    doc_lname = this.Doc_lnamee;
    //     doc_contact = this.Doc_contactsssx;
    //    doc_email = this.Doc_emailss;
      //   doc_address = this.Doc_addresssa;


    }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("monthly bill", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("sdasd basdill", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Print");
        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void print_prescription_Load(object sender, EventArgs e)
        {

        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage_1);
            printPreviewDialog1.ShowDialog();

        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_treatment_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
