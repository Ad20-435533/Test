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
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            LoadStoreItems();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadStoreItems()
        {

            const string conn = "Data Source=localhost; Initial Catalog=ps-base; Integrated Security=True";
            SqlConnection myConn = new SqlConnection(conn);
            myConn.Open();

            const string sqlsellect = "SELECT * FROM [user]";
            SqlCommand command = new SqlCommand(sqlsellect, myConn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            // Примерные данные для товаров
            var products = new[]
            {
                new { ImagePath = @"C:\Images\product1.jpg", Name = "Продукт 1", Description = "Описание продукта 1", Manufacturer = "Производитель 1", Price = "$100" },
                new { ImagePath = @"C:\Images\product2.jpg", Name = "Продукт 2", Description = "Описание продукта 2", Manufacturer = "Производитель 2", Price = "$200" },
                new { ImagePath = @"C:\Images\product3.jpg", Name = "Продукт 3", Description = "Описание продукта 3", Manufacturer = "Производитель 3", Price = "$300" }
            };

            // Добавляем товары в FlowLayoutPanel
            foreach (var product in products)
            {
                AddProductToPanel(flowLayoutPanel1, product.ImagePath, product.Name, product.Description, product.Manufacturer, product.Price);
            }
        }

        private void AddProductToPanel(FlowLayoutPanel panel, string imagePath, string name, string description, string manufacturer, string price)
        {
            // Создаем TableLayoutPanel для одного товара
            TableLayoutPanel productPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Top,                  // Панель будет растягиваться по ширине
                ColumnCount = 3,                        // 3 колонки: картинка, описание, цена
                RowCount = 1,                           // 1 строка для всех элементов
                AutoSize = true,                        // Автоматическая подстройка размера
                Padding = new Padding(10),              // Отступы внутри
                BackColor = Color.White,
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Percent, 15), // Ширина для картинки
                    new ColumnStyle(SizeType.Percent, 70),   // 70% ширины для текста (название, описание, производитель)
                    new ColumnStyle(SizeType.Percent, 14)   // Фиксированная ширина для цены
                }

            };

            // Создаем PictureBox для картинки товара
            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(imagePath),        // Загружаем картинку
                SizeMode = PictureBoxSizeMode.StretchImage, // Растягиваем картинку по размерам
                Width = 150,                              // Фиксированная ширина
                Height = 150,                             // Фиксированная высота
                Margin = new Padding(0)                   // Без отступов
            };

            // Создаем TableLayoutPanel для текста (название, описание, производитель)
            TableLayoutPanel textPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,                    // Заполняет всю доступную ширину
                RowCount = 3,                             // Три строки: название, описание, производитель
                ColumnCount = 1,                          // Одна колонка
                AutoSize = true,                          // Автоматическая подстройка размера
                Padding = new Padding(5)
            };

            // Создаем метки для названия товара, описания и производителя
            Label nameLabel = new Label
            {
                Text = name,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 5)  // Отступ снизу
            };

            Label descriptionLabel = new Label
            {
                Text = description,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 5)  // Отступ снизу
            };

            Label manufacturerLabel = new Label
            {
                Text = manufacturer,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 5)  // Отступ снизу
            };

            // Добавляем метки в TableLayoutPanel для текста
            textPanel.Controls.Add(nameLabel, 0, 0);
            textPanel.Controls.Add(descriptionLabel, 0, 1);
            textPanel.Controls.Add(manufacturerLabel, 0, 2);

            // Создаем метку для цены товара
            Label priceLabel = new Label
            {
                Text = price,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Margin = new Padding(0)
            };

            // Добавляем элементы в TableLayoutPanel для товара
            productPanel.Controls.Add(pictureBox, 0, 0);
            productPanel.Controls.Add(textPanel, 1, 0);  // Добавляем TableLayoutPanel с текстом
            productPanel.Controls.Add(priceLabel, 2, 0);

            // Добавляем TableLayoutPanel на FlowLayoutPanel
            panel.Controls.Add(productPanel);
        }
    }
}
