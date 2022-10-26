//Griffin Parker
//October 26, 2022
//Mad Lib - Endpoint
//This program takes inputs from the user through the URL, creates a story using those inputs, and then outputs the story to the user
//Peer Reviewed by; Pedro Castaneda - First of all the story is awesome and hilarious! I like that he has en endpoint to give instructions to the user. Code is very clean and simple and program runs perfectly. Great work.

using Microsoft.AspNetCore.Mvc;

namespace ParkerGMadLibsEndpoint.Controllers;


//First type 'https://localhost:xxxx/MadLib'  to get the instructions on how to complete the rest of the program
[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    public string Instructions()
    {
    return "Thank you for playing my MadLib! First you will need to input the following information in to the URL: \n \n 1.  Choose an adjective. \n 2.  Choose a noise. \n 3.  Choose a verb. \n 4.  Choose a exclamation. \n 5.  Choose a bodypart. \n 6.  Choose a person. \n 7.  Choose a character from an animated program. \n 8.  Choose an animal. \n 9.  Choose another verb that ends in -s. \n 10. Choose an adjective that ends in -est \n\n Enter the following URL with your chosen inputs. Be sure to put your local address in place of the 'xxxx':\n https://localhost:xxxx/MadLib/MadLibs/adjective/noise/verb/exclamation/bodypart/person/character/animal/verb(-s)/adjective(-est) \n An example for a madlib URL would be:\n https://localhost:xxxx/MadLib/MadLibs/bouncy/shriek/shrink/shucks!/fingernail/Ken/Olaf/penguin/punches/tastiest";
    }
    
    //https://localhost:xxxx/{MadLib}/{MadLibs}/{adjective}/{noise}/{verb}/{exclamation}/{bodypart}/{person}/{character}/{animal}/{verb(-s)}/{adjective(-est)} 
    [HttpGet]
    [Route("MadLibs/{adjective}/{noise}/{verb}/{exc}/{bodypart}/{person}/{character}/{animal}/{verbs}/{adjest}")]
    public string MadLibs(string adjective, string noise, string verb, string exc, string bodypart, string person, string character, string animal, string verbs, string adjest)
    {
        return $"If you're like me, you know that every {adjective} day starts with an even more {adjective} morning! Here are some tips on how to have the best morning possible. Set your alarm to continually {noise} at max volume, and don't turn it off until you {verb} around your room at least ten times this really gets the blood flowing. As soon as that's done, jump into the shower ASAP, without waiting for it to heat up. Try not to repeatedly yell '{exc}' as the frigid water slowly gets warmer. It's ok to fail this one part, I know I still do from time to time! Be sure to really scrub your {bodypart} while you're in the shower, as most people don't know that 78% of human stink originates there! When dressing yourself, try to think about the most stylish person you know. I usually try to emulate {person}, as they always are lookin real good. Before you leave your house, make sure to give your stuffed {character} at least five hugs, the minimum amount of hugs a person needs everyday, according to the WHO. After leaving your house, make sure to put out food for the family of {animal}s that live under your porch. They get bitey when they're hungry! A wise man once said, 'He who wakes in the morning, also {verbs} the morning.' I'm not sure who that guy outside of the 7/11 was, or even what he meant, but he had the {adjest} beard I've ever seen, so he must be pretty wise!";
    }
}
