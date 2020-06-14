using System;
using System.Windows.Forms;
// Создаем шаблон приложения, где подключаем модули
namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            Boolean isNegaive = width < 0 || height < 0;
            Boolean isBig = width > 1000 || height > 1000;

            if (isNegaive || isBig)
            {
                //throw new ArgumentOutOfRangeException();
            }
            */
            Form form = new Form
            {
                Width = 800,
                Height = 600
            };
            Game.Init(form);
            form.Show();
            Game.Load();
            Game.Draw();
            Application.Run(form);
        }
    }
}