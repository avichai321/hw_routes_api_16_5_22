using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hw_routes_api_16_5_22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:MinLength(5)}")]
        public string GetId(int id)
        {
            return "my id need to be 5 numbers " + id;
        }
        
        [Route("{book:regex(zoom|boom)}")]
        public string GetBook(string book)
        {
            return "this book is the " + book;
        }
    }
}
