using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsCollection;

namespace NewsCollection
{
    
    public class ArticleJSON
    {
        //private string author;
        private string title;
        private string description;
        private string url;
        //private string urlToImage;
        //private string publishedAt;

        public ArticleJSON()
        {
            //Author = "";
            Title = "";
            Description = "";
            URL = "";
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

        public string URL
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
    }




}

