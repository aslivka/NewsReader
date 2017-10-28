using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsCollection;

namespace NewsCollection
{
    
    public class Article
    {
        public virtual string Author { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string ArticleUrl { get; set; }
        //public virtual string UrlToImage { get; set; }
        //public virtual string PublishedAt { get; set; }
    }

    public class ArticleJSON : Article
    {
        private string author;
        private string title;
        private string description;
        private string url;
        //private string urlToImage;
        //private string publishedAt;

        public ArticleJSON()
        {
            author = "";
            title = "";
            description = "";
            url = "";
            //urlToImage = "";
           // publishedAt = "";
        }

        public override string Author
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
        public override string Title
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

        public override string Description
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

        public override  string ArticleUrl
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

        //public override string UrlToImage
        //{
        //    get
        //    {
        //        return urlToImage;
        //    }
        //    set
        //    {
        //        urlToImage = value;
        //    }
        //}

        //public override string PublishedAt
        //{
        //    get
        //    {
        //        return publishedAt;
        //    }
        //    set
        //    {
        //        publishedAt = value;
        //    }
        //}
        
    }


 

}

