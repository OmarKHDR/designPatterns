// the program is about an app with multiple themes 
// user can edit existing themes with the colors he wants

namespace Prototype
{
	abstract class Theme
	{
		public string Color;
		public string Type;
		public virtual void Display()
		{
			Console.WriteLine($"the theme is a {this.Color} {this.Type}");
		}
		public abstract Theme Clone();
	}

	class DarkAesthetic: Theme
	{
		public DarkAesthetic()
        {
            this.Color = "Black";
            this.Type = "Dark Aesthetic";
        }
        public override Theme Clone()
        {
            return new DarkAesthetic();
        }
    }


	class LightModern: Theme
	{
		public LightModern()
		{
			this.Color = "White";
			this.Type = "Modern";
		}
        public override Theme Clone()
        {
            return new LightModern();
        }
    }

	class Creator
	{
		private readonly Theme theme;

		public Creator(Theme t)
		{
			this.theme = t;
		}

		public Theme GetClone()
		{
			return this.theme.Clone();
		}

	}


    class Program
    {
        static void Main(string[] args)
        {
            Theme darkTheme = new DarkAesthetic();
            Creator creator = new Creator(darkTheme);

            Theme clonedTheme = creator.GetClone();
            clonedTheme.Display();
        }
    }
}
