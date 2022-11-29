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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Latihan04
{
	public partial class Form1 : Form
	{
		SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-AF8JRRP\SQLEXPRESS;Initial Catalog=DBAplikasi;Integrated Security=True");
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dBAplikasiDataSet1.tbl_mhs' table. You can move, or remove it, as needed.
			this.tbl_mhsTableAdapter.Fill(this.dBAplikasiDataSet1.tbl_mhs);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			koneksi.Open();
			SqlCommand cmd = koneksi.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "insert into [tbl_mhs] (NPM,NamaMahasiswa,Jurusan,AsalKota) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";
			cmd.ExecuteNonQuery();
			koneksi.Close();
			textBox1.Text = "";
			textBox2.Text = "";
			textBox4.Text = "";
			textBox3.Text = "";
			display_data();
			MessageBox.Show("Data berhasil dimasukkan");
		}
		public void display_data()
		{
			koneksi.Open();
			SqlCommand cmd = koneksi.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select*from [tbl_mhs]";
			cmd.ExecuteNonQuery();
			DataTable dta = new DataTable();
			SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
			dataadp.Fill(dta);
			dataGridView1.DataSource = dta;
			koneksi.Close();

		}
		private void button4_Click(object sender, EventArgs e)
		{
			display_data();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			koneksi.Open();
			SqlCommand cmd = koneksi.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "delete from [tbl_mhs] where NPM = '" + textBox1.Text + "'";
			cmd.ExecuteNonQuery();
			koneksi.Close();
			textBox1.Text = "";
			MessageBox.Show("Data telah dihapus");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			koneksi.Open();
			SqlCommand cmd = koneksi.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd = new SqlCommand ("Update tbl_mhs set NPM='" + textBox1.Text + "', NamaMahasiswa='" + textBox2.Text + "', Jurusan='" + textBox4.Text + "', AsalKota='" + textBox3.Text + "' where NPM='" + textBox1.Text + "'", koneksi);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Data berhasil diperbarui");
			koneksi.Close();
			textBox1.Text = "";
			textBox2.Text = "";
			textBox4.Text = "";
			textBox3.Text = "";
			Refresh();
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			display_data();
		}
	}
}
