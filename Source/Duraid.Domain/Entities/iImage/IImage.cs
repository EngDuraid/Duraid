namespace Duraid.Domain.Entities.iImage
{
    public interface IImage:IImageReferencedId
    {
        public string ImageDescription { get; set; }
    }
}