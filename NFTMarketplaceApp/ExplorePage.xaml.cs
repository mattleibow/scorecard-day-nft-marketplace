using System.Collections.ObjectModel;
using System.Globalization;

namespace NFTMarketplaceApp;

public partial class ExplorePage : ContentPage
{
	public ExplorePage()
	{
		InitializeComponent();

		BindingContext = this;
	}

	public ObservableCollection<TopCollectionItem> TopItems { get; } = new()
	{
		new TopCollectionItem
		{
			Name = "Bear Baron",
			Type = "Art Collectible",
			Price = 1920.14m,
			Currency = "$",
			CurrencyName = "ETH",
			Change = 14.90m
		},
		new TopCollectionItem
		{
			Name = "Battle Bear",
			Type = "AI Collectible",
			Price = 1750.08m,
			Currency = "$",
			CurrencyName = "ETH",
			Change = -9.62m
		},
		new TopCollectionItem
		{
			Name = "Grand Bear",
			Type = "Art Collectible",
			Price = 1287.34m,
			Currency = "$",
			CurrencyName = "ETH",
			Change = 0.0m
		},
		new TopCollectionItem
		{
			Name = "Bear Baron",
			Type = "Art Collectible",
			Price = 1920.14m,
			Currency = "$",
			CurrencyName = "ETH",
			Change = 14.90m
		},
		new TopCollectionItem
		{
			Name = "Bear Baron",
			Type = "Art Collectible",
			Price = 1920.14m,
			Currency = "$",
			CurrencyName = "ETH",
			Change = 14.90m
		},
	};

	private void OnTabTapped(object? sender, TappedEventArgs e)
	{
		// DisplayAlert("Tab Tapped: " + sender, "Tab Tapped! " + e.Parameter, "OK");
		var label = (Label)sender!;
		var tabbar = (Grid)label.Parent;
		var selected = (string)e.Parameter!;

		foreach (var item in tabbar.Children)
		{
			if (item is Label tabItem)
			{
				if (tabItem.StyleClass.Contains(selected))
				{
					tabItem.IsVisible = true;
					tabItem.TextColor = Colors.White;
				}
				else
				{
					tabItem.TextColor = Colors.Black;
					if (tabItem.StyleClass.Contains("Text"))
					{
						tabItem.IsVisible = false;
					}
				}
			}
		}
	}
}

public class TopCollectionItem
{
	public string Name { get; set; }
	public string Type { get; set; }
	public decimal Price { get; set; }
	public string Currency { get; set; }
	public string CurrencyName { get; set; }
	public decimal Change { get; set; }
}

public class ChangeColorConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		if (value is decimal change)
		{
			return change switch
			{
				> 0 => Color.FromHex("#00C48C"),
				< 0 => Color.FromHex("#FF3B30"),
				_ => Color.FromHex("#FF9500")
			};
		}

		return Color.FromHex("#FF9500");
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}

public class ChangeArrowConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		if (value is decimal change)
		{
			return change switch
			{
				> 0 => "\uf062",
				< 0 => "\uf063",
				_ => ""
			};
		}

		return "";
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}