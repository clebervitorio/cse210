using System;
using System.Collections.Generic;

// this is where everything comes together
class Program
{
//    static void Main(string[] args);
    static void Main()
{
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // setting up a list of videos
        List<Video> videos = new List<Video>
        {
            new Video("Goodbye Yellow Brick Road.", "Elton John", 306),
            new Video("I Don't Want To Talk About It with the Royal Philharmonic Orchestra", "Rod Stewart", 8759),
            new Video("C# Tutorial For Beginners", "Programming with Mosh", 2484),
            new Video("Life in Japan as an English Teacher.", "Peter Paul Argente", 480)
        };

        // adding comments for each video
        videos[0].AddComment(new Comment("JORGE RODRIGUES", "Vivi em era mágica: Elton, Elvis, Freddie, George, Louis, Ray, Tina, Janis, Emy, Frank!"));
        videos[0].AddComment(new Comment("MOACYR FERREIRA", "Acompanho Elton John mais de duzentos anos, não sei se somos eternos, acho que não, mas é maravilhoso, estamos juntos"));
        videos[0].AddComment(new Comment("ELISA NERI RIBEIRO", "Ele conseguiu melhorar a própria música"));

        videos[1].AddComment(new Comment("JANIS PASCUA", "My Dad passed away when i was only 2 years old, and my mom had a recording of my Dad singing to this song which is why i this song means so much to me."));
        videos[1].AddComment(new Comment("MEGA WELSHIE", "I was 16 years old when Rod Stewart released this song. I'm now approaching my 62nd birthday and  it's still one of my all time favorite."));
        videos[1].AddComment(new Comment("ENDRIT", "Bryan Adams, Rod Stewart, Sting, Bruce Springsteen, Richard Marx, Bon Jovi the world will never have such legends again never."));

        videos[2].AddComment(new Comment("Saeed Hashemi", "Thank u for teaching us in dark mode."));
        videos[2].AddComment(new Comment("Pecan TheJelly", "I learned more from this tutorial than I did in 12 weeks of a programming college course."));
        videos[2].AddComment(new Comment("Imed Salah", "I had never seen clear and simple programming course like this! I really love it!"));

        videos[3].AddComment(new Comment("RESTITUTO ILANO", "Life in Japan sounds amazing!"));
        videos[3].AddComment(new Comment("LOUIE DESOYO", "This is super informative, thanks!"));
        videos[3].AddComment(new Comment("AIKIE PERIDA", "Thinking about teaching in Japan myself!"));

        // looping through and displaying everything
        foreach (var video in videos)
        {
            video.Display();
        }
}
}