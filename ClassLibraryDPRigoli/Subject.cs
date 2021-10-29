struct Subject
{
    private string _name;
    private string _code;

    public Subject(string n, string c)
    {
        this._name = n;
        this._code = c;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Code
    {
        get => _code;
        set => _code = value;
    }

    override
    public string ToString()
    {
        return _code + "," + _name;
    }
}