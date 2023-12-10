using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "How to Apply Creamy Eyeshadow";
        video1._author = "Heather Claire";
        video1._seconds = 90;
        Comment v1C1 = new Comment();
        v1C1._name = "Allie Myers";
        v1C1._commentText = "I love how easy it is to follow the steps in the video. The eyeshadow they are using looks beautiful!";
        video1._comments.Add(v1C1);
        Comment v1C2 = new Comment();
        v1C2._name = "Lucy Manner";
        v1C2._commentText = "Beautiful technique. I loved how beautiful my eyes looked after following this tutorial.";
        video1._comments.Add(v1C2);
        Comment v1C3 = new Comment();
        v1C3._name = "Tiffany Porter";
        v1C3._commentText = "Wow...I love this technique. Can't wait to try it out with the eyeshadow they used...it looks so easy to apply and has vibrant color!";
        video1._comments.Add(v1C3);
        _videos.Add(video1);

        Video video2 = new Video();
        video2._title = "How to use Rosemary Oil in Hair";
        video2._author = "Andrea Shephard";
        video2._seconds = 60;
        Comment v2C1 = new Comment();
        v2C1._name = "Jacqueline Parmeter";
        v2C1._commentText = "Looks so easy to apply! Their hair look so healthy and full.";
        video2._comments.Add(v2C1);
        Comment v2C2 = new Comment();
        v2C2._name = "Martin Schuster";
        v2C2._commentText = "I have had great results using Rosemary oil on my hair. My hair is so much more full and soft.";
        video2._comments.Add(v2C2);
        Comment v2C3  = new Comment();
        v2C3._name = "Roxanne Bell";
        v2C3._commentText = "So easy to apply! My hair has more volume and is so shiny!";
        video2._comments.Add(v2C3);
        _videos.Add(video2);

        Video video3 = new Video();
        video3._title = "How to Change a Tire";
        video3._author = "Mike Barber";
        video3._seconds = 600;
        Comment v3C1 = new Comment();
        v3C1._name = "Justin Harvine";
        v3C1._commentText = "Video was very clear and made it a breeze to get my tire changed quickly and back on the road again.";
        video3._comments.Add(v3C1);
        Comment v3C2 = new Comment();
        v3C2._name = "Chloe Fillman";
        v3C2._commentText = "I had never changed a tire before. This video saved me from having to wait for someone to come\n and change my tire...and it saved me money too!";
        video3._comments.Add(v3C2);
        Comment v3C3 = new Comment();
        v3C3._name = "Carter Bridge";
        v3C3._commentText = "Clear...concise...easy!";
        video3._comments.Add(v3C3);
        _videos.Add(video3);


        foreach (Video video in _videos)
        {
            Console.WriteLine($"Video Title: {video._title}\nAuthor: {video._author}\nLength: {video._seconds} seconds\nNumber of Comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine(); //blank line
        }
    }
}