using System;
using System.Collections.Generic;
using News.Model;
using Xamarin.Forms;

namespace News.View
{
    public partial class OverviewPage : ContentPage
    {
        public OverviewPage(string NewsPageType)
        {
            InitializeComponent();
            GetNewsPage(NewsPageType);
        }

        public async void GetNewsPage(string pNewsPageType)
        {
            GetSources sourceWired = new GetSources();

            if (pNewsPageType == "Wired")
            {
                sourceWired = await NewsManager.GetSourcesWired();
                lvwNews.ItemsSource = sourceWired.articles;
            }
            else if (pNewsPageType == "NYT")
            {
                sourceWired = await NewsManager.GetSourcesNYT();
                lvwNews.ItemsSource = sourceWired.articles;
            }
        }
    }
}
