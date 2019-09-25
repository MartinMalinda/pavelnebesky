using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a BlogPost class that has
            //an authorName
            //a title
            //a text
            //a publicationDate
            //Create a few blog post objects:
            //"Lorem Ipsum" titled by John Doe posted at "2000.05.04."
            //Lorem ipsum dolor sit amet.
            //"Wait but why" titled by Tim Urban posted at "2010.10.10."
            //A popular long-form, stick-figure-illustrated blog about almost everything.
            //"One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
            //Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.

            BlogPost post1 = new BlogPost();
            post1.AuthorName = "John Doe";
            post1.Title = "Lorem Ipsum";
            post1.Text = "Lorem ipsum dolor sit amet.";
            post1.PublicationDate = "2000.05.04.";

            var post2 = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");

            var post3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");

            Console.WriteLine(post1.Text);
        }
    }
}
