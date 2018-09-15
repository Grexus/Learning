using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    // inherits post and adds a property (imageURL) and two constructors
    class ImagePost:Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // inherited properties
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // new property
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - image link: {3}", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }
    }
}
