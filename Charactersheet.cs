class Charactersheet

{

    //Constructor
    public Charactersheet()
    {

    }
    //Ability scores
    private static readonly string[] abilityScoreNames = new string[6] { "Strength", "Dexterity", "Constitution", "Wisdom", "Intelligence", "Charisma" };


    public string[] AbilityScoreNames
    {
        get { return abilityScoreNames; }
        set { Console.WriteLine("This property is not accessable."); }
    }





    //Skills
    public string[] skillNames = new string[18] { "Athletics", "Acrobatics", "Sleight of Hand", "Stealth", "Arcana", "History", "Investigation", "Nature", "Religion", "Animal Handling", "Insight", "Medicine", "Perception", "Survival", "Deception", "Intimidation", "Performance", "Persuasion" };
    public int[] skilltoability = new int[18] { 1, 2, 2, 2, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6 };

}