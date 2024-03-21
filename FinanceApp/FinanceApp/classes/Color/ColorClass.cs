namespace FinanceApp.classes.Color
{
    public class ColorClass
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string DarkMode { get; private set; }
        public string LightMode { get; private set; }
        public string DarkText { get; private set; }
        public string LightText { get; private set; }



        public ColorClass(int id, string name, string darkMode, string lightMode, string darkText, string lightText)
        {
            Id = id;
            Name = name;
            DarkMode = darkMode;
            LightMode = lightMode;
            DarkText = darkText;
            LightText = lightText;
        }


        public override string ToString()
        {
            return $"{Id} {Name} {DarkMode} {LightMode} {DarkText}";
        }
    }
}
