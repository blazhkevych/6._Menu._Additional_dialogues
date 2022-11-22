namespace task;

internal class Authors
{
    // Author's book list.
    public List<Books> BooksList;

    // Constructor.
    public Authors(string name)
    {
        Name = name;
        BooksList = new List<Books>();
    }

    public string Name { get; set; } = "Some name";
}