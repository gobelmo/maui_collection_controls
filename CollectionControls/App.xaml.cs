namespace CollectionControls;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new Carousel();
		//MainPage = new ListView();
		//MainPage = new CollectionView();
		//MainPage = new Picker();
		MainPage = new TableView();
	}
}
