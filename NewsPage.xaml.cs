using System.Collections.Generic;
using System.Diagnostics;
using News.Model;
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
            sourceNYT = await NewsManager.GetSourcesNYT();
            foreach(Article article in sourceNYT.articles)
            {
                Debug.WriteLine(article.title);
            }
        }
    }
}
