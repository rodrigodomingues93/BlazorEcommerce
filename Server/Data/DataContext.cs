namespace BlazorEcommerce.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category
				{
					Id = 1,
					Name = "Shoes",
					URL = "shoes"
				},
				new Category
				{
					Id = 2,
					Name = "Consoles",
					URL = "consoles"
				},
				new Category
				{
					Id = 3,
					Name = "Video Games",
					URL = "video-games"
				},
				new Category
				{
					Id = 4,
					Name = "Football Jersey's",
					URL = "football-jersey"
				}
			);

			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					CategoryId = 1,
					Title = "Nike SB Stefan Janoski Max",
					Description = "The Nike SB Stefan Janoski Max offers good hold and balance courtesy of its skateboarding roots and as designed by Janoski himself. It has adequate room for multiple foot shapes and sizes. This kick is available in men's and women's sizing. It has a textile upper that allows the foot to breathe and stay fresh and cool.",
					ImageURL = "https://sneakerbardetroit.com/wp-content/uploads/2015/08/Nike-SB-Stefan-Janoski-Max-Suede-University-Red-4.jpg",
					Price = 69.99m
				},
				new Product
				{
					Id = 2,
					CategoryId = 1,
					Title = "Adidas I-5923",
					Description = "The low-top Adidas I-5923 sneaker is adored by many for its comfortable feel. Its silhouette, which mixes vintage Adidas Originals aesthetic with modern tech, is often described as stylish and cute.",
					ImageURL = "https://media.endclothing.com/media/catalog/product/0/4/04-07-2018_adidas_i-5923_whitegrey_gum_b37947_mg_1.jpg",
					Price = 64.99m
				},
				new Product
				{
					Id = 3,
					CategoryId = 1,
					Title = "Vans Old Skool",
					Description = "Overview The Old Skool, the Vans classic skate shoe and first to bare the iconic sidestripe, is a low top lace-up featuring sturdy canvas and suede uppers, re-enforced toecaps to withstand repeated wear, padded collars for support and flexibility, and signature rubber waffle outsoles.",
					ImageURL = "https://photos6.spartoo.pt/photos/261/26185/26185_500_A.jpg",
					Price = 74.99m
				},
				new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "PlayStation 4",
                    Description = "A slanted black box with both a matte and shine finish, with a sleek blue line through the middle, the PlayStation 4 will slot into most living rooms comfortably. Sony's fourth PlayStation console is fast, sleek and powerful.",
                    ImageURL = "https://gmedia.playstation.com/is/image/SIEPDC/ps4-slim-image-block-01-en-24jul20?$native--t$",
					Price = 399.99m
				},
				new Product
				{
					Id = 5,
					CategoryId = 2,
					Title = "Game Boy Color",
					Description = "Game Boy Color (abbreviated as GBC) is a handheld video game console developed by Nintendo. Originally released in late 1998, it is the successor to the original Game Boy, and is slightly larger than the Game Boy Pocket and significantly smaller than the original Game Boy.",
					ImageURL = "https://www.backmarket.pt/cdn-cgi/image/format=auto,quality=75,width=640/https://d1eh9yux7w8iql.cloudfront.net/product_images/1568704266.81.jpg",
					Price = 69.99m
				},
				new Product
				{
					Id = 6,
					CategoryId = 2,
					Title = "PlayStation Portable",
					Description = "The PlayStation Portable (PSP) is a handheld game console developed and marketed by Sony Computer Entertainment. It was first released in Japan on December 12, 2004, in North America on March 24, 2005, and in PAL regions on September 1, 2005, and is the first handheld installment in the PlayStation line of consoles.",
					ImageURL = "https://files.tecnoblog.net/wp-content/uploads/2018/10/1200px-Sony-PSP-1000-Body-700x394.jpg",
					Price = 249.99m
				},
				new Product
				{
					Id = 7,
					CategoryId = 3,
					Title = "Pro Evolution Soccer 5",
					Description = "Pro Evolution Soccer 5 (também conhecido como Winning Eleven 9 no Japão e World Soccer Winning Eleven 9 nos Estados Unidos) é o quinto jogo da série Pro Evolution Soccer. As versões para PlayStation 2 e Xbox foram lançadas em 21 de outubro de 2005 e para PC lançada na semana seguinte, no dia 28 de outubro.",
					ImageURL = "https://s1.kuantokusta.pt/img_upload/produtos_videojogos/70194_3_pro-evolution-soccer-5-ps2-usado.jpg",
					Price = 39.90m
				},
				new Product
				{
					Id = 8,
					CategoryId = 3,
					Title = "Assassin's Creed IV: Black Flag",
					Description = "Assassin's Creed IV: Black Flag is an action-adventure, stealth game set in an open world environment and played from a third-person perspective. The game features three main cities; Havana, Kingston, and Nassau, which reside under Spanish, British, and pirate influence, respectively.",
					ImageURL = "https://upload.wikimedia.org/wikipedia/pt/c/ca/Assassins_Creed_4_Black_Flag_capa.png",
					Price = 69.90m
				},
				new Product
				{
					Id = 9,
					CategoryId = 3,
					Title = "Grand Theft Auto: San Andreas",
					Description = "Grand Theft Auto: San Andreas is an action-adventure game with role-playing and stealth elements. Structured similarly to the previous two games in the series, the core gameplay consists of elements of third-person shooter and driving games, affording the player a large, open-world environment in which to move around.",
					ImageURL = "https://upload.wikimedia.org/wikipedia/pt/d/d3/Grand_Theft_Auto_San_Andreas_capa.png",
					Price = 59.90m
				},
				new Product
				{
					Id = 10,
					CategoryId = 4,
					Title = "Sporting Home Shirt 2021-22",
					Description = "SportingCP woven crest, Regular fit, Ribbed crewneck, 100% recycled polyester doubleknit, Moisture absorbing, Ribbed cuffs.",
					ImageURL = "https://cdn-scp.azureedge.net/lojaverdeonline/0002381_camisola-principal-c-pub-2122-regular.jpeg",
					Price = 89.99m
				},
				new Product
				{
					Id = 11,
					CategoryId = 4,
					Title = "Manchester United Away Shirt 2021-22",
					Description = "Manchester United woven crest, Regular fit, Ribbed crewneck, 100% recycled polyester doubleknit, Moisture absorbing, Ribbed cuffs.",
					ImageURL = "https://images.footballfanatics.com/manchester-united/manchester-united-cup-away-shirt-2021-22-with-ronaldo-7-printing_ss4_p-12093065+pv-1+u-8mba4zrbocgqx36ptevj+v-04188d50c2ed430883097f4b79b27a04.jpg?_hv=1&w=900",
					Price = 60.00m
				}
			);
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
