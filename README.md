```cs
public partial class Form1 : Form
{
    Random random;

    public Form1()
    {
        InitializeComponent();
        random = new();
    }

    private void button1_MouseMove(object sender, MouseEventArgs e)
    {
        int newX = random.Next(ClientSize.Width - button1.Width);
        int newY = random.Next(ClientSize.Height - button1.Height);

        button1.Location = new Point(newX, newY);
    }
}
```
[![photo-2023-05-17-18-57-31.jpg](https://i.postimg.cc/rFfpXWSY/photo-2023-05-17-18-57-31.jpg)](https://postimg.cc/9rq2yDgG)
