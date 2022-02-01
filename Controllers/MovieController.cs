using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MiniCinema.Models;

namespace MiniCinema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return new Movie[] {
                new Movie(){ 
                    Id = 1,
                    Title = "Zaułek Koszmarów",
                    Description = "Gdy charyzmatyczny Stanton Carlisle (Bradley Cooper)" +
                    " spotyka na swej drodze niezwykłe małżeństwo: widzącą przyszłość Zeenę" +
                    " (Toni Collette) i jej męża, byłego telepatę, Pete’a (David Strathairn)," +
                    " postanawia odmienić swoje dotychczas pechowe życie. Wraz z lojalną i szlachetną " +
                    "Molly (Rooney Mara) zaczyna wykorzystywać naiwność nowojorskich elit by się wzbogacić," +
                    " a nowo nabyta wiedza szybko okazuje się przepustką do sukcesu. Wkrótce jednak Stanton " +
                    "posunie się o krok za daleko, gdy pod wpływem tajemniczej psychiatry (Cate Blanchett) " +
                    "zdecyduje się oszukać groźnego finansowego potentata (Richard Jenkins).",
                    ImageSource = "https://fwcdn.pl/fpo/85/06/848506/7995424.6.jpg"},
                new Movie() {
                    Id = 2,
                    Title = "C'mon C'mon",
                    Description = "Dziennikarz radiowy wyrusza wraz ze swoim bratankiem w podróż przez kraj.",
                    ImageSource = "https://fwcdn.pl/fpo/03/52/850352/7988764.6.jpg"}
            };
        }
    }
}
