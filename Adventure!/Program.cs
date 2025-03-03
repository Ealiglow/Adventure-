
string Name = "";
string KittyName = "";
char Choices;
char Start;
bool end = false;

void Firstchoice()
{

    Console.WriteLine("____________________________________");
    Console.WriteLine("Choose your own adventure");
    Console.WriteLine("____________________________________");
    Console.WriteLine("Shall we begin?");
    Console.WriteLine("____________________________________");
    Console.WriteLine("Use the buttons A and B for choices");
    Console.WriteLine("To get the new lines in the story, use your Enter button");
    Console.WriteLine("Start (A)             Exit(B)");
    Console.WriteLine("");


    //Checks if you are intrested in playing
    Start = char.ToLower(Console.ReadKey().KeyChar);
    // A is intrested and will start game, B is unintrested and should end the program
    if (Start == 'a')
    {
        StartProgram();
    }
    else if (Start == 'b')
    {
        EndProgram();


    }
    //makes sure you cant put another letter
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        Firstchoice(); // Restart choice if invalid
    }
    //starts program code
}

void StartProgram()
{
    Console.WriteLine("");
    Console.WriteLine("Alright then, lets decide your name then!");
    Console.WriteLine("Write your name now and we will start!");
    Name = Console.ReadLine();
    Console.WriteLine($"Welcome {Name} to the game");
    Console.WriteLine("___________________________________");
    Console.WriteLine("now let the story begin");
    Console.WriteLine("");
    StartStory();
}
void EndProgram()
{
    Console.WriteLine("");
    Console.WriteLine("Okay, ending program then");
    Console.WriteLine("Bye bye");
}
void StartStory()
{
    Console.WriteLine("");
    Console.WriteLine("You wake up on a field and look up, you smile at the clouds, the sun and the flying fishes.");
    Console.ReadLine();
    Console.WriteLine("You sit up straight and look at your dear friend, ms.Fox, who looks back and smiles.");
    Console.ReadLine();
    Console.WriteLine("“Oh, my dear you are awake. Let's get back to the village.\"Ms.fox softly spoke. You nod and you both start to walk back to the village.");
    Console.ReadLine();
    Console.WriteLine("When you are back you and ms.Fox part ways for the time. When at home at last you hug mother Racoon. ");
    Console.ReadLine();
    Console.WriteLine(" She smiles softly and gives you a letter “You got mail my dear child, you should open it, it seems important” she says with a little worry.");
    Console.ReadLine();
    Console.WriteLine($"You open the envelope in your room and feel a dread come towards you. “Dear {Name}, you have been here for too long, it is time to open your senses and come back to the real world. You have to wake up, wake up, wake up, WAKE UP, your sincerely ####.”");
    Console.ReadLine();
    Console.WriteLine("You start to feel dizzy. “There's too much ink spilled over the name to read it, but this is the real world, right? ");
    Console.ReadLine();
    Console.WriteLine("However it feels really important and like there's something with it, but how do one wake up from their reality to another, how does one open their senses to the truth” you think.");
    Console.ReadLine();
    Console.WriteLine("Maybe I can get help from the all seeing mr.Iris or maybe the all hearing ms.Kitty? what do you do?");
    Console.WriteLine("");
    Console.WriteLine("(Welcome to your first deccsion, now to choose how youd like the story to countinue, remember A and B)");
    Console.WriteLine();
    //Decision time
    Console.WriteLine("     <Ms.Kitty(A)>                  <Mr.Iris(B)>");
    Console.WriteLine("");
    Choices = char.ToLower(Console.ReadKey().KeyChar);
    //Switches method to the correct one
    if (Choices == 'a')
    {
        MsKitty();
    }
    else if (Choices == 'b')
    {
        MrIris();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        StartStory(); // Restart choice if invalid
    }

}
//if player choose ms.kitty it switches to the method, otherwise it switches to Mriris
void MsKitty()
{
    Console.WriteLine("");
    Console.WriteLine("Ms.kitty;");
    Console.ReadLine();
    Console.WriteLine("“Yes! ms.kitty might be able to help me with this. Let me get ms.Fox and our adventure will have a start, hopefully this isn't our last adventure..”");
    Console.ReadLine();
    Console.WriteLine("You start to pack some important stuff, a picture of you and mother, your favourite plushie, a map, and in case something happens a piece of paper with your name and date of birth.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("You close to fall down the stairs in the rush, and kiss mother Racoon on the cheek, ”Dear mother, i'm on my way on yet another adventure, but this time it is important, if this is the last i see of you, just remember i love you” you say while giving a last big hug.");
    Console.ReadLine();
    Console.WriteLine("“Oh my child, just be careful as always and don't get eaten” she says kissing your head as a goodbye");
    Console.ReadLine();
    Console.WriteLine("You hurry and get ms.Fox, who while thinking it's a lil odd, agrees to join.");
    Console.ReadLine();
    Console.WriteLine("Now you guys are on your way, an adventure to get you back to “reality”, however that's something ms.Fox does not know about yet.");
    Console.ReadLine();
    Console.WriteLine("Do you feel like telling her the truth about why you are going on this adventure or are you gonna lie to her?\r\n");
    Console.WriteLine("");
    Console.WriteLine("<Lie to ms.Fox(A)>          <Tell ms.Fox the truth(B)>");
    Console.WriteLine("");
    //check what user puts in
    Choices = char.ToLower(Console.ReadKey().KeyChar);

    if (Choices == 'a')
    {
        //if A Then change story to LIEKITTY and countinue
        LIEMSKITTY();
    }
    else if (Choices == 'b')
    {
        //if B then change story to TRUTHKITTY and countinue
        TRUTHMSKITTY();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        Firstchoice(); // Restart choice if invalid
    }
}
void LIEMSKITTY()
{
    Console.WriteLine("");
    Console.WriteLine("Lie about it;");
    Console.ReadLine();
    Console.WriteLine("You feel a little clump in your stomach but decide it is for the better that she dont know the actual reason yet, you briefly tell her that you have some questions to ms.Kitty.");
    Console.ReadLine();
    Console.WriteLine("You continue and walk for sometime, ms.Fox wonders how far it is and you check the map, you two will be away for at least 2 days, if nothing happens you explain.\r\n");
    Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("After walking a little you reach some hills and halfway through you and ms.Fox gets a bit hungry.");
    Console.ReadLine();
    Console.WriteLine("Uh oh you forgot to pack you guys food and let ms.fox know. however you two find both a banana with legs and a spaghetti bush.");
    Console.ReadLine();
    Console.WriteLine("you realize that one is poisonous but you don't know which. Which food do you like?");
    Console.WriteLine("");
    Console.WriteLine("<banana with legs(A)>          <Spaghetti from the bushes>(B)");
    Console.WriteLine("");

    Choices = char.ToLower(Console.ReadKey().KeyChar);

    if (Choices == 'a')
    {
        BananaWithLEGS();
    }
    else if (Choices == 'b')
    {
        SphagettifromBUSHES();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        LIEMSKITTY(); // Restart choice if invalid
    }


}
void TRUTHMSKITTY()
{
    Console.WriteLine("");
    Console.WriteLine("Tell her the truth;");
    Console.ReadLine();
    Console.WriteLine("you decide it's time to let ms.fox know the truth behind your mission and tell her what is going on. She seems to think it's weird and scary but doesn't seem to want to stop or discourage you, luckily enough.");
    Console.ReadLine();
    Console.WriteLine("you talk a little about it and she reads the letter, “oh dear, this seems rather urgent, let's hurry!” she says. “it will still take 2 days though” you explain. you two start to hurry a bit.\r\n");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("After walking a little you reach some hills and halfway through you and ms.Fox gets a bit hungry.");
    Console.ReadLine();
    Console.WriteLine("Uh oh you forgot to pack you guys food and let ms.fox know. however you two find both a banana with legs and a spaghetti bush.");
    Console.ReadLine();
    Console.WriteLine(" you realize that one is poisonous but you don't know which. Which food do you like?");
    Console.ReadLine();
    Console.WriteLine("<banana with legs(A)> <Spaghetti from the bushes(B)>");
    Console.WriteLine("");
    Choices = char.ToLower(Console.ReadKey().KeyChar);

    if (Choices == 'a')
    {
        BananaWithLEGS();
    }
    else if (Choices == 'b')
    {
        SphagettifromBUSHES();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        TRUTHMSKITTY(); // Restart choice if invalid
    }



}
//BannanawithLEGS will kill and end program
void BananaWithLEGS()
{
    Console.WriteLine("");
    Console.WriteLine("Banana with legs;");
    Console.ReadLine();
    Console.WriteLine("You catch the banana and start to peel it and a green goo starts to flow out.");
    Console.ReadLine();
    Console.WriteLine(" you and ms.fox eat one each and start to feel weird. you lay down by each other to take a nap together as you start to feel extremely tired. ");
    Console.ReadLine();
    Console.WriteLine("you say goodnight to ms.fox and she says the same back and at last you close your eyes.");
    Console.ReadLine();
    Console.WriteLine("you stop feeling your body and atlas feel at peace. The banana with legs was extremely poisonous.");
    Console.ReadLine();
    Console.WriteLine("You got poisoned.\r\n");
    Console.WriteLine("You died, would you like to restart or end the program?");
    Console.WriteLine("");
    Console.WriteLine("Restart(A)           End program(B)");
    Console.WriteLine("");

    Start = char.ToLower(Console.ReadKey().KeyChar);

    if (Start == 'a')
    {
        StartProgram();
    }
    else if (Start == 'b')
    {
        EndProgram();
    }
    //makes sure you cant put another letter
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        BananaWithLEGS(); // Restart choice if invalid
    }

}
void SphagettifromBUSHES()
{
    Console.WriteLine("");
    Console.WriteLine("The Spaghetti from the bushes;");
    Console.ReadLine();
    Console.WriteLine(" Phew you picked the correct one, the banana on legs has a poisonous liquid inside that would have killed you both in an instant. ");
    Console.ReadLine();
    Console.WriteLine(" you eat the spaghetti and take a tad bit extra with you in case of an emergency.\r\n");
    Console.ReadLine();
    Console.WriteLine("you now are through the hills and on your way towards the stairs in the clouds.");
    Console.ReadLine();
    Console.WriteLine("You walk and walk and walk and at last when up there you sit down a second.");
    Console.ReadLine();
    Console.WriteLine("you then see a cute, big fluffy cat with an extra eye and a coat that seems to have the sky inside of it.");
    Console.ReadLine();
    Console.WriteLine(" the cat meows at you and softly blinks with all its three eyes.");
    Console.ReadLine();
    Console.WriteLine(" The sky cat seemed really friendly and jumped up in your arms, it seemed to want to join you.");
    Console.ReadLine();
    Console.WriteLine(" Would you accept another to join the adventure\r\n?");
    Console.ReadLine();
    Console.WriteLine("<No, its a bad idea(A)>        <Yes, the more that joins the better(B)>");
    Console.WriteLine("");

    Choices = char.ToLower(Console.ReadKey().KeyChar);
    if (Choices == 'a')
    {
        MSKITTYANDNOKITTY();
    }
    else if (Choices == 'b')
    {
        MSKITTYANDKITTY();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        SphagettifromBUSHES(); // Restart choice if invalid
    }


}
//all with kitty
void MSKITTYANDKITTY()
{
    Console.WriteLine("");
    Console.WriteLine("Yes, the more that joins the better:\r\n");
    Console.ReadLine();
    Console.WriteLine("You pet the majestic cat and its fur is so soft.");
    Console.ReadLine();
    Console.WriteLine(" it does a peaceful yawn and lays comfortably in your lap, but it doesn't have a name yet, what is its name?\r\n");
    Console.ReadLine();
    Console.WriteLine("Name the Sky kitty;");
    Console.WriteLine("");
    KittyName = Console.ReadLine();
    Console.WriteLine("");
    Console.ReadLine();
    Console.WriteLine($"Are you pleased with {KittyName}? (you only have a sxingle chance to change)");
    Console.ReadLine();
    Console.WriteLine("<No(A)>                        <Yes(B)>");
    Console.ReadLine();
    Console.WriteLine("");

    Choices = char.ToLower(Console.ReadKey().KeyChar);

    if (Choices == 'a')
    {
        Console.WriteLine("Name the Sky kitty;");
        Console.WriteLine("");
        KittyName = Console.ReadLine();
        Console.ReadLine();
        Console.WriteLine($"kitty name is {KittyName}");
        Console.WriteLine("");
    }
    else if (Choices == 'b')
    {
        KttyNamed();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        MSKITTYANDKITTY(); // Restart choice if invalid
    }


}
void KttyNamed()
{
    Console.WriteLine("");
    Console.WriteLine($"“Let's name you {KittyName}” you say.");
    Console.ReadLine();
    Console.WriteLine($"“Well, welcome little {KittyName} to the team” ms.fox replies in a tired voice.");
    Console.ReadLine();
    Console.WriteLine("you take a nap as you are getting more tired by the seconds.");
    Console.ReadLine();
    Console.WriteLine("After you close your eyes you start to hear voices around you, they seem to not be pleased and are begging you to open your eyes.");
    Console.ReadLine();
    Console.WriteLine("You get a little curious and try to open them but you can't, how weird.");
    Console.ReadLine();
    Console.WriteLine("you try again and again, still can't do it.");
    Console.ReadLine();
    Console.WriteLine(" then at the last try you get them a tiny bit open, just enough to get a glimpse of what's happening.");
    Console.ReadLine();
    Console.WriteLine("‘what the hell’ you think will get the small glimpse of another like you and a white ceiling, the person on the other side didn't have an animal head but one of those human heads you have that mother talked about. ");
    Console.ReadLine();
    Console.WriteLine($" Just after a second your eyes close again and you curiously try to open them again but instead wake up to {KittyName} sitting on you purring. \r\n");
    Console.ReadLine();
    Console.WriteLine("you get up and think a little about that odd and rather scary dream.");
    Console.ReadLine();
    Console.WriteLine("But it is now time to get through the next part of this journey “the mountains in the sky”.");
    Console.ReadLine();
    Console.WriteLine("there's two ways to get by them, you either have to go in between them or around them.");
    Console.ReadLine();
    Console.WriteLine(" one might be dangerous but it is hard to say for the moment, what do you choose to do?\r\n");
    Console.WriteLine("");
    Console.WriteLine("<go in between them(A)>          <go around them(B)>");
    Console.WriteLine("");

    Choices = char.ToLower(Console.ReadKey().KeyChar);

    if (Choices == 'a')
    {
        MsKittyBetweenMountainsLIE();
    }
    else if (Choices == 'b')
    {
        MsKittyAroundMountainsLIE();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        KttyNamed(); // Restart choice if invalid
    }

}
void MsKittyBetweenMountainsLIE()
{
    Console.WriteLine("");
    Console.WriteLine("Go in between them;");
    Console.ReadLine();
    Console.WriteLine("What a great choice, you and the group go in between them and look at all the beautiful nature and animals, you go behind a waterfall that shines in a pinkish purple and then see some rabbit fishes jump in it. ");
    Console.ReadLine();
    Console.WriteLine("Then you see a big beautiful deer with a guitar body. After some hours in the breathtaking nature in between the mountains you and the group find the exit.");
    Console.ReadLine();
    Console.WriteLine("Now it's only some more walking and then we will be at ms.Kitty. you atlast get to the front door which stands open.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Ms.Kitty is in the kitchen making tea to you guys and loudly announces “Welcome my guests, I hope your travels went too hard and long, come and take your seats and let's drink some tea first”.");
    Console.ReadLine();
    Console.WriteLine("you sit down by the table and drink your tea while ms.Fox and ms.Kitty talks about some stuff that you don't really listen to.");
    Console.ReadLine();
    Console.WriteLine("After you are done you ask ms.kitty if you two can talk a little alone. Ms.Fox looks at you suspiciously but keeps quiet about it.");
    Console.ReadLine();
    Console.WriteLine($"“Hello {Name} it's such a pleasure to get to talk to you but I'm guessing you are here for a reason huh?” ms.kitty says.");
    Console.ReadLine();
    Console.WriteLine("“well i need some answers about this letter i got” you reply while giving her the letter. she reads it and gives it back.");
    Console.ReadLine();
    Console.WriteLine(" “Ms.Kitty should I not be here? isn't this reality? please I need answers” you plead.");
    Console.ReadLine();
    Console.WriteLine("“Oh my, my friend this is a reality, however I think it's not the right one for you and I thought you already left this one, but I guess not. Well you need to find your reality my friend” ms kitty tells you while holding your hand.");
    Console.ReadLine();
    Console.WriteLine(" “Then how do I get back to mine, oh ms.Kitty do you know the way to it?”, ");
    Console.ReadLine();
    Console.WriteLine("ms kitty replies with “Well my dear friend, i do know of two ways to realize beyond this one, but i do not know which is yours, i can't hear such things after all” ");
    Console.ReadLine();
    Console.WriteLine("she adds on with “You have to look deep down and think for yourself. The only thing I can help with is letting you know the two ways to different realities. you can travel to the big sea of dreams or take the space train”.");
    Console.ReadLine();
    Console.WriteLine("You thank ms.Kitty for the help and you and the group go outside.");
    Console.ReadLine();
    Console.WriteLine(" “dear, i know this was not just for you to ask some meaningless questions so what is it really we are doing here and the adventure is not over yet correct?” ms.fox  asks while looking a bit serious.");
    Console.ReadLine();
    Console.WriteLine(" You have to tell her the truth. “Well, I tried to hide it for the best, but now that I have the answers I can tell you. you see this is not my reality nor my home, the thing we have left on our adventure that sadly enough turned out to be our last is finding which way to take to find the way back to my reality, it will be our last time seeing each other my dearest ms.fox” you let her know.");
    Console.ReadLine();
    Console.WriteLine(" “my dear why wouldn't you tell me earlier, i knew something was off, however i understand that this has to be done for you my dearest, even though i will miss you”, ms.fox hugs you. ");
    Console.ReadLine();
    Console.WriteLine(" luckily she had already caught on so it wasn't the hardest to let her know.");
    Console.ReadLine();
    Console.WriteLine("but now you have to choose which way that you think is the way back to reality.");
    Console.ReadLine();
    Console.WriteLine(" Are you going to hop on the space train or take a dipp the sea of dreams?");
    Console.ReadLine();
    Console.WriteLine("<Sea of dreams(A)>                <The space train(B)>");
    Console.WriteLine("");

    Choices = char.ToLower(Console.ReadKey().KeyChar);
    if (Choices == 'a')
    {
        SeaOfDreams();
    }
    else if (Choices == 'b')
    {
        Spacetrain();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        MsKittyBetweenMountainsLIE(); // Restart choice if invalid
    }
}
void MsKittyAroundMountainsLIE()
{

}
void MsKittyBetweenMountainsTRUTH()
{
    Console.WriteLine("");
    Console.WriteLine("Between mountains");
    Console.ReadLine();
    Console.WriteLine("What a great choice, you and the group go in between them and look at all the beautiful nature and animals, you go behind a waterfall that shines in a pinkish purple and then see some rabbit fishes jump in it. Then you see a big beautiful deer with a guitar body.\r\n");
    Console.ReadLine();
    Console.WriteLine("After some hours in the breathtaking nature in between the mountains you and the group find the exit. Now it's only some more walking and then we will be at ms.Kitty. you atlast get to the front door which stands open.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Ms.Kitty is in the kitchen making tea to you guys and loudly announces “Welcome my guests, I hope your travels went too hard and long, come and take your seats and let's drink some tea first”.");
    Console.ReadLine();
    Console.WriteLine("you sit down by the table and drink your tea while ms.Fox and ms.Kitty talks about some stuff that you don't really listen to.");
    Console.ReadLine();
    Console.WriteLine("After you are done you ask ms.kitty if you two can talk a little alone. Ms.Fox looks at you suspiciously but keeps quiet about it.");
    Console.ReadLine();
    Console.WriteLine($"“Hello {Name} it's such a pleasure to get to talk to you but I'm guessing you are here for a reason huh?” ms.kitty says.");
    Console.ReadLine();
    Console.WriteLine("“well i need some answers about this letter i got” you reply while giving her the letter. she reads it and gives it back.");
    Console.ReadLine();
    Console.WriteLine(" “Ms.Kitty should I not be here? isn't this reality? please I need answers” you plead.");
    Console.ReadLine();
    Console.WriteLine("“Oh my, my friend this is a reality, however I think it's not the right one for you and I thought you already left this one, but I guess not. Well you need to find your reality my friend” ms kitty tells you while holding your hand.");
    Console.ReadLine();
    Console.WriteLine(" “Then how do I get back to mine, oh ms.Kitty do you know the way to it?”, ");
    Console.ReadLine();
    Console.WriteLine("ms kitty replies with “Well my dear friend, i do know of two ways to realize beyond this one, but i do not know which is yours, i can't hear such things after all” ");
    Console.ReadLine();
    Console.WriteLine("she adds on with “You have to look deep down and think for yourself. The only thing I can help with is letting you know the two ways to different realities. you can travel to the big sea of dreams or take the space train”.");
    Console.ReadLine();
    Console.WriteLine("You thank ms.Kitty for the help and you and the group go outside.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("“Oh how ill miss you my dear freind, but it is time to part ways. im happy i got to enjoy our last time together as such fun adventure” ms fox says will giving you a thigh hug and shading a single tear.");
    Console.ReadLine();
    Console.WriteLine("“oh, ms.fox ill miss you so much and ill miss out adventures but im happy you joined me because without you i dont know how it wouldve gone” you say while holding back the extra tears, but its time to countinue now. ");
    Console.ReadLine();
    Console.WriteLine("now it is time for you to choose which way that you think is the way back to reality. Are you going to hop on the space train or take a dipp the sea of dreams?\r\n");
    Console.ReadLine();
    Console.WriteLine("    <Sea of dreams>                <The space train>");
    Console.WriteLine("");
    Console.ReadLine();
    Choices = char.ToLower(Console.ReadKey().KeyChar);

    if (Choices == 'a')
    {
        SeaOfDreams();
    }
    else if (Choices == 'b')
    {
        Spacetrain();
    }
    else
    {

        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        MsKittyBetweenMountainsTRUTH(); // Restart choice if invalid
    }


}
void MsKittyAroundMountainsTRUTH()
{

}
//all without kitty
void MSKITTYANDNOKITTY()
{
    Console.WriteLine("");
    Console.WriteLine($"No, its a bad idea:\r\n");
    Console.ReadLine();
    Console.WriteLine("you pet the cat but decide to not take it with you. it might cause issues in the future.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("you take a nap as you are getting more tired by the seconds.");
    Console.ReadLine();
    Console.WriteLine("After you close your eyes you start to hear voices around you, they seem to not be pleased and are begging you to open your eyes.");
    Console.ReadLine();
    Console.WriteLine("You get a little curious and try to open them but you can't, how weird.");
    Console.ReadLine();
    Console.WriteLine("you try again and again, still can't do it.");
    Console.ReadLine();
    Console.WriteLine(" then at the last try you get them a tiny bit open, just enough to get a glimpse of what's happening.");
    Console.ReadLine();
    Console.WriteLine("‘what the hell’ you think will get the small glimpse of another like you and a white ceiling, the person on the other side didn't have an animal head but one of those human heads you have that mother talked about. ");
    Console.ReadLine();
    Console.WriteLine(" Just after a second your eyes close again and you curiously try to open them again but instead wake up to ms.fox standing over you smiling. \r\n");
    Console.ReadLine();
    Console.WriteLine("you get up and think a little about that odd and rather scary dream.");
    Console.ReadLine();
    Console.WriteLine("But it is now time to get through the next part of this journey “the mountains in the sky”.");
    Console.ReadLine();
    Console.WriteLine("there's two ways to get by them, you either have to go in between them or around them.");
    Console.ReadLine();
    Console.WriteLine(" one might be dangerous but it is hard to say for the moment, what do you choose to do?\r\n");
    Console.WriteLine("");
    Console.WriteLine("<go in between them(A)>          <go around them(B)>");
    Console.WriteLine("");

    Choices = char.ToLower(Console.ReadKey().KeyChar);

    if (Choices == 'a')
    {
        MsKittyBetweenMountainsNOKITTYANDLIE();
    }
    else if (Choices == 'b')
    {
        MsKittyAroundMountainsNOKITTYANDLIE();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        MSKITTYANDNOKITTY(); // Restart choice if invalid
    }

}
void MsKittyAroundMountainsNOKITTY()
{

}
void MsKittybetweenMountainsNOKITTY()
{

}
void MsKittyBetweenMountainsNOKITTYANDLIE()
{
    Console.WriteLine("");
    Console.WriteLine("Go around them;");
    Console.ReadLine();
    Console.WriteLine("The both of you choose to go around the mountains just to be safe, this takes some extra time and carefulness so you dont fall down. Luckily it isnt impossible and with a little help of your map you are able to take yourselves around them.");
    Console.ReadLine();
    Console.WriteLine("When you have walked around you continue a bit longer and look inbetween the mountains at some beautiful nature.");
    Console.ReadLine();
    Console.WriteLine("maybe it wouldve been nicer walking inbetween but this did work. atlast you are outside ms.kittys house.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Ms.Kitty is in the kitchen making tea to you guys and loudly announces “Welcome my guests, I hope your travels went too hard and long, come and take your seats and let's drink some tea first”.");
    Console.ReadLine();
    Console.WriteLine("you sit down by the table and drink your tea while ms.Fox and ms.Kitty talks about some stuff that you don't really listen to.");
    Console.ReadLine();
    Console.WriteLine("After you are done you ask ms.kitty if you two can talk a little alone. Ms.Fox looks at you suspiciously but keeps quiet about it.");
    Console.ReadLine();
    Console.WriteLine($"“Hello {Name} it's such a pleasure to get to talk to you but I'm guessing you are here for a reason huh?” ms.kitty says.");
    Console.ReadLine();
    Console.WriteLine("“well i need some answers about this letter i got” you reply while giving her the letter. she reads it and gives it back.");
    Console.ReadLine();
    Console.WriteLine(" “Ms.Kitty should I not be here? isn't this reality? please I need answers” you plead.");
    Console.ReadLine();
    Console.WriteLine("“Oh my, my friend this is a reality, however I think it's not the right one for you and I thought you already left this one, but I guess not. Well you need to find your reality my friend” ms kitty tells you while holding your hand.");
    Console.ReadLine();
    Console.WriteLine(" “Then how do I get back to mine, oh ms.Kitty do you know the way to it?”, ");
    Console.ReadLine();
    Console.WriteLine("ms kitty replies with “Well my dear friend, i do know of two ways to realize beyond this one, but i do not know which is yours, i can't hear such things after all” ");
    Console.ReadLine();
    Console.WriteLine("she adds on with “You have to look deep down and think for yourself. The only thing I can help with is letting you know the two ways to different realities. you can travel to the big sea of dreams or take the space train”.");
    Console.ReadLine();
    Console.WriteLine("You thank ms.Kitty for the help then you and ms.Fox go outside.");
    Console.ReadLine();
    Console.WriteLine(" “dear, i know this was not just for you to ask some meaningless questions so what is it really we are doing here and the adventure is not over yet correct?” ms.fox  asks while looking a bit serious.");
    Console.ReadLine();
    Console.WriteLine(" You have to tell her the truth. “Well, I tried to hide it for the best, but now that I have the answers I can tell you. you see this is not my reality nor my home, the thing we have left on our adventure that sadly enough turned out to be our last is finding which way to take to find the way back to my reality, it will be our last time seeing each other my dearest ms.fox” you let her know.");
    Console.ReadLine();
    Console.WriteLine(" “my dear why wouldn't you tell me earlier, i knew something was off, however i understand that this has to be done for you my dearest, even though i will miss you”, ms.fox hugs you. ");
    Console.ReadLine();
    Console.WriteLine(" luckily she had already caught on so it wasn't the hardest to let her know.");
    Console.ReadLine();
    Console.WriteLine("but now you have to choose which way that you think is the way back to reality.");
    Console.ReadLine();
    Console.WriteLine(" Are you going to hop on the space train or take a dipp the sea of dreams?");
    Console.ReadLine();
    Console.WriteLine("<Sea of dreams(A)>                <The space train(B)>");
    Console.WriteLine("");

    Choices = char.ToLower(Console.ReadKey().KeyChar);

    if (Choices == 'a')
    {
        NoKittySeaOfDreams();
    }
    else if (Choices == 'b')
    {
        NoKittySpacetrain();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        MsKittyBetweenMountainsNOKITTYANDLIE(); // Restart choice if invalid
    }

}
void MsKittyAroundMountainsNOKITTYANDLIE()
{

}


//all mr.iris
void MrIris()
{

    Console.WriteLine("Testing MrIris");
}

void LieIris()
{
    Console.WriteLine("Testing LieIris");
}
void TruthIris()
{

    Console.WriteLine("Testing ThruthIris");
}

//all Endings
void FeildsOfTime()
{
    Console.WriteLine("");
    Console.WriteLine("Fields of time;");
    Console.ReadLine();
    Console.WriteLine("You look deep down and feel a reaction towards fields of time. you start to walk and after just a few minutes you come to the start of the fields of time. ");
    Console.ReadLine();
    Console.WriteLine($"You walk in and now there's no turning back. you walk some minutes and then feel {KittyName} brush your leg, at least you have a travel buddy now. ");
    Console.ReadLine();
    Console.WriteLine($"{KittyName} starts to walk in front of you like she's leading you somewhere. you follow them for around 30 minutes. They take you further in and then abruptly stop.");
    Console.ReadLine();
    Console.WriteLine($"you look at the thing in front of you and oddly enough it is a door. {KittyName} jumps up on your shoulder and you open the door slowly.");
    Console.ReadLine();
    Console.WriteLine($"behind the door was pure darkness and you know you can't turn back, with {KittyName} on your shoulder you walk in…");
    Console.ReadLine();
    Console.WriteLine("you start to hear the voices again from your dream this time clearer and clearer and after a minute you can feel something sitting puring on you. ");
    Console.ReadLine();
    Console.WriteLine("Atlast you are strong enough to open your eyes fully and then take a breath. In Front of you stands so many people and now you remember the reality and what happened.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("You remember being in a car, with your mother, but not mother racoon, your actual mother and laughing. then you remember a really loud sound and screaming and crying and then waking up in the other reality.");
    Console.ReadLine();
    Console.WriteLine($"in your arms is your cat which somehow got into the hospital and found you, {KittyName} must have found me lost and helped me through the other reality you think.");
    Console.ReadLine();
    Console.WriteLine($"the doctors seem really tired but really happy, “Welcome back, {Name}” one says while your mother hugs you. “How long have I been away?” you ask.");
    Console.ReadLine();
    Console.WriteLine(" “about 1 week, luckily it seems that cat of yours woke you up” you hug your mom hard and then think about ms.fox.");
    Console.ReadLine();
    Console.WriteLine("At last you are at home and at last you woke up.\r\n");
    Console.ReadLine();
    Console.ReadLine();

    Console.WriteLine("congrats you finsihed the story and didnt die!");
    Console.WriteLine("would you like to restart the game and try changing your decisions?");
    Console.WriteLine("");
    Console.WriteLine("<Restart the game(A)> <End the game(B)>");
    Console.WriteLine("");
    Start = char.ToLower(Console.ReadKey().KeyChar);

    //restarts the game
    if (Start == 'a')
    {
        StartProgram();
    }
    //exits the game
    else if (Start == 'b')
    {
        EndProgram();
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        FeildsOfTime(); // Restart choice if invalid
    }
    //makes sure you cant put another letter
}
void NoKittyFeildsOfTime()
{
    Console.WriteLine("");
    Console.WriteLine("Feilds of time");
    Console.ReadLine();
    Console.WriteLine("You look deep down and feel a reaction towards fields of time. you start to walk and after just a few minutes you come to the start of the fields of time. ");
    Console.ReadLine();
    Console.WriteLine("You walk in and now there's no turning back. you walk some minutes and feel lonely.");
    Console.ReadLine();
    Console.WriteLine("you see some steps in the grass and decide to follow them. you follow them for around 30 minutes. ");
    Console.ReadLine();
    Console.WriteLine("They take you further in and then abruptly stop. you look at the thing in front of you and oddly enough it is a door.");
    Console.ReadLine();
    Console.WriteLine("you think that its either this or endless walking and decide to slowly open the door. behind the door was pure darkness and you know you can't turn back, slowly you walk in…\r\n");
    Console.ReadLine();
    Console.WriteLine("you start to hear the voices again from your dream this time clearer and clearer and after a minute you can feel something sitting puring on you. ");
    Console.ReadLine();
    Console.WriteLine("Atlast you are strong enough to open your eyes fully and then take a breath. In Front of you stands so many people and now you remember the reality and what happened.");
    Console.ReadLine();
    Console.WriteLine("You remember being in a car, with your mother, but not mother racoon, your actual mother and laughing. then you remember a really loud sound and screaming and crying and then waking up in the other reality.");
    Console.ReadLine();
    Console.WriteLine($"the doctors seem really tired but really happy, “Welcome back, {Name}” one says while your mother hugs you.");
    Console.ReadLine();
    Console.WriteLine("“How long have I been away?” you ask, “about 1 week, luckily it seems that you have recovered some stentgth” you hug your mom hard and then think about ms.fox.");
    Console.ReadLine();
    Console.WriteLine("At last you are at home and at last you woke up.\r\n");
    Console.ReadLine();
    Console.ReadLine();
    Console.WriteLine("congrats you finsihed the story and didnt die!");
    Console.WriteLine("would you like to restart the game and try changing your decisions?");
    Console.WriteLine("");
    Console.WriteLine("<Restart the game(A)> <End the game(B)>");
    Console.WriteLine("");
    //restarts the game
    Start = char.ToLower(Console.ReadKey().KeyChar);

    if (Start == 'a')
    {
        StartProgram();
    }
    //exits the game
    else if (Start == 'b')
    {
        EndProgram();
    }
    //makes sure you cant put another letter
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        NoKittyFeildsOfTime(); // Restart choice if invalid
    }

}
void SeaOfDreams()
{
    Console.WriteLine("");
    Console.WriteLine("Sea of Dreams;");
    Console.ReadLine();
    Console.WriteLine("You start to walk towards the sea of dreams. you and ms.fox talks a little while walking and think about all the good moments you shared together. ");
    Console.ReadLine();
    Console.WriteLine($"after some time you come to the sea and you say your goodbyes. you pet {KittyName} one last time before turning your back.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("you start to walk out on the long bridge. When you look down you see small snippets of others dreams and goals, you see some children fighting a dino, a person getting a noble prize and two people kissing. ");
    Console.ReadLine();
    Console.WriteLine("atlast you reach the end of the bridge and slowly get ready to jump. you take a deep breath and hope this is the right way.");
    Console.ReadLine();
    Console.WriteLine(" But right as you hit the water something feels wrong, something isnt right. you start to try getting to the surface but cant physically, you are slowly sinking to the bottom unable to breath.");
    Console.ReadLine();
    Console.WriteLine("atlast you close your eyes and realise this is your demise and the end of you.");
    Console.ReadLine();
    Console.WriteLine("you try getting one last breath then close your eyes and let the sea take you with it.");
    Console.ReadLine();
    Console.WriteLine("it sucks all your dreams, your achivements and everything important out and leave you as a shell of a once existing person at the bottom. this isnt the right reality…\r\n");
    Console.ReadLine();
    Console.WriteLine("You drowned in the sea of dreams");

    Console.WriteLine("would you like to restart the game and try changing your decisions?");
    Console.WriteLine("");
    Console.WriteLine("<Restart the game(A)> <End the game(B)>");
    Console.WriteLine("");
    Start = char.ToLower(Console.ReadKey().KeyChar);

    //restarts the game
    if (Start == 'a')
    {
        StartProgram();
    }
    //exits the game
    else if (Start == 'b')
    {
        EndProgram();
    }
    //makes sure you cant put another letter
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        SeaOfDreams(); // Restart choice if invalid
    }

}
void NoKittySeaOfDreams()
{
    Console.WriteLine("");
    Console.WriteLine("Sea of dreams");
    Console.ReadLine();
    Console.WriteLine("You start to walk towards the sea of dreams. you and ms.fox talks a little while walking and think about all the good moments you shared together. after some time you come to the sea and you say your goodbyes.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("you start to walk out on the long bridge. When you look down you see small snippets of others dreams and goals, you see some children fighting a dino, a person getting a noble prize and two people kissing. ");
    Console.ReadLine();
    Console.WriteLine("atlast you reach the end of the bridge and slowly get ready to jump. you take a deep breath and hope this is the right way.");
    Console.ReadLine();
    Console.WriteLine(" But right as you hit the water something feels wrong, something isnt right. you start to try getting to the surface but cant physically, you are slowly sinking to the bottom unable to breath.");
    Console.ReadLine();
    Console.WriteLine("atlast you close your eyes and realise this is your demise and the end of you.");
    Console.ReadLine();
    Console.WriteLine("you try getting one last breath then close your eyes and let the sea take you with it.");
    Console.ReadLine();
    Console.WriteLine("it sucks all your dreams, your achivements and everything important out and leave you as a shell of a once existing person at the bottom. this isnt the right reality…\r\n");
    Console.ReadLine();
    Console.WriteLine("You drowned in the sea of dreams");

    Console.WriteLine("would you like to restart the game and try changing your decisions?");
    Console.WriteLine("");
    Console.WriteLine("<Restart the game(A)> <End the game(B)>");
    Console.WriteLine("");
    Start = char.ToLower(Console.ReadKey().KeyChar);

    //restarts the game
    if (Start == 'a')
    {
        StartProgram();
    }
    //exits the game
    else if (Start == 'b')
    {
        EndProgram();
    }
    //makes sure you cant put another letter
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        NoKittySeaOfDreams(); // Restart choice if invalid
    }

}
void Spacetrain()
{
    Console.WriteLine("");
    Console.WriteLine("Space train;");
    Console.ReadLine();
    Console.WriteLine("you think about it really hard and the space train seems familiar. you go the long way down the other stairs and through some fields.");
    Console.ReadLine();
    Console.WriteLine(" you get to the lake of a thousand tears and continue by it. At last you take a turn and walk to the space train. when you get to the station you and the group see the train waiting for you.");
    Console.ReadLine();
    Console.WriteLine($"“Oh my dear {Name} I can't follow you further, I will have to say my goodbyes here, I will miss you so and I will remember you” ms.fox sadly whispers while giving a last hug. “oh ms.fox i will never forget you either and i will miss you and the mother and our adventures so much, i will always remember you” you say with tears in your eyes.");
    Console.ReadLine();
    Console.WriteLine($"you walk on the train and right before the doors closes {KittyName} jumps on with you while meowing. you find a soft seat and start to cuddle.");
    Console.ReadLine();
    Console.WriteLine($"however after some minutes {KittyName} presses a button for your station. you don't know what to do so you trust them.");
    Console.ReadLine();
    Console.WriteLine($"The train stops and the doors open, there's nothing there, just pure space but you get the feeling it is still the right place. {KittyName} jumps up on your shoulder and you two get out.");
    Console.ReadLine();
    Console.WriteLine($"you start to fall and catch {KittyName} in your arms and hug them while hoping you choose the right path..");
    Console.ReadLine();
    Console.WriteLine("you start to hear the voices again from your dream this time clearer and clearer and after a minute you can feel something sitting puring on you. ");
    Console.ReadLine();
    Console.WriteLine("Atlast you are strong enough to open your eyes fully and then take a breath. In Front of you stands so many people and now you remember the reality and what happened.");
    Console.ReadLine();
    Console.WriteLine("You remember being in a car, with your mother, but not mother racoon, your actual mother and laughing. then you remember a really loud sound and screaming and crying and then waking up in the other reality.");
    Console.ReadLine();
    Console.WriteLine($" in your arms is your cat which somehow got into the hospital and found you, {KittyName} must have found me lost and helped me through the other reality you think.");
    Console.ReadLine();
    Console.WriteLine($" the doctors seem really tired but really happy, “Welcome back, {Name}” one says while your mother hugs you.");
    Console.ReadLine();
    Console.WriteLine(" “How long have I been away?” you ask, “about 1 week, luckily it seems that cat of yours woke you up” you hug your mom hard and then think about ms.fox.");
    Console.ReadLine();
    Console.WriteLine("At last you are at home and at last you woke up.");
    Console.ReadLine();
    Console.ReadLine();
    Console.WriteLine("congrats you finsihed the story and didnt die!");

    Console.WriteLine("would you like to restart the game and try changing your decisions?"); Console.WriteLine("");
    Console.WriteLine("<Restart the game(A)> <End the game(B)>");
    Console.WriteLine("");
    Start = char.ToLower(Console.ReadKey().KeyChar);

    //restarts the game
    if (Start == 'a')
    {
        StartProgram();
    }
    //exits the game
    else if (Start == 'b')
    {
        EndProgram();
    }
    //makes sure you cant put another letter
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        Spacetrain(); // Restart choice if invalid
    }


}
void NoKittySpacetrain()
{
    Console.WriteLine("");
    Console.WriteLine("Space train;");
    Console.ReadLine();
    Console.WriteLine("you think about it really hard and the space train seems familiar. you go the long way down the other stairs and through some fields.");
    Console.ReadLine();
    Console.WriteLine("you get to the lake of a thousand tears and continue by it. At last you take a turn and walk to the space train.");
    Console.ReadLine();
    Console.WriteLine(" when you get to the station you and the group see the train waiting for you. “Oh my dear <NAME> I can't follow you further, I will have to say my goodbyes here, I will miss you so and I will remember you” ms.fox sadly whispers while giving a last hug.");
    Console.ReadLine();
    Console.WriteLine("“oh ms.fox i will never forget you either and i will miss you and the mother and our adventures so much, i will always remember you” you say with tears in your eyes.");
    Console.ReadLine();
    Console.WriteLine("you walk on the train and right before the doors closes you wave a last goodbye. you find a nice comfy seat.");
    Console.ReadLine();
    Console.WriteLine("you dont know where you should go but trust your stomach feelings and click the stop button at a random place. The train stops and the doors open, there's nothing there, just pure space but you get the feeling it is still the right place.");
    Console.ReadLine();
    Console.WriteLine("you slowly start to get out, you start to fall and think about ms.fox and mother racoon while falling and hoping you choose the correct one...");
    Console.ReadLine();
    Console.WriteLine("you start to hear the voices again from your dream this time clearer and clearer and after a minute you can feel someone holding your hand.");
    Console.ReadLine();
    Console.WriteLine("Atlast you are strong enough to open your eyes fully and then take a breath. In Front of you stands so many people and now you remember the reality and what happened.");
    Console.ReadLine();
    Console.WriteLine("You remember being in a car, with your mother, but not mother racoon, your actual mother and laughing.");
    Console.ReadLine();
    Console.WriteLine("then you remember a really loud sound and screaming and crying and then waking up in the other reality.");
    Console.ReadLine();
    Console.WriteLine($"the doctors seem really tired but really happy, “Welcome back, {Name}” one says while your mother hugs you.");
    Console.ReadLine();
    Console.WriteLine("“How long have I been away?” you ask, “About 1 week, luckily it seems that you have recovered some stentgth” you hug your mom hard and then think about ms.fox.");
    Console.ReadLine();
    Console.WriteLine("At last you are at home and at last you woke up.");
    Console.ReadLine();
    Console.ReadLine();
    Console.WriteLine("congrats you finsihed the story and didnt die!");
    Console.WriteLine("");
    Console.WriteLine("would you like to restart the game and try changing your decisions?"); Console.WriteLine("");
    Console.WriteLine("<Restart the game(A)> <End the game(B)>");
    Console.WriteLine("");
    Start = char.ToLower(Console.ReadKey().KeyChar);

    //restarts the game
    if (Start == 'a')
    {
        StartProgram();
    }
    //exits the game
    else if (Start == 'b')
    {

        EndProgram();
    }
    //makes sure you cant put another letter
    else
    {
        Console.WriteLine("\nInvalid option. Please choose A or B.");
        Console.WriteLine("");
        NoKittySpacetrain(); // Restart choice if invalid
    }


}

Firstchoice();

