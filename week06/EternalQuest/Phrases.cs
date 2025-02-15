//Phrases.cs
using System;
using System.Collections.Generic;

public class Phrases 
{
    private List<string> quotes = new List<string>
    {
         "“Start where you are. Use what you have. Do what you can.” - Arthur Ashe",
        "“I never dreamed about success. I worked for it.” - Estee Lauder",
        "“Don’t think about making art. Just get it done. Let everyone else decide if it’s good or bad, whether they love it or hate it. While they are deciding, make even more art.” - Andy Warhol",
        "“I am deliberate and afraid of nothing.” - Audre Lorde",
        "“We have a strategic plan. It’s called doing things.” - Herb Kelleher",
        "“You can’t use up creativity. The more you use, the more you have.” – Maya Angelou",
        "“Sometimes, you’ve got to work a little, so you can ball a lot.” - Tom Haverford",
        "“Go to your desire and don’t hang around here.” - Jack Kerouac, “Big Sur”",
        "“Go confidently in the direction of your dreams! Live the life you’ve imagined!” - Thoreau",
        "“Now tell me, what is it you plan to do with your one wild and precious life?” - Mary Oliver",
        "“Find out who you are and do it on purpose.” - Dolly Parton",
        "“Some people want it to happen, some people wish it would happen, others make it happen.” - Michael Jordan",
        "“To be contented—that’s for the cows.” - Diana Vreeland",
        "“The man on top of the mountain didn’t fall there.” - Vince Lombardi",
        "“Make it work.” - Tim Gunn",
        "“Never let go of that fiery sadness called desire.” - Patti Smith",
        "“Live every week like it’s Shark Week.” – Tracy Jordan", 
        "“Challenges are gifts that force us to search for a new center of gravity. Don’t fight them. Just find a new way to stand.” - Oprah Winfrey",
        "“What would you do if you weren’t afraid?” - Sheryl Sandberg",
        "“Don’t think about your errors or failures; otherwise, you’ll never do a thing.” - Bill Murray",
        "“Life is short. Don’t be lazy.” - Sophia Amoruso",
        "“It is not true that people stop pursuing dreams because they grow old. They grow old because they stop pursuing dreams.” – Gabriel García Márquez"
    };


    private List<string> metaphors = new List<string>
    {
        "Time is a thief.",
        "Eyes are the windows to the soul.",
        "This is the icing on the cake.",
        "Hope is on the horizon.",
        "Life contains nothing but clear skies up ahead.",
        "You have a heart of gold.",
        "Climbing the Mountain",
        "Planting Seeds of Knowledge in wherever place",
        "Running the Race",
        "Opening a Book is Like Opening a Door",
        "The Trout is always swimming Against the Tide",
        "The Puzzle of Learning: each piece contributes to the bigger picture.",
        "A Blank Canvas is like a Beacon of Light"
    };

    Random random = new Random();

    public string GetRamdomQuote()
    {
        return quotes[random.Next(quotes.Count)];
    }

    public string GetRamdomMetaphor() 
    {
        return metaphors[random.Next(metaphors.Count)];

    }
}