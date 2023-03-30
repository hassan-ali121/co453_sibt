using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>

    public class NewsFeed
    {
        private readonly List<post> posts;
        

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<post>();
            MessagePost post = new MessagePost("Sibt", "hello world");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost("sibt", "helloWorld.PNG","visual studio code");
            AddPhotoPost(photoPost);
            
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }

            
        }
        public void DisplayLikedPosts()
        {
            Console.WriteLine("Liked Posts");
            Console.WriteLine("-----------");

            foreach (var post in posts)
            {
                if (post.likes > 0)
                {
                    post.Display();
                    Console.WriteLine();
                }
            }
        }
    }

}

