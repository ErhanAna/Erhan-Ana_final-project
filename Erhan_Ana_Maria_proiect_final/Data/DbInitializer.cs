using Erhan_Ana_Maria_proiect_final.Models;

namespace Erhan_Ana_Maria_proiect_final.Data
{
    public class DbInitializer
    {
        public static void Initialize(RecordStoreContext context)
        {
            context.Database.EnsureCreated();

            if(context.Albums.Any())
            {
                return; 
            }

            var albums = new Album[]
            {
                new Album {
                    Title = "Notes On A Conditional Form", 
                    Artist = "The 1975",      
                    Price = Decimal.Parse("20"), 
                    ReleaseDate = DateTime.Parse("2020-05-12")
                },
                new Album {
                    Title = "Wiped Out!",               
                    Artist = "The Neighbourhood",  
                    Price = Decimal.Parse("20"), 
                    ReleaseDate = DateTime.Parse("2020-05-12")
                },
                new Album {
                    Title = "The 1975", 
                    Artist = "The 1975", 
                    Price = Decimal.Parse("20"), 
                    ReleaseDate = DateTime.Parse("2020-05-12")
                }
            };
            foreach (Album a in albums)
            {
                context.Albums.Add(a);
            }
            context.SaveChanges();

            var customers = new Customer[]
            {
                new Customer{
                    CustomerID = 1050, 
                    Name = "Ana Erhan", 
                    Address = "Fabricii de Zahar Street, nr. 38, Cluj-Napoca", 
                    Email = "anamariaerhan997@gmail.com", 
                    Phone = "0757885454", 
                    BirthDate = DateTime.Parse("1999-06-07")
                },
                new Customer{
                    CustomerID = 1045, 
                    Name = "Bianca Erhan", 
                    Address = "Avram Iancu Street, nr. 33, Zalau", 
                    Email = "biancaerhan@yahoo.com", 
                    Phone = "0756159753", 
                    BirthDate = DateTime.Parse("2005-03-15")
                }
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order{
                    AlbumID = 1, 
                    CustomerID = 1050, 
                    OrderDate = DateTime.Parse("2023-01-15")
                },
                new Order{
                    AlbumID = 3, 
                    CustomerID = 1045, 
                    OrderDate = DateTime.Parse("2023-01-15")
                },
                new Order{
                    AlbumID = 1, 
                    CustomerID = 1045, 
                    OrderDate = DateTime.Parse("2023-01-15")
                },
                new Order{
                    AlbumID = 2, 
                    CustomerID = 1050, 
                    OrderDate = DateTime.Parse("2023-01-14")
                },
                new Order{
                    AlbumID = 3,
                    CustomerID = 1045,
                    OrderDate = DateTime.Parse("2023-01-14")
                },
                new Order{
                    AlbumID = 3,
                    CustomerID = 1050,
                    OrderDate = DateTime.Parse("2023-01-12")
                },
            };
            foreach (Order o in orders)
            {
                context.Orders.Add(o);
            }
            context.SaveChanges();

            var labels = new Label[]
            {
                new Label{
                    LabelName = "Dirty Hit", 
                    Address = "London, UK"
                },
                new Label{
                    LabelName = "Universal Records", 
                    Address = "Seattle, USA"
                },
            };
            foreach (Label l in labels)
            {
                context.Labels.Add(l);
            }
            context.SaveChanges();

            var releasedAlbums = new ReleasedAlbum[]
            {
                new ReleasedAlbum
                {
                    AlbumID = albums.Single(c => c.Title == "Pressure").ID,
                    LabelID = labels.Single(i => i.LabelName == "Dirty Hit").ID
                },
                new ReleasedAlbum
                {
                    AlbumID = albums.Single(c => c.Title == "The Beach").ID,
                    LabelID = labels.Single(i => i.LabelName == "Universal Records").ID
                },
                new ReleasedAlbum
                {
                    AlbumID = albums.Single(c => c.Title == "Notes On A Conditional Form").ID,
                    LabelID = labels.Single(i => i.LabelName == "Dirty Hit").ID
                },
            };
            foreach (ReleasedAlbum ra in releasedAlbums)
            {
                context.ReleasedAlbums.Add(ra);
            }
            context.SaveChanges();
        }
    }
}
