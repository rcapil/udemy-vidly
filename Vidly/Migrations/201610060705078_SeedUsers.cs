namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1ecfb888-77cd-4553-93a2-aab8e0b29093', N'admin@vidly.com', 0, N'ADIGxmSuG7lfnmQxgkirD3N/HSZlefUip6/L1A49pt8MbBtjstsRD3qRqkUCWd7gUw==', N'5006d3b5-4939-4d19-b0a0-c8d981ab9c25', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b21a7dc2-e3c1-4064-aef8-3a63f4481b5b', N'guest@vidly.com', 0, N'AEKuEK9fyZkYXkGgqRSaD2stZ/SXZd0kqfP0OLnq0Yt0ndOPppqVokZ1xE/5NUnFXA==', N'b1e514b9-bb14-4336-8e59-178654ed33e6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b72f160e-4859-43cc-81d2-a2e7fd002806', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1ecfb888-77cd-4553-93a2-aab8e0b29093', N'b72f160e-4859-43cc-81d2-a2e7fd002806')
");
        }
        
        public override void Down()
        {
        }
    }
}
