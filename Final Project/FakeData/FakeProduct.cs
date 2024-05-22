using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.FakeData
{
    public static class FakeProducts
    {
        public static List<ProductItem> GetProducts { get; } = new()
        {
            new ProductItem(new Product("Mi 11", "Xiaomi", "China", "Phone", "https://avatars.dzeninfra.ru/get-zen_doc/4219899/pub_606300423ebe7f2d78cb2cc2_6063004a4fcbbf222b2892c9/scale_1200"), 250, 1200, 10),
            new ProductItem(new Product("TUF Gaming F17", "Asus", "Taiwan", "Laptop", "https://theroco.com/assets/2018/12/asus-tuf-gaming-fx505-review-main.jpg"), 20, 2800, 20),
            new ProductItem(new Product("God of War", "Sony Interactive Entertainment", "USA", "Game", "https://gameguru.ru/media/wallpaper/43118/243411150_4886637094704309_6278405803409414787_n.jpg"),  110, 70, 0),
            new ProductItem(new Product("Iphone 15 Pro Max", "Apple", "USA", "Phone", "https://www.apple.com/newsroom/images/2023/09/apple-unveils-iphone-15-pro-and-iphone-15-pro-max/article/Apple-iPhone-15-Pro-lineup-hero-230912_Full-Bleed-Image.jpg.large.jpg"),  235, 1399, 30),
            new ProductItem(new Product("Red Dead Redemption 2", "Rockstar Games", "USA", "Game", "https://cdn1.ozone.ru/s3/multimedia-n/6045748895.jpg"),  1200, 80, 21),
            new ProductItem(new Product("Playstation 5", "Sony Interactive Entertainment", "Japan", "Electronics", "https://www.mgstore.az/image/cache/catalog/playstation-5-slim-1tb-776015.1%20(1)_11zon-400x400.jpeg"),  15, 540, 5),
            new ProductItem(new Product("Asus ROG Zephyrus Duo", "Asus", "Taiwan", "Laptop", "https://dlcdnwebimgs.asus.com/gain/19233ECB-5693-437C-97F7-F92E5F7C2621"),  180, 1849, 0),
            new ProductItem(new Product("Redragon K552 Mechanical", "Redragon", "China", "KeyBoard", "https://m.media-amazon.com/images/I/61gRw-ooKrL.jpg"),60  ,35, 10),
            new ProductItem(new Product("Razer BlackShark V2 Pro", "Razer Inc", "USA", "HeadPhones", "https://m.media-amazon.com/images/I/711cIUV2JbL._AC_SL1500_.jpg"), 155 ,130 , 20),
            new ProductItem(new Product("Xbox Series X", "Microsoft Gaming", "USA", "Electronics", "https://cdn.vox-cdn.com/thumbor/WQBlYmNTsInQ52YCAyt3gA8YKaQ=/0x0:4800x2700/1200x800/filters:focal(2016x966:2784x1734)/cdn.vox-cdn.com/uploads/chorus_image/image/67383505/Xbox_Series_X.0.jpg"),  100, 887, 50),
            new ProductItem(new Product("Assassins Creed Brotherhood", "Unity", "USA", "Game", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/02a23bb6-c43f-4ee0-91d4-b3981bb1a6c7/df7uwll-bf9d459e-b2dd-4d35-b5b7-aa2982dbacb0.jpg/v1/fill/w_1131,h_707,q_70,strp/vei3kd_by_love1jay_df7uwll-pre.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9ODAwIiwicGF0aCI6IlwvZlwvMDJhMjNiYjYtYzQzZi00ZWUwLTkxZDQtYjM5ODFiYjFhNmM3XC9kZjd1d2xsLWJmOWQ0NTllLWIyZGQtNGQzNS1iNWI3LWFhMjk4MmRiYWNiMC5qcGciLCJ3aWR0aCI6Ijw9MTI4MCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.btfH2kqkuTk78irIMC3Uoz4-cYp-m_zWmmP5MCBbico"),  1200, 7, 0),
            new ProductItem(new Product("Redragon M811 Aatrox MMO", "Redragon", "China", "Mouse", "https://m.media-amazon.com/images/I/51uujmJui0L._AC_SL1500_.jpg"),550  ,149 , 7),
            new ProductItem(new Product("ASUS ProArt Display 32” ", "Asus", "Taiwan", "Monitor", "https://dlcdnwebimgs.asus.com/gain/d219f0fb-ccbe-4461-aad8-c275aae34250/"),100  ,2939 ,15 ),
            new ProductItem(new Product("ASUS BP1501G ROG Backpack", "Asus", "Taiwan", "Backpack", "https://aztechshop.az/image/cache/webp/catalog/Oyun%20aksessuarlar%C4%B1/90XB04ZN-BBP020%20(1)-1000x832.webp"),25  ,34 , 20),
            new ProductItem(new Product("Mortal Kombat 11", "Warner Bros. Games", "USA", "Game", "https://upload.wikimedia.org/wikipedia/en/7/7e/Mortal_Kombat_11_cover_art.png"),  250, 50, 0),
            new ProductItem(new Product("eFootball", "Konami", "China", "Game", "https://spacenetgameshop.net/image/cache/data/001%20PS4%20PS5%20Cover/e-football-pes-2024-ps4-ps5-520-cena-546x840.jpg"),15  ,20 , 3),
            new ProductItem(new Product("Samsung S24 Ultra", "Samsung", "South Korea", "Phone", "https://images.samsung.com/az/smartphones/galaxy-s24-ultra/images/galaxy-s24-ultra-highlights-color-titanium-gray-back-mo.jpg?imbypass=true"),15  ,20 , 3),
            new ProductItem(new Product("Ufc 5", "Konami", "China", "Game", "https://dmxg5wxfqgb4u.cloudfront.net/styles/inline/s3/2023-09/090723-EA-Sports-UFC-5-Shevchenko-Volkanovski.jpeg?itok=_VegVlIW"),15  ,20 , 3),


        };
    }
}
