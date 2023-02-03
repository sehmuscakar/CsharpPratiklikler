using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;// bu accsess veri tabanı kulanıldığında bu kuphane gerekli ;accses te komutlarına ulaşmak için 
//SQL de de SqlClient bu kütühane ile komutalara ulaşabiliyorduk sql in 
namespace kitaplık_access_veritabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti =new  OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C: \Users\scaka\OneDrive\Masaüstü\access veri tabanı kitaplık.mdb");
       // bu da accses teki veri tabanı bağlantısı  oluşturmak için kulnaılır 
      // @ bu işaret de dosya yolu belirlenir et işareti 

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from kitaplar", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'access_veri_tabanı_kitaplıkDataSet2.kitaplar' table. You can move, or remove it, as needed.
            this.kitaplarTableAdapter.Fill(this.access_veri_tabanı_kitaplıkDataSet2.kitaplar);
            listele();
        }
    }
}
