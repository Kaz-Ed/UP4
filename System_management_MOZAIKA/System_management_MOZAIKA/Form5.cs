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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казенов_Эдуард_Практика_DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ЦЕН". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ЦЕНTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ЦЕН);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГА". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ЦЕН". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ЦЕНTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ЦЕН);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ЦЕН". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ЦЕНTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ЦЕН);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГА". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ЦЕН". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ЦЕНTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ЦЕН);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГА". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАTableAdapter.Fill(this.казенов_Эдуард_Практика_DataSet.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГА);

        }

        private void иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казенов_Эдуард_Практика_DataSet);

        }

        private void иСТОРИЯ_ЦЕНBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.иСТОРИЯ_ЦЕНBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казенов_Эдуард_Практика_DataSet);

        }

        private void иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казенов_Эдуард_Практика_DataSet);

        }
    }
}
