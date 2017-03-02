using System;
using System.Linq;
using CoreGraphics;
using MasterDetailPageNavigation.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(ShadowEffect), "ShadowEffect")]
namespace MasterDetailPageNavigation.iOS
{
public class ShadowEffect : RoutingEffect
	{
		public float Radius { get; set; }
		public Color Color { get; set; }
		public float DistanceX { get; set; }
		public float DistanceY { get; set; }
		public ShadowEffect() : base("MasterDetailPageNavigation.iOS.PanelShadowEffect")
		{
		}
	}
}
