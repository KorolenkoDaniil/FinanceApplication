using SQLite;


namespace FinS.Models
{
    [Table("Colors")]
    public class ColorClass
    {
        [PrimaryKey]
        public int Id { get; set;}
        public string Name { get;  set;}
        public string DarkMode { get;  set;}
        public string LightMode { get; set;}
        public string DarkText { get; set;}
        public string LightText { get; set; }

        public ColorClass(int id, string name, string darkMode, string lightMode, string darkText, string lightText)
        {
            Id = id;
            Name = name;
            DarkMode = darkMode;
            LightMode = lightMode;
            DarkText = darkText;
            LightText = lightText;
        }
        public ColorClass () { }

        public override string ToString()
        {
            return $"{Id} {Name} {DarkMode} {LightMode} {DarkText}";
        }
    }
}

