using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSortColors
{
    public partial class Form1 : Form
    {
        int panelBorder = 10;
        int[] values;
        Random random = new Random();
        private System.Drawing.Bitmap myBitmap;
        List<Sort> sorts = new List<Sort>();

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelContainer.Width = this.ClientRectangle.Width - panelContainer.Location.X - panelBorder;
            panelContainer.Height = this.ClientRectangle.Height - panelContainer.Location.Y - panelBorder;

            pbImage.Width = panelContainer.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            pbImage.Height = panelContainer.ClientRectangle.Height * panelContainer.ClientRectangle.Height;

            values = new int[pbImage.Width];

            myBitmap = new Bitmap(pbImage.Width,
            pbImage.Height,
            System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics graphicsObj;

            graphicsObj = Graphics.FromImage(myBitmap);
            graphicsObj.Clear(Color.White);
            graphicsObj.Dispose();

            Generate();
            
            foreach(Sort aSort in sorts)
            {
                lbSorts.Items.Add(aSort.name);
            }
            lbSorts.SetSelected(0, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics graphicsObj = Graphics.FromImage(myBitmap))
            {
                graphicsObj.Clear(Color.White);

            }
            Generate();
            
            sorts[lbSorts.SelectedIndex].sort();
            lbNumbers.Items.Clear();
            foreach (int aValue in values)
            {
                lbNumbers.Items.Add(aValue);
            }
            Refresh();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelContainer.Width = this.ClientRectangle.Width - panelContainer.Location.X - panelBorder;
            panelContainer.Height = this.ClientRectangle.Height - panelContainer.Location.Y - panelBorder;
        }

        private void Generate()
        {
            pbImage.Width = panelContainer.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            pbImage.Height = panelContainer.ClientRectangle.Height * panelContainer.ClientRectangle.Height;

            values = new int[pbImage.Width];

            myBitmap = new Bitmap(pbImage.Width,
            pbImage.Height,
            System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = i;
            }
            for (int i = 0; i < values.Length * 2; i++)
            {
                int j = random.Next(values.Length);
                int w = random.Next(values.Length);
                int temp = values[j];
                values[j] = values[w];
                values[w] = temp;
            }

            foreach(int aValue in values)
            {
                lbNumbers.Items.Add(aValue);
            }
            sorts.Clear();
            sorts.Add(new BubbleSort(values, myBitmap));
            sorts.Add(new SelectionSort(values, myBitmap));
            sorts.Add(new InsertionSort(values, myBitmap));
            sorts.Add(new MergeSort(values, myBitmap));
            sorts.Add(new QuickSort(values, myBitmap));
            sorts.Add(new HeapSort(values, myBitmap));
            sorts.Add(new CombSort(values, myBitmap));
            sorts.Add(new StoogeSort(values, myBitmap));
            sorts.Add(new ShellSort(values, myBitmap));
            sorts.Add(new GnomeSort(values, myBitmap));
        }

        private void pbImage_Paint(object sender, PaintEventArgs e)
        {
            pbImage.Height = sorts[lbSorts.SelectedIndex].depth + 1;
            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(myBitmap, 0, 0, myBitmap.Width, myBitmap.Height);
        }
    }
}
