using Xamarin.Forms.CustomAttributes;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

#if UITEST
using Xamarin.Forms.Core.UITests;
using Xamarin.UITest;
using NUnit.Framework;
#endif

namespace Xamarin.Forms.Controls.Issues
{
#if UITEST
	[Category(UITestCategories.ManualReview)]
	[Category(UITestCategories.Brush)]
#endif
#if APP
	[XamlCompilation(XamlCompilationOptions.Compile)]
#endif
	[Preserve(AllMembers = true)]
	[Issue(IssueTracker.Github, 12538, "[Bug] Shapes do not work with StaticResource Fill Colour ", PlatformAffected.All)]
	public partial class Issue12538 : TestContentPage
	{
		public Issue12538()
		{
#if APP
			InitializeComponent();
#endif
		}

		protected override void Init()
		{
	
		}
	}
}