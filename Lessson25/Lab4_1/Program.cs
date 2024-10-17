namespace Lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao window
            Window win = new Window(1,2);
            //khoi tao listbox
            ListBox lb = new ListBox(3,4,"Stand alone list box");
            //khoi tao button
            Button b = new Button(5, 6);

            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();
            //khoi tao mag window
            Window[] winArray = new Window[3];
            winArray[0] = new Window(1,2);
            winArray[1] = new ListBox(3, 4, "Stand alone list box");
            winArray[2] = new Button(5,6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }



        }
    }
}
