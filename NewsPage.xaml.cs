using System.Collections.Generic;
using System.Diagnostics;
using News.Model;
using News.View;
using Xamarin.Forms;

namespace News
{
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
            LoadSourcesBI();
            LoadSourcesNYT();
            LoadSourcesWired();
            GetSourcesTime();

        }

        async void LoadSourcesBI()
        {
            GetSources sourceBI = new GetSources();
            sourceBI = await NewsManager.GetSourcesBI();
            foreach (Article article in sourceBI.articles)
            {
                Debug.WriteLine(article.title + ": " + article.description);
            }
        }
        async void LoadSourcesNYT()
        {
            GetSources sourceNYT = new GetSources();
            sourceNYT = await NewsManager.GetSourcesBI();
            foreach(Article article in sourceNYT.articles)
            {
                Debug.WriteLine(article.title);
            }
        }
        async void LoadSourcesWired()
        {
            GetSources sourceWired = new GetSources();
            sourceWired = await NewsManager.GetSourcesWired();
            foreach(Article article in sourceWired.articles)
            {
                Debug.WriteLine((article.title));
            }
        }


        async void GetSourcesTime()
        {
            GetSources sourceTime = new GetSources();
            sourceTime = await NewsManager.GetSourcesTime();
            foreach (Article article in sourceTime.articles)
            {
                Debug.WriteLine((article.title));
            }
        }

        void Clicked_Wired(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new OverviewPage("Wired"));
        }

        void Clicked_NYT(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new OverviewPage("NYT"));
        }

        void Clicked_Time(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new OverviewPage("Time"));
        }

        void Clicked_BI(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new OverviewPage("BI"));
        }

        void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {
               //Navigation.PushAsync(new NewsArticlesBySearch(SearchBar.Text));
        }
    }


}
