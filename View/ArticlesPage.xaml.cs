using System;
using System.Collections.Generic;
using News.Model;
using Xamarin.Forms;

namespace News.View
{
    public partial class ArticlesPage : ContentView
    {
        public async void GetNewsArticle(string pNewsArticle)
        {
            GetSources source = new GetSources();

            if (pNewsArticle == "Wired")
            {
                source = await NewsManager.GetSourcesWired();
                //lvwInfo.ItemsSource = source.urlToImage;
                //lvwInfo.ItemsSource = source.title;
                //lvwInfo.ItemsSource = source.url;
                //lvwInfo.ItemsSource = source.source;

            }
        }
    }
}
