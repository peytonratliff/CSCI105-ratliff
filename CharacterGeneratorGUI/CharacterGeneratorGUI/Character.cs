class Character
{
    //Properties
    public string Name { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intellect { get; set; }
    public int Stamina { get; set; }
    public string Gender { get; set; }

    //Contructor
    public Character() { } //Default constructor

    public Character(string fname, string lname, string race)
    {
        Name = fname;
        Name = lname;
        Race = race;
    }

    //Methods
    public void FullName()
    {
    }
}