using Microsoft.AspNetCore.Mvc.RazorPages;
using Model.SoundWave.Data;
using Model.SoundWave.Entities;

namespace Web.Server.SoundWave.Pages;

public class AlbumsModel(SoundWaveDBContext soundWaveDBContext) : PageModel
{
    public IEnumerable<Album>? Albums { get; set; }
    public void OnGet()
    {
        Albums = soundWaveDBContext.Albums;
    }
}