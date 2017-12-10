using System;
using System.Collections.Generic;
using News.Model;
using Xamarin.Forms;

namespace News.View
{
    public partial class NewsArticlePage : ContentPage
    {
        public NewsArticlePage(Article article)
        {
            InitializeComponent();
            imgHeadLine.Source = article.urlToImage;
            lblAuthor.Text = article.author;
            //lblPublishedAt.DateTime = article.publishedAt;
            lblTitle.Text = article.title;
            lblDescription.Text = article.description;

        }
    }
}
