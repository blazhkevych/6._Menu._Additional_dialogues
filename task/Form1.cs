using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task
{
    /// <summary>
    /// Написать приложение «Авторы и книги», которое позволяет работать с каталогом книг. 
    /// Приложение предоставляет следующие возможности.
    /// * Добавление автора;                                              // * Adding an author;
    /// * Редактирование автора;                                          // * Editing the author;
    /// * Удаление автора;                                                // * Removing the author;
    /// * Добавление названия книги;                                      // * Adding book title;
    /// * Редактирование названия книги;                                  // * Editing the title of the book;
    /// * Удаление названия книги;                                        // * Removing the title of the book;
    /// * Отображение всех книг;                                          // * Display all books;
    /// * Отображение книг конкретного автора (фильтр книг по автору).    // * Display books by a specific author (filter books by author).
    /// * Загрузка данных из файла;                                       // * Loading data from a file;
    /// * Сохранение данных в файл.                                       // * Saving data to a file.
    /// Вся функциональность приложения должна быть доступна посредством меню
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _authors = new List<Authors>();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open File Processing Logic.

                //OpenFileDialog f1;


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Save File Processing Logic.

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Filtration_checkBox1_Click(object sender, EventArgs e)
        {
            // Logic for filter on/off.

        }

        private List<Authors> _authors;

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addForm2 = new Form2();
            addForm2.Text = "Adding a new author.";
            addForm2.Label1Text = "Enter author name: ";

            DialogResult res = addForm2.ShowDialog();
            if (res == DialogResult.OK)
            {
                foreach (var item in _authors)
                {
                    while (item.Name == addForm2.TextBox1Text)
                    {
                        if (item.Name == addForm2.TextBox1Text)
                            MessageBox.Show("This author already exists.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        addForm2.ShowDialog();
                    }
                }
                Authors author = new Authors(addForm2.TextBox1Text);
                _authors.Add(author);
                this.comboBox1.Items.Add(author.Name);
                comboBox1.SelectedItem = comboBox1?.Items[0];
            }
        }

        private void removeAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_authors.Count != 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to remove the author?", "Delete author !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    for (var i = 0; i < _authors.Count; i++)
                    {
                        if (_authors[i].Name == comboBox1.SelectedItem)
                        {
                            comboBox1.Items.Remove(_authors[i].Name);
                            _authors.RemoveAt(i);
                        }
                    }
                    comboBox1.SelectedItem = comboBox1?.Items[0];
                }
            }
        }

        private void editAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_authors.Count != 0)
            {
                Form2 editForm2 = new Form2();
                editForm2.Text = "Edit author data.";
                editForm2.Label1Text = "Edit author name: ";

                editForm2.TextBox1Text = ((Authors)comboBox1.SelectedItem).Name;
                string oldName = ((Authors)comboBox1.SelectedItem).Name;

                DialogResult res = editForm2.ShowDialog();
                if (res == DialogResult.OK)
                {
                    ((Authors)comboBox1.SelectedItem).Name = editForm2.TextBox1Text;
                    foreach (var item in _authors)
                        if (item.Name == oldName)
                            item.Name = editForm2.TextBox1Text;
                }
            }
        }
    }
}