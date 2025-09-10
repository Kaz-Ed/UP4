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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void мАТЕРИАЛЫBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.мАТЕРИАЛЫBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казенов_Эдуард_Практика_DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ПОСТАВКИ". При необходимости она может быть перемещена или удалена.
            this.пОСТАВКИTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ПОСТАВКИ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ПОСТАВЩИКИ". При необходимости она может быть перемещена или удалена.
            this.пОСТАВЩИКИTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ПОСТАВЩИКИ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.МАТЕРИАЛЫ_ПРОДУКЦИЯ". При необходимости она может быть перемещена или удалена.
            this.мАТЕРИАЛЫ_ПРОДУКЦИЯTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.МАТЕРИАЛЫ_ПРОДУКЦИЯ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.МАТЕРИАЛЫ". При необходимости она может быть перемещена или удалена.
            this.мАТЕРИАЛЫTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.МАТЕРИАЛЫ);

        }

        private void пОСТАВЩИКИDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
