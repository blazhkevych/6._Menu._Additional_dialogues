using System.Runtime.InteropServices;
using System.Text;

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
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open File Processing Logic.

                OpenFileDialog f1;


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

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}