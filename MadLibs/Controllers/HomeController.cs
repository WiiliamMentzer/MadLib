using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult MadLibHome() { return View(); } 
    
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult Madlib(string one, string two, string three, string four, string five, string six, string seven)
    {
      MadlibWord newWords = new MadlibWord();
      newWords.WordOne = one; //Name
      newWords.WordTwo = two; //Name 2 
      newWords.WordThree = three; //Town Name (noun)
      newWords.WordFour = four; // Adjective
      newWords.WordFive = five; // Adjective
      newWords.WordSix = six; // (past tense) Verb
      newWords.WordSeven = seven; // food Noun

      return View(newWords);
    }
  }
}