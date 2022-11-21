using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace task
{
    /// <summary>
    /// �������� ���������� ������� � �����, ������� ��������� �������� � ��������� ����. 
    /// ���������� ������������� ��������� �����������.
    /// * ���������� ������;                                              // * Adding an author;
    /// * �������������� ������;                                          // * Editing the author;
    /// * �������� ������;                                                // * Removing the author;
    /// * ���������� �������� �����;                                      // * Adding book title;
    /// * �������������� �������� �����;                                  // * Editing the title of the book;
    /// * �������� �������� �����;                                        // * Removing the title of the book;
    /// * ����������� ���� ����;                                          // * Display all books;
    /// * ����������� ���� ����������� ������ (������ ���� �� ������).    // * Display books by a specific author (filter books by author).
    /// * �������� ������ �� �����;                                       // * Loading data from a file;
    /// * ���������� ������ � ����.                                       // * Saving data to a file.
    /// ��� ���������������� ���������� ������ ���� �������� ����������� ����
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
            addForm2.MainForm = this;

            addForm2.Text = "Adding a new author.";
            //addForm2.lab

            DialogResult res = addForm2.ShowDialog();
            if (res == DialogResult.OK)
            {
                Authors author = new Authors(addForm2.TextBox1Text);

                foreach (var item in _authors)
                {
                    if (item.Name == addForm2.TextBox1Text)
                        MessageBox.Show("This author already exists.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _authors.Add(author);
            }
        }

        private void removeAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}