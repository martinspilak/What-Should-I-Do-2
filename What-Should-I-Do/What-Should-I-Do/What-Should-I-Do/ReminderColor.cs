using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace What_Should_I_Do
{
    public class ReminderColor 
    {
        static Color[] colors = { Color.Red, Color.Green};
        public static Color GetRandomColor()
        {
            var random = new Random();
            return colors[random.Next(colors.Length)];
        }        
    }
}
