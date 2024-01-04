namespace MAUIIsEnabled;

public partial class DisabledPage : ContentPage
{
	public List<Item> Items { get; set; }

	public DisabledPage()
	{
		Items =
		[
			new Item { Name = "Item 1" },
			new Item { Name = "Item 2" },
			new Item { Name = "Item 3" },
			new Item { Name = "Item 4" },
		];

		BindingContext = this;

		InitializeComponent();
	}
}