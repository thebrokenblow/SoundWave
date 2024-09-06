using Model.SoundWave.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model.SoundWave.Entities;

namespace Web.Server.SoundWave.Pages.Groups;

public class IndexModel(SoundWaveDBContext soundWaveDBContext) : PageModel
{
    public IEnumerable<Group>? Groups { get; set; }

    public void OnGet()
    {
        Groups = soundWaveDBContext.Groups;
    }
}