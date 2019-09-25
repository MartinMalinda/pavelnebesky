using System;
namespace Post_it
{
    public struct PostIt
    {
        //Create a PostIt a struct that has
        //a BackgroundColor
        //a Text on it
        //a TextColor
        //Create a few example post-it objects:
        //an orange with blue text: "Idea 1"
        //a pink with black text: "Awesome"
        //a yellow with green text: "Superb!"

        public string BackgroundColor { get; set; }
        public string Text { get; set; }
        public string TextColor { get; set; }

        public PostIt(string backgroundColor, string text, string textColor)
        {
            BackgroundColor = backgroundColor;
            Text = text;
            TextColor = textColor;
        }
    }
}
