using SellMyGames;
using System;

namespace SellMyGamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { GameID = 1, GameName = "Counter Strike", GamePrice = 133.00 };
            Game game2 = new Game() { GameID = 2, GameName = "PUBG Mobile ", GamePrice = 123.40 };
            Game game3 = new Game() { GameID = 3, GameName = "Need for Speed", GamePrice = 175.90 };
            Game game4 = new Game() { GameID = 4, GameName = "Medal of Honor", GamePrice = 92.00 };
            Game game5 = new Game() { GameID = 5, GameName = "Call of Duty", GamePrice = 124.60 };
            Game game6 = new Game() { GameID = 6, GameName = "Angry Birds", GamePrice = 210.30 };

            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Bledar", LastName = "Brown", DateOfBirth = new DateTime(1987, 2, 6), NationalIdNo = "353434534764" };
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Rachid", LastName = "Khane", DateOfBirth = new DateTime(1992, 10, 30), NationalIdNo = "8765432345" };
            Gamer gamer3 = new Gamer() { Id = 3, FirstName = "Naoko", LastName = "Kohosi", DateOfBirth = new DateTime(2000, 3, 12), NationalIdNo = "121300787264" };
            Gamer gamer4 = new Gamer() { Id = 4, FirstName = "Natalia", LastName = "Jaros", DateOfBirth = new DateTime(2003, 6, 12), NationalIdNo = "123471928461" };
            Gamer gamer5 = new Gamer() { Id = 5, FirstName = "Lisa", LastName = "Jonie", DateOfBirth = new DateTime(1997, 1, 12), NationalIdNo = "2179176412" };
            Gamer gamer6 = new Gamer() { Id = 6, FirstName = "Jenny", LastName = "Kirks", DateOfBirth = new DateTime(2005, 12, 12), NationalIdNo = "641294169421" };

            Campaign campaign1 = new Campaign() { CampaignId = 1, CampaignName = "Welcome", DiscountAmount = 25, ExpiryDate = new DateTime(2025, 4, 12) };
            Campaign campaign2 = new Campaign() { CampaignId = 2, CampaignName = "Summer", DiscountAmount = 20, ExpiryDate = new DateTime(2025, 11, 11) };
            Campaign campaign3 = new Campaign() { CampaignId = 3, CampaignName = "VIP", DiscountAmount = 10, ExpiryDate = new DateTime(2025, 5, 4) };
            Campaign campaign4 = new Campaign() { CampaignId = 4, CampaignName = "Our Gift", DiscountAmount = 5, ExpiryDate = new DateTime(2025, 12, 10) };
            Campaign campaign5 = new Campaign() { CampaignId = 5, CampaignName = "Valentine's", DiscountAmount = 50, ExpiryDate = new DateTime(2025, 5, 5) };
            Campaign campaign6 = new Campaign() { CampaignId = 6, CampaignName = "Unnamed", DiscountAmount = 2, ExpiryDate = new DateTime(2023, 10, 18) };


            GameManager gameManager = new GameManager();
            gameManager.AddGame(game1);
            gameManager.AddGame(game2);
            gameManager.AddGame(game3);
            gameManager.AddGame(game4);
            gameManager.AddGame(game5);
            gameManager.AddGame(game6);
            gameManager.DeleteGame(game5);
            gameManager.UpdateGame(game4, 230.00);

            Console.WriteLine("");
            Console.WriteLine("");


            GamerManager gamerManager = new GamerManager();
            gamerManager.Register(gamer1);
            gamerManager.Register(gamer2);
            gamerManager.Register(gamer3);
            gamerManager.Register(gamer4);
            gamerManager.Register(gamer5);
            gamerManager.Register(gamer6);
            gamerManager.Delete(gamer3);
            gamerManager.Update(gamer5);

            Console.WriteLine("");
            Console.WriteLine("");


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign1);
            campaignManager.AddCampaign(campaign2);
            campaignManager.AddCampaign(campaign3);
            campaignManager.AddCampaign(campaign4); 
            campaignManager.AddCampaign(campaign5);
            campaignManager.AddCampaign(campaign6);

            Console.WriteLine("");
            Console.WriteLine("");

            gameManager.ListTheGames();
            gamerManager.ListTheGamers();
            campaignManager.ListTheCampaigns();
           

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(gamer6, game2);
            salesManager.Sell(gamer2, game3,campaign1);
            salesManager.Sell(gamer1, game4,campaign1);
            salesManager.Sell(gamer4, game6,campaign5);
            salesManager.Sell(gamer5, game1);
            salesManager.Sell(gamer1, game2);
            salesManager.Sell(gamer4, game3,campaign3);
            salesManager.Sell(gamer5, game4);
            salesManager.Sell(gamer1, game6,campaign2);
            salesManager.Sell(gamer2, game1,campaign4);
            salesManager.Sell(gamer5, game2);

            campaignManager.Modify(campaign1, new DateTime(2021, 10, 30));
            campaignManager.Modify(campaign2, new DateTime(2021, 10, 30));
            campaignManager.Modify(campaign3, new DateTime(2021, 10, 30));
            campaignManager.Modify(campaign4, new DateTime(2021, 10, 30));
            campaignManager.Modify(campaign5, new DateTime(2021, 10, 30));

            campaignManager.Modify(campaign2, 80);
            campaignManager.Modify(campaign5, 70);


            salesManager.Sell(gamer6, game3,campaign1);
            salesManager.Sell(gamer2, game4,campaign2);
            salesManager.Sell(gamer4, game6,campaign5);
            salesManager.Sell(gamer6, game1,campaign2);
            salesManager.Sell(gamer1, game2,campaign1);

            campaignManager.DeleteCampaign(campaign6);

            campaignManager.ListTheCampaigns();
            gameManager.ListTheGames();




            Console.Read();
        }
    }
}
