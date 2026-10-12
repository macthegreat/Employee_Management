namespace Products;
public record Product(int Id, string Name, decimal Price, string Category);

public record CreateProductDto(string Name, decimal Price, string Category);

    


