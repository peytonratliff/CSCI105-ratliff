class Character
{
    //Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Race { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intellect { get; set; }
    public string Helm { get; set; }
    public string Chest { get; set; }
    public string Legs { get; set; }
    public string Feet { get; set; }

    //Contructor
    public Character() { } //Default constructor

    public Character(string fname, string lname, string race)
    {
        FirstName = fname;
        LastName = lname;
        Race = race;
    }

    //Methods
    public string FullName()
    {
        return FirstName + " " + LastName;
    }
}