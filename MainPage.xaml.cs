using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fonts;

namespace MauiSwipeViewIcon;

public partial class MainPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	public ViewModel ViewModel { get; } = new();
}

public partial class ViewModel : ObservableObject
{
	[ObservableProperty]
	private Color _iconColor = Colors.Black;
	
	[ObservableProperty]
	private string _icon = FluentUI.delete_24_regular;

	[RelayCommand]
	private void ChangeIconColor()
	{
		var rnd = new Random();
		
		this.IconColor = new Color(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
	}

	[RelayCommand]
	private void ChangeIcon()
	{
		var rnd = new Random();

		var icons = new[]
		{
			FluentUI.headphones_24_regular,
			FluentUI.plant_grass_24_regular,
			FluentUI.balloon_24_regular,
		};
		
		this.Icon = icons[rnd.Next(0, icons.Length)];
	}
}

