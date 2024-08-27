namespace NFTMarketplaceApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnChevronsSizeChanged(object sender, EventArgs e)
	{
		var chevrons = (Label)sender;

		var width = chevrons.Width;
		gradientOverlay.WidthRequest = width;

		var weakView = new WeakReference<VisualElement>(gradientOverlay);
		
		Animate();

		void Animate()
		{
			var translate = new Animation(
				f =>
				{
					if (weakView.TryGetTarget(out VisualElement? v))
						v.TranslationX = f;
				},
				start: -width * 1.1,
				end: width * 1.1,
				easing: Easing.Linear);

			if (weakView.TryGetTarget(out VisualElement? v))
			{
				translate.Commit(
					owner: v,
					name: "AnimateChevrons",
					rate: 16,
					length: 3000,
					easing: null,
					finished: (f, a) => Animate());
			}
		}
	}

	private void OnGetStartedTapped(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//explore");
	}
}

