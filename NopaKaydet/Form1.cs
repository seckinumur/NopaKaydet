using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NopaKaydet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable Tablosu = new DataTable();
        
        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Klasor = new FolderBrowserDialog();
            Klasor.ShowDialog();
            DirectoryInfo Dosyalar = new DirectoryInfo(Klasor.SelectedPath);
            foreach (FileInfo item in Dosyalar.GetFiles())
            {
                string eni = "", boyu = "", Adi = "";
                int Sayac = 0, Sayac1 = 0, Sayac2 = 0,Kolon = 1;
                foreach (var Metin in item.Name.ToCharArray())
                {
                    if (Sayac == 0)
                    {
                        if (Metin.ToString() != "x" && Metin.ToString() != "X")
                        {
                            eni = eni + Metin.ToString();
                        }
                        else
                        {
                            Sayac = 1;
                        }
                    }
                    else
                    {
                        if (Metin.ToString() != " " && Sayac1 == 0)
                        {
                            boyu = boyu + Metin.ToString();
                        }
                        else
                        {
                            Sayac1 = 1;
                            if (Metin.ToString() != "." && Sayac2 == 0)
                            {
                                Adi = Adi + Metin.ToString();
                            }
                            else { Sayac2 = 1; }
                        }
                    }
                }
                double en = Convert.ToDouble(eni), boy = Convert.ToDouble(boyu);
                double Metrekaresi = Math.Round(((en * boy) / 100) / 100, 2);//çok önemli metrekare hesabı
                Tablosu.Rows.Add(eni + "X" + boyu, Adi, Metrekaresi.ToString());
                Kolon++;
                Sayac = 0;
                Sayac1 = 0;
                Sayac2 = 0;
            }
            gridControl1.DataSource = Tablosu;
        }

        private void excellKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dosya = new OpenFileDialog();
            Dosya.ShowDialog();
            string eni = "", boyu = "", Adi = "";
            int Sayac = 0, Sayac1 = 0, Sayac2 = 0,Kolon=0;
            foreach (var Metin in Dosya.SafeFileName)
            {
                if (Sayac == 0)
                {
                    if (Metin.ToString() != "x" && Metin.ToString() != "X")
                    {
                        eni = eni + Metin.ToString();
                    }
                    else
                    {
                        Sayac = 1;
                    }
                }
                else
                {
                    if (Metin.ToString() != " " && Sayac1 == 0)
                    {
                        boyu = boyu + Metin.ToString();
                    }
                    else
                    {
                        Sayac1 = 1;
                        if (Metin.ToString() != "." && Sayac2 == 0)
                        {
                            Adi = Adi + Metin.ToString();
                        }
                        else { Sayac2 = 1; }
                    }
                }
            }
            double en = Convert.ToDouble(eni), boy = Convert.ToDouble(boyu);
            double Metrekaresi = Math.Round(((en * boy) / 100) / 100, 2);//çok önemli metrekare hesabı
            Tablosu.Rows.Add(eni + "X" + boyu, Adi, Metrekaresi.ToString());
            Kolon++;
            Sayac = 0;
            Sayac1 = 0;
            Sayac2 = 0;
            gridControl1.DataSource = Tablosu;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult uyari = new DialogResult();
            uyari= MessageBox.Show("Tüm Tablo Silenecek Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                gridControl1.DataSource = null;
            }
        }

        private void yeniSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Microsoft Excel Engine|*.xlsx";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)

            {
                gridControl1.ExportToXlsx(save.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tablosu.Columns.Add("Ölçü", typeof(string));
            Tablosu.Columns.Add("Firma Adı", typeof(string));
            Tablosu.Columns.Add("Metre Kare", typeof(string));
            gridControl1.DataSource = Tablosu;
        }
    }
}
