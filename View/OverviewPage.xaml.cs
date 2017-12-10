using System;
using System.Collections.Generic;
using News.Model;
using Xamarin.Forms;

namespace News.View
{
    public partial class OverviewPage : ContentPage
    {
        public OverviewPage(string NewsPageType) // GetSources source
        {
            InitializeComponent();
            GetNewsHeadLine(NewsPageType);
            //source.articles.title;
        }

        public async void GetNewsHeadLine(string pNewsHeadLine)
        {
            GetSources source = new GetSources();

            if (pNewsHeadLine == "Wired")
            {
                source = await NewsManager.GetSourcesWired();
                lvwNews.ItemsSource = source.articles;
            }
            else if (pNewsHeadLine == "NYT")
            {
                source = await NewsManager.GetSourcesNYT();
                lvwNews.ItemsSource = source.articles;
            }
            else if (pNewsHeadLine == "Time" )
            {
                source = await NewsManager.GetSourcesTime();
                lvwNews.ItemsSource = source.articles;
            }
            else if (pNewsHeadLine == "BI")
            {
                source = await NewsManager.GetSourcesBI();
                lvwNews.ItemsSource = source.articles;
            }
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Article selectedArticle = lvwNews.SelectedItem as Article;
            Navigation.PushAsync(new NewsArticlePage(selectedArticle));
            // navigeren naar volgend pagina, wat geef je mee in de constructor (paramaters) : lvwNews.SelectedItem as GetSources
            // andere xaml.cs zet je in de constructor
        }
    }
}
