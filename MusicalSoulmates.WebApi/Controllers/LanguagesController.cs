[Route("api/[controller]")]
[ApiController]
public class LanguagesController : ControllerBase
{
    private readonly MSDbContext _dbContext;

    public LanguagesController(MSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetLanguages()
    {
        var languages = _dbContext.Languages.ToList();
        return Ok(languages);
    }
}