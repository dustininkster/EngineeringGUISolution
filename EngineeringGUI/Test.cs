using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringGUI
{
    static class Test
    {
        static MainForm gui = Program.main;
        public static void UserSettings()
        {
            List<string> listOfStrings = new List<string>();
            for (int i =0; i < 10; i++)
            {
                listOfStrings.Add("Item " + i);
            }
            gui.AddNewTab();
            gui.UpdateSelections(0, listOfStrings.ToArray());
        }
    }
}
