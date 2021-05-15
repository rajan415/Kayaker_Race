using System;

namespace Kayaker_Race
{
    // 3 classes, 1 for each bettor settor there cash amount, their names and setting labelmax from Guy class
    public class Steve : Guy
    {
        public Steve()
        {
            PlayerName = "Steve";
            Cash = 50;
            Labelmax.Text = Convert.ToString(Cash);
       }
    }

    public class Allan : Guy
    {
        public Allan()
        {
            PlayerName = "Allan";
            Cash = 50;
            Labelmax.Text = Convert.ToString(Cash);
        }
    }

    public class Dax : Guy
    {
        public Dax()
        {
            PlayerName = "Dax";
            Cash = 50;
            Labelmax.Text = Convert.ToString(Cash);
        }
    }
}
