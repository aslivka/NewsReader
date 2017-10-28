using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsArticle
{
    
    public interface Article
    {
       string Author { get; set; }
       string Title { get; set; }
       string Description { get; set; }
       string ArticleUrl { get; set; }
       string UrlToImage { get; set; }
       string PublishedAt { get; set; }
    }

    public class ArticleJSON : Article
    {
        private string author;
        private string title;
        private string description;
        private string url;
        private string urlToImage;
        private string publishedAt;

        public ArticleJSON()
        {
            author = "";
            title = "";
            description = "";
            url = "";
            urlToImage = "";
            publishedAt = "";
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string ArticleUrl
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

        public string UrlToImage
        {
            get
            {
                return urlToImage;
            }
            set
            {
                urlToImage = value;
            }
        }

        public string PublishedAt
        {
            get
            {
                return publishedAt;
            }
            set
            {
                publishedAt = value;
            }
        }

        
    }


 

}

