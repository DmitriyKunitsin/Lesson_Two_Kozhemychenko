namespace Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNumber.Text != "" && textBoxSecondNumber.Text != "")
            {
                ListElement el = new ListElement();
                el.First = Convert.ToDouble(textBoxFirstNumber.Text);
                el.Second = Convert.ToDouble(textBoxSecondNumber.Text);

                listBoxItems.Items.Add(el);
            }
            else
            {
                MessageBox.Show("Обе части элемента должны быть указаны!", "Внимание!");
            }
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItems.Count != 0)
            {
                listBoxItems.Items.Remove(listBoxItems.SelectedItem);
            }
            else
            {
                MessageBox.Show("Не выбран элемент!", "Внимание!");
            }
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool atLeastOneNumberProceeded = false;
            foreach (ListElement item in listBoxItems.Items)
            {
                if (item.First % 1 > item.Second % 1)
                {
                    result += Convert.ToInt32(item.Second);
                    atLeastOneNumberProceeded = true;
                }
            }
            textBoxResult.Text = atLeastOneNumberProceeded ? result.ToString() : "Ответ не найден";
        }
    }
}
