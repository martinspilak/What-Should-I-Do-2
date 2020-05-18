using System;
using Xamarin.Forms;

namespace What_Should_I_Do
{
    public class ReminderColor 
    {
        public static Color[] colors = { Color.LightBlue, Color.LightGreen, Color.LightYellow, Color.LightPink, Color.LightSalmon, Color.LightSkyBlue };
        public static Color RandomColor => GetRandomColor();

        public static Color GetRandomColor()
        {
            var random = new Random();
            return colors[random.Next(colors.Length)];
        }        
    }
}
