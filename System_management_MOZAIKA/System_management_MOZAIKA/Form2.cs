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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void пАРТНЕРЫBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пАРТНЕРЫBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казенов_Эдуард_Практика_DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ЗАЯВКИ". При необходимости она может быть перемещена или удалена.
            this.зАЯВКИTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ЗАЯВКИ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ПАРТНЕРЫ". При необходимости она может быть перемещена или удалена.
            this.пАРТНЕРЫTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ПАРТНЕРЫ);

        }
    }
}
