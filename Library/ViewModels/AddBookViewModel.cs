using Library.Models;
using Library.ViewModels.Interfaces;

namespace Library.ViewModels
{
    public class AddBookViewModel : IAddBookViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string[] Authors { get; set; }
        public byte[]? ImageCover { get; set; }
    }
}
