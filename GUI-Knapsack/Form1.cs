using dotnet_lab2;

namespace GUI_Knapsack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "" || seedTextBox.Text == "" || capacityTextBox.Text == "")
            {
                MessageBox.Show("Wszystkie pola musz� by� wype�nione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numberOfItems = int.Parse(numberTextBox.Text);
            int seed = int.Parse(seedTextBox.Text);
            int capacity = int.Parse(capacityTextBox.Text);

            // Check if the number of items is greater than 0
            if (numberOfItems <= 0)
            {
                MessageBox.Show("Ilo�� przedmiot�w musi by� wi�ksza ni� 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the seed is greater than 0
            if (seed <= 0)
            {
                MessageBox.Show("Ziarno musi by� wi�ksze ni� 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the capacity is greater than 0
            if (capacity <= 0)
            {
                MessageBox.Show("Pojemno�� musi by� wi�ksza ni� 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Problem problem = new(numberOfItems, seed);

            List<Item> items = problem.Items;

            itemsListBox.Items.Clear();
            foreach (Item item in items)
            {
                itemsListBox.Items.Add(item.ToString());
            }

            Result result = problem.Solve(capacity);

            List<Item> selectedItems = result.SelectedItems;

            resultListBox.Items.Clear();
            foreach (Item item in selectedItems)
            {
                resultListBox.Items.Add(item.ToString());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemsListBox.Items.Clear();
            resultListBox.Items.Clear();
            numberTextBox.Text = "";
            seedTextBox.Text = "";
            capacityTextBox.Text = "";
        }
    }
}
