using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Appocolypse
{
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		#region BackingVariables

		private const string VERSION_NUMBER = "v0.0.0";

		private string _bgColorHex = "#888";
		private string _titleText = $"Appocolypse {VERSION_NUMBER}";

		#endregion

		#region Properties

		public string BgColorHex
		{
			get
			{
				return _bgColorHex;
			}

			private set
			{
				_bgColorHex = value;
				OnPropertyChanged();
			}
		}

		public string TitleText
		{
			get
			{
				return _titleText;
			}

			private set
			{
				_titleText = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		#endregion

		#region Constructors

		public MainWindow ()
		{
			DataContext = this;
			InitializeComponent();
		}

		#endregion

		#region Private Methods

		private void OnPropertyChanged ( [CallerMemberName] string propertyName = "" )
		{
			PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
		}

		#endregion

		#region Private Methods - Clicked

		private void MainMenuItem_ExitClicked ( object sender, RoutedEventArgs e )
		{
			Close();
		}

		#endregion
	}
}