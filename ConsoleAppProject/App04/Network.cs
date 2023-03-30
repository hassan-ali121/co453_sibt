using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class Network
    {
        private NewsFeed news = new NewsFeed();
       
        public void DispalyMenu()
        {
            Console.WriteLine("which app you want to open");
            Console.WriteLine(" Select any of the number : ");
            Console.WriteLine("1. message post");
            Console.WriteLine("2. photo post");
            Console.WriteLine("3. Display all posts");

            Console.WriteLine("Please Enter any number");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                postMessage();
            }
            else if (choice == "2")
            {
                PostPhoto();
            }
            else
            {
                postAll();
            }

        }

        private void postAll()
        {
            news.Display();
            news.DisplayLikedPosts();
        }

        private void PostPhoto()
        {
        }

        private void postMessage()
        {
            throw new NotImplementedException();
        }
    }
}


