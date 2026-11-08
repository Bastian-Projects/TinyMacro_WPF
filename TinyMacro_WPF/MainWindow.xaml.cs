using System.Collections.ObjectModel;
using System.Windows;

namespace MacroRecorder
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<MacroAction> RecordedActions { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            RecordedActions = new ObservableCollection<MacroAction>();
            ActionListView.ItemsSource = RecordedActions;
        }

        private void OnPlayClick(object sender, RoutedEventArgs e)
        {
            // Logik zum Abspielen der MacroActions einbauen
        }

        private void OnRecordClick(object sender, RoutedEventArgs e)
        {
            // Logik zum Starten der Hook-Aufnahme einbauen
        }

        private void OnStopClick(object sender, RoutedEventArgs e)
        {
            // Aufnahme oder Wiedergabe stoppen
        }
    }
}