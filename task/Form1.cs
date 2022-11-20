using System.Runtime.InteropServices;

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
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open File Processing Logic.

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Save File Processing Logic.

            }
        }
    }
}