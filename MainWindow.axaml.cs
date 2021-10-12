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

            var tabControl = (TabControl)Content;

            tabControl.Items = new[] 
            { 
                new SymbolTabPage("Page One", @"Assets\avalonia-32.png", new Button { Content = "Hello World!" }) 
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

    public class PlatformControl
    {
        public PlatformControl(object control)
        {
            PlatformImpl = control;
        }

        public object PlatformImpl { get; }
    }

    public class SymbolTabPage
    {
        public SymbolTabPage(string title, string imageFilename, Control content)
        {
            Title = title;
            Image = new Bitmap(imageFilename);
            Content = new PlatformControl(content);
        }

        public string Title { get; }
        public IImage Image { get; }
        public PlatformControl Content { get; }
    }
}