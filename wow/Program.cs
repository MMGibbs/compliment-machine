Random random = new Random();
Console.WriteLine("how many compliments would you like?");
string input = Console.ReadLine();
int limit = Int32.Parse(input);
Console.WriteLine("Alright, here goes...");
Thread.Sleep(50);

for (int i=0; i< limit; i++)
{
    int k = random.Next(0, 38);
    switch (k)
    {
        case 0: Console.WriteLine("Clap for yourself. "); break;
        case 1: Console.WriteLine("Come on will you shut up your mouth there. "); break;
        case 2: Console.WriteLine("I will slap you, all your teeth will fall off"); break;
        case 3: Console.WriteLine("Get out of my sight. "); break;
        case 4: Console.WriteLine("It is now confirmed I have befriended a goat. "); break;
        case 5: Console.WriteLine("Did you use a mud puddle as a mirror this morning?"); break;
        case 6: Console.WriteLine("You should carry a plant around with you to replace the oxygen you waste."); break;
        case 7: Console.WriteLine("Someday you'll go far; I hope you stay there."); break;
        case 8: Console.WriteLine("You're not the dumbest person in the world, but you better hope that they don't die."); break;
        case 9: Console.WriteLine("Two wrongs don't make a right; take your parents for example."); break;
        case 10: Console.WriteLine("Roses are red; violets are blue; god made me pretty; what happened to you?"); break;
        case 11: Console.WriteLine("It looks like your face caught on fire, and someone tried to put it out with a hammer."); break;
        case 12: Console.WriteLine("You look like a 'before' picture. "); break;
        case 13: Console.WriteLine("May you die of uncontrollable running stomach. "); break;
        case 14: Console.WriteLine("My friend will you stop meandering about. You are not the thinker. "); break;
        case 15: Console.WriteLine("Why are you just allergic to success. "); break;
        case 16: Console.WriteLine("Today my enemies have succeeded."); break;
        case 17: Console.WriteLine("Extract yourself from my room immediately before I cremate you."); break;
        case 18: Console.WriteLine("You useless waste basket."); break;
        case 19: Console.WriteLine("You dishevelled dinosaur."); break;
        case 20: Console.WriteLine("You prehistoric pancake."); break;
        case 21: Console.WriteLine("You pigeon pistacchio"); break;
        case 22: Console.WriteLine("Sharp as a marble, you."); break;
        case 23: Console.WriteLine("Couldn't pour water out of a boot with instructions on the heel."); break;
        case 24: Console.WriteLine("I expected nothing of you, but I'm still disappointed."); break;
        case 25: Console.WriteLine("The wheel's spinning, but the hamster's dead. "); break;
        case 26: Console.WriteLine("You only got two braincells and both of them are fighting for third place."); break;
        case 27: Console.WriteLine("I'm going to f-uhIND your dad and give him a child he'll actually love."); break;
        case 28: Console.WriteLine("GTA traffic light got more use than you."); break;
        case 29: Console.WriteLine("Villain, I have done thy mother."); break;
        case 30: Console.WriteLine("Your home has the aesthetic of a dentist's office and the comfort level of an airport lounge"); break;
        case 31: Console.WriteLine("The bar was so low it was practically a tripping hazard in Hell, yet here you are, limbo dancing with the devil"); break;
        case 32: Console.WriteLine("There are approximately 1,010,300 words in the English language, but I could never string enough words together to express how much I want to hit you with a chair."); break;
        case 33: Console.WriteLine("🧚💖✨love yourself💕💅 ✨💕cus we don't ✨🧚"); break;
        case 34: Console.WriteLine("🧚✨🌈words can't describe you😜✨❤️but numbers can 1/10🦋🥰"); break;
        case 35: Console.WriteLine("Smile forever 🌸🧚‍♂️✨yellow is my favourite colour🌻🧚"); break;
        case 36: Console.WriteLine("Take a deep breath💖😻🌸I hope it's your last😀💫🧚"); break;
        case 37: Console.WriteLine("Nobody's perfect🧚✨💖thanks for proving it🌸⭐💞"); break;
        case 38: Console.WriteLine("Egg."); break;

    }
    Thread.Sleep(10);
}
Console.ReadLine();