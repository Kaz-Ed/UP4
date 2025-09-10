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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void пРОДУКЦИЯBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пРОДУКЦИЯBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казенов_Эдуард_Практика_DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ПРОДУКЦИЯ". При необходимости она может быть перемещена или удалена.
            this.пРОДУКЦИЯTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ПРОДУКЦИЯ);

        }
    }
}
