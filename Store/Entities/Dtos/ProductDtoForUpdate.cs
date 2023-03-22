namespace Entities.Dtos
{
    public record ProductDtoForUpdate : ProductDto
    {
        public bool Showcase { get; set; }
    }
}