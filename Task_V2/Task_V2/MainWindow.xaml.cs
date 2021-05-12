using System.Windows;
using System.Windows.Controls;

namespace Task_V2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static MainWindow _MainWindow;

        public MainWindow()
        {
            InitializeComponent();
            _MainWindow = this;
        }

        public static ListBox ListBox()
        {
            return _MainWindow.ListBox1;
        }
        private void Message_Click(object sender, RoutedEventArgs e)
        {
            string p1 = @"TextFile1.txt";
            WorkWithFile rd = new WorkWithFile(p1);
            _ = new TrafficPolicePost[rd.QntLine()];
            TrafficPolicePost[] trafficPolicePosts = rd.WriteToFile();

            Aggregator aggregator = new Aggregator();
            foreach (var post in trafficPolicePosts)
                aggregator.Subscribe(post);

            string text = "";
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                text = TextBox1.Text.Trim();
                ListBox1.Items.Add("Coordinator: " + text);

                Coordinator message = new Coordinator(text);
                aggregator.Notify(message);
            }

            if (!string.IsNullOrEmpty(text))
            {
                bool result = true;

                if (result)
                    TextBox1.Text = " ";
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            _MainWindow.Close();
            Window1.Close();
        }
    }
}
