using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
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
                // Read the authors and their books from the file.
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                Authors author = new Authors("");
                


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Saving authors with their books to a file.
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (var author in _authors)
                {
                    sw.WriteLine(author.Name);
                    foreach (var book in author.BooksList)
                    {
                        sw.WriteLine(book.Name);
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Filtration_checkBox1_Click(object sender, EventArgs e)
        {
            // Display books in listBox1 by a specific author (filter books by the selected author from comboBox1).

            if (Filtration_checkBox1.Checked)
            {
                Filtration_checkBox1.Text = "Filtration ON";
                Filtration_checkBox1.ForeColor = Color.Green;

                listBox1.Items.Clear();
                foreach (var item in _authors)
                {
                    if (item.Name == comboBox1.Text)
                    {
                        foreach (var item2 in item.BooksList)
                        {
                            listBox1.Items.Add(item2.Name);
                        }
                    }
                }
            }
            else
            {
                Filtration_checkBox1.Text = "Filtration OFF";
                Filtration_checkBox1.ForeColor = Color.Red;

                listBox1.Items.Clear();
                foreach (var item in _authors)
                {
                    foreach (var item2 in item.BooksList)
                    {
                        listBox1.Items.Add(item2.Name);
                    }
                }
            }
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
                DialogResult res = MessageBox.Show("Are you sure you want to remove the author ?", "Delete author !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                editForm2.TextBox1Text = (string)comboBox1.SelectedItem;
                string oldName = (string)comboBox1.SelectedItem;

                DialogResult res = editForm2.ShowDialog();
                if (res == DialogResult.OK)
                {
                    foreach (var item in _authors)
                        if (item.Name == oldName)
                            item.Name = editForm2.TextBox1Text;
                    for (var i = 0; i < comboBox1.Items.Count; i++)
                    {
                        var item = comboBox1.Items[i];
                        if (comboBox1.Items[i] == oldName)
                            comboBox1.Items[i] = editForm2.TextBox1Text;
                    }
                    comboBox1.SelectedItem = comboBox1?.Items[0];
                }
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_authors.Count != 0)
            {
                Form2 addForm2 = new Form2();
                addForm2.Text = "Adding a new book.";
                addForm2.Label1Text = "Enter book name: ";

                DialogResult res = addForm2.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // Добавить книгу в список книг автора (выбранного в комбобоксе), если такой книги нет.

                    foreach (var item in _authors)
                    {
                        if (item.Name == comboBox1.SelectedItem)
                        {
                            foreach (var books in item.BooksList)
                            {
                                while (books.Name == addForm2.TextBox1Text)
                                {
                                    if (books.Name == addForm2.TextBox1Text)
                                        MessageBox.Show("This book already exists.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    addForm2.ShowDialog();
                                }
                            }
                            Books book = new Books(addForm2.TextBox1Text);
                            item.BooksList.Add(book);
                            listBox1.Items.Add(book.Name);
                        }
                    }
                }
            }
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_authors.Count != 0)
            {
                if (listBox1.Items.Count != 0)
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to remove the book ?", "Delete book !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        foreach (var item in _authors)
                        {
                            for (var i = 0; i < item.BooksList.Count; i++)
                            {
                                if (item.BooksList[i].Name == listBox1.SelectedItem)
                                {
                                    listBox1.Items.Remove(item.BooksList[i].Name);
                                    item.BooksList.RemoveAt(i);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_authors.Count != 0)
            {
                if (listBox1.Items.Count != 0)
                {
                    Form2 editForm2 = new Form2();
                    editForm2.Text = "Edit book data.";
                    editForm2.Label1Text = "Edit book name: ";

                    editForm2.TextBox1Text = (string)listBox1.SelectedItem;
                    string oldName = (string)listBox1.SelectedItem;

                    DialogResult res = editForm2.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        foreach (var item in _authors)
                        {
                            if (item.Name == comboBox1.SelectedItem)
                            {
                                foreach (var books in item.BooksList)
                                {
                                    if (books.Name == oldName)
                                        books.Name = editForm2.TextBox1Text;
                                }
                                for (var i = 0; i < listBox1.Items.Count; i++)
                                {
                                    var item1 = listBox1.Items[i];
                                    if (listBox1.Items[i] == oldName)
                                        listBox1.Items[i] = editForm2.TextBox1Text;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}