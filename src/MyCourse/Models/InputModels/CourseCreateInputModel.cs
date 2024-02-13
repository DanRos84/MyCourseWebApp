using System.ComponentModel.DataAnnotations;

namespace MyCourse.Models.InputModels
{
    public class CourseCreateInputModel
    {
        // queste sono delle DataAnnotations e vengono utilizzate per stabilire delle regole all'inserimento di dati da parte dell'utente
        [Required, MinLength(10), MaxLength(100), RegularExpression(@"^[\w\s\.]+$")]
        public string Title { get; set; }

    }
}