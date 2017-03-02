using System;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			InitializeComponent();
		}

		void Handle_Appearing(object sender, System.EventArgs e)
		{
			NaviPage.Effects.Add(new ShadowEffect()
			{
				Radius = 15,
				DistanceX = -20,
				DistanceY = 0,
				Color = Color.Black
			});
		}
	}
}
