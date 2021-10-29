struct Student
{

    private string _name;
    private string _class;
    private string _section;

    public Student(string name, string c, string section)
    {
        _name = name;
        _class = c;
        _section = section;

    }

    override
    public string ToString()
    {
        return " Name:" + _name + "; Class:" + _class + "; Section:" + _section + ";";
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Class
    {
        get => _class;
        set => _class = value;
    }

    public string Section
    {
        get => _section;
        set => _section = value;
    }
}