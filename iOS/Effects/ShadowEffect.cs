using System;
using System.Linq;
using CoreGraphics;
using MasterDetailPageNavigation.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("MasterDetailPageNavigation")]
[assembly: ExportEffect(typeof(PanelShadowEffect), "PanelShadowEffect")]
namespace MasterDetailPageNavigation.iOS
{
	public class PanelShadowEffect : PlatformEffect
	{
		protected override void OnAttached()
		{
			try
			{
				var effect = (ShadowEffect)Element.Effects.FirstOrDefault(e => e is ShadowEffect);
				if (effect == null)
				{
					return;
				}

				// This doesn't work either
				Container.Layer.CornerRadius = effect.Radius;
				Container.Layer.ShadowColor = effect.Color.ToCGColor();
				Container.Layer.ShadowOffset = new CGSize(effect.DistanceX, effect.DistanceY);
				Container.Layer.ShadowOpacity = .5f;
				Container.Layer.MasksToBounds = false;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: {0}", ex.Message);
			}
		}

		protected override void OnDetached()
		{
		}
	}
}

