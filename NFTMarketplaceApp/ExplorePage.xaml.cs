namespace NFTMarketplaceApp;

public partial class ExplorePage : ContentPage
{
	public ExplorePage()
	{
		InitializeComponent();
	}
}

public class TopCollectionItem
{
	public string Name { get; set; }
	public string Type { get; set; }
	public decimal Price { get; set; }
	public string Currency { get; set; }
	public string CurrencyName { get; set; }
	public bool IsUp { get; set; }
	public decimal Change { get; set; }
}
