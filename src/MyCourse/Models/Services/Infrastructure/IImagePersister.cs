using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyCourse.Models.Services.Infrastructure
{
    public interface IImagePersister
    {
        /// <summary>
        /// Salva l'immagine e restituisce il percorso al quale l'immagine è raggiungibile
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="formFile"></param>
        /// <returns>The image URL sample: "/Courses/1.jpg"</returns>
        Task<string> SaveCourseImageAsync(int courseId, IFormFile formFile);
    }
}
