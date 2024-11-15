using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
	public partial class frmSatis : Form
	{
		AracKiralama arac = new AracKiralama();

		public frmSatis()
		{
			InitializeComponent();
		}

		private void frmSatis_Load(object sender, EventArgs e)
		{
			string query = "Select * from Satis";
			SqlDataAdapter adtr = new SqlDataAdapter();

			dataGridView1.DataSource = arac.listele(adtr, query);

			arac.satisHespala(label1);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
			saveFileDialog1.Title = "Excel Dosyasını Kaydet";

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				ExportToExcel(dataGridView1, saveFileDialog1.FileName);
			}
		}

		private void ExportToExcel(DataGridView dataGridView, string filePath)
		{
			// Excel uygulamasını başlat
			Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
			excelApp.Visible = true;

			// Yeni bir Excel çalışma kitabı oluştur
			Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
			Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];

			try
			{
				// Başlık satırını ekleyin
				for (int i = 1; i <= dataGridView.Columns.Count; i++)
				{
					worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
				}

				// Verileri ekleyin
				for (int i = 0; i < dataGridView.Rows.Count; i++)
				{
					for (int j = 0; j < dataGridView.Columns.Count; j++)
					{
						worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
					}
				}

				// Dosyayı kaydet
				workbook.SaveAs(filePath);

				MessageBox.Show("Veriler Excel dosyasına başarıyla aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Excel uygulamasını serbest bırakın
				System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string searchText = textBox1.Text;
			dataGridView1.Controls.Clear();

			using (SqlConnection connection = new SqlConnection("Server=(local);Database=AracKiralama;Trusted_Connection=True;"))
			{
				using (SqlCommand command = new SqlCommand("SELECT * FROM Satis WHERE Tc LIKE @SearchText", connection))
				{
					command.Parameters.AddWithValue("@SearchText", searchText);

					SqlDataAdapter adapter = new SqlDataAdapter(command);
					DataTable dataTable = new DataTable();

					try
					{

						connection.Open();
						adapter.Fill(dataTable);

						// DataGridView'e verileri yükleme
						dataGridView1.DataSource = dataTable;
						connection.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
