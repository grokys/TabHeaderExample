using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace TabHeaderExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            var tabPage1 = new TabItem
            {
                Header = new TabPageHeaderModel("Page One", @"Assets\avalonia-32.png"),
                Content = new Button
                {
                    Content = "Example content",
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                }
            };

            var tabControl = new TabControl();
            tabControl.Items = new[] { tabPage1 };
            Content = tabControl;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

    public class TabPageHeaderModel
    {
        public TabPageHeaderModel(string title, string imageFilename)
        {
            Title = title;
            Image = new Bitmap(imageFilename);
        }

        public string Title { get; }
        public IImage Image { get; }
    }
}