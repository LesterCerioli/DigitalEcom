using DigitalEcom.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class Content : EntityBase
    {
        public Content(string name, string slug, string metaTitle,
            string metaKeywords, string metaDescription,
            bool isPublished, DateTimeOffset? publishedOn)
        {
            Name = name;
            Slug = slug;
            MetaTitle = metaTitle;
            MetaKeywords = metaKeywords;
            MetaDescription = metaDescription;
            IsPublished = isPublished;
            PublishedOn = publishedOn;
        }

        public string Name { get; private set; }

        public string Slug { get; private set; }

        public string MetaTitle { get; private set; }

        public string MetaKeywords { get; private set; }

        public string MetaDescription { get; private set; }

        public bool IsPublished { get; private set; }

        public DateTimeOffset? PublishedOn { get; private set; }

        public bool IsDeleted
        {
            get
            {
                return IsDeleted;
            }

            set
            {
                IsDeleted = value;
                if (value)
                {
                    IsPublished = false;
                }
            }
        }
    }
}
