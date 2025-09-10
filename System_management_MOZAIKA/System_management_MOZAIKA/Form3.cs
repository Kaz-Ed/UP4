using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_management_MOZAIKA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void сОТРУДНИКИBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сОТРУДНИКИBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казенов_Эдуард_Практика_DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ВХОД". При необходимости она может быть перемещена или удалена.
            this.вХОДTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ВХОД);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ДОСТУП". При необходимости она может быть перемещена или удалена.
            this.дОСТУПTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ДОСТУП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.КАДРЫ". При необходимости она может быть перемещена или удалена.
            this.кАДРЫTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.КАДРЫ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.МЕНЕДЖЕРЫ". При необходимости она может быть перемещена или удалена.
            this.мЕНЕДЖЕРЫTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.МЕНЕДЖЕРЫ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.СОТРУДНИКИ". При необходимости она может быть перемещена или удалена.
            this.сОТРУДНИКИTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.СОТРУДНИКИ);

        }

        private void дОСТУПDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
