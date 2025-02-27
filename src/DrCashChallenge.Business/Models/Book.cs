﻿using System.Collections.Generic;

namespace DrCashChallenge.Business.Models
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public int NumberOfCopies { get; set; }

        #region Navigation Propreties
        public ICollection<Author> Authors { get; set; }
        public ICollection<Genre> Genres { get; set; }
        #endregion
    }
}
