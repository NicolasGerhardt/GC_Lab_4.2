using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_4._2
{
    class Movie
    {
        #region Fields
        private string title;
        private MovieCategories category;
        #endregion
        #region Poperties
        public string Title { get => title; set => title = value; }
        public MovieCategories Category { get => category; set => category = value; }
        public enum MovieCategories
        {
            animated,
            drama,
            horror,
            scifi
        }
        #endregion
        #region Constructors
        public Movie(string title, MovieCategories category)
        {
            Title = title;
            Category = category;
        }
        #endregion
        #region Methods
        public bool IsCategory(string category)
        {
            if (this.category.Equals(category))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Movie: {title} \t Category: {category}";
        }
        #endregion

    }
}
