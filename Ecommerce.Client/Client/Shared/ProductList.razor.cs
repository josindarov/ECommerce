using Ecommerce.Client.Shared;

namespace Ecommerce.Client.Client.Shared;

public partial class ProductList
{
    private static List<Product> Products = new List<Product>()
    {
        new Product()
        {
            Id = 1,
            Title = "1984",
            Description =
                "1984\" (inglizcha: Nineteen Eighty-Four) ingliz yozuvchisi va publitsisti George Orwellning antiutopiya janrida yozilgan romani. 1949-yil nashr etilgan. Roman 2018-yil Karim Bahriyev tomonidan oʻzbekchaga tarjima qilingan",
            ImageUrl = "https://prod-bb-images.akamaized.net/book-covers/coverimage-9782291090830-bookwire-2021-05-07.jpg?w=640",
            Price = 9.99m
        },
        new Product()
        {
            Id = 2,
            Title = "Shovvoz Gatsby",
            Description = "Shovvoz Gatsby (inglizcha: The Great Gatsby) 2013-yilda katta ekranlarga chiqqan, Buyuk Gatsby kitobiga asoslangan romantik va drama janrlaridagi AQSh filmidir. Film rejissori Baz Luhrmann boʻlib, bu kartina Warner Bros. Pictures tomonidan tarqatilgandir.",
            ImageUrl = "https://wab.org/wp-content/uploads/2015/06/gatsbycast-350x161.jpg",
            Price = 9.99m
        },
    };
}