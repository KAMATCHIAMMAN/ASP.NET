using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DependencyInjection.Models;
namespace DependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMyinfoInterface Mydetails;
        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        public IndexModel(IMyinfoInterface MyinfoRepository)
        {
            Mydetails = MyinfoRepository;
        }
        public void OnGet()
        {
            ViewData["myName"] = Mydetails.GetDetails().myName;
            ViewData["Gender"] = Mydetails.GetDetails().gender;
            ViewData["Age"] = Mydetails.GetDetails().age;
            ViewData["Desgination"] = Mydetails.GetDetails().desgination;

        }
    }
}