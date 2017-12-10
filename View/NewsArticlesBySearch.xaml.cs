using System;
using System.Collections.Generic;
using News.Model;
using Xamarin.Forms;

namespace News.View
{
    public partial class NewsArticlesBySearch : ContentPage
    {
        public NewsArticlesBySearch(string Keyword)
        {
            InitializeComponent();
            GetSearchQuery(Keyword);
        }

        public  void GetSearchQuery(string keyword)
        {
            GetSources source = new GetSources();

            source = NewsManager.GetSearchQuery(keyword);
            lvwSearch.ItemsSource = source.articles;

           
        }
    }
}
        //functie in manager die de articles ophaalt
        //hier aanspreken met keyword erin
        //lijst opvullen
        //artikel selecteren
        //zelfde code of bij gewoon artikel selecteren
  