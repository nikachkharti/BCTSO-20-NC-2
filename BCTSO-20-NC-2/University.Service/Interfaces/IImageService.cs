using Microsoft.AspNetCore.Http;

namespace University.Service.Interfaces
{
    public interface IImageService
    {
        Task<string> UploadImage(IFormFile imageFile);
        string DeleteImage(string imageUrl);
        Task<string> UploadResizedImage(IFormFile imageFile);
    }
}
