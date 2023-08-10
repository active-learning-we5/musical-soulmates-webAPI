using System;

namespace MusicalSoulmates.Models
{
    public class WebApi.DTOs
    {
        public class BaseDataDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class BaseDataController : ApiController
    {
        public BaseDataController(IBaseDataRepository repo)
        {
            this.repo = repo;
        }


        [Route("/basedata/{lang}/by-parent-code/{code}")
        public List<BaseDataDto> GetByParentCode(string lang, string code)
        {
            var items = this.repo.GetByParentCode(string lang, string code);

            var converted = ....
        
    return converted;
        }


    }
}
