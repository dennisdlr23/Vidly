namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7c891971-4578-4511-b603-d776adbac485', N'admin@vidly.com', 0, N'AHAB4N2zVYBNTBDlC5Hys4nWBXbmSjwOgeelEkW4542Yv0DQv6YoUL0BTwl/Gm8QpA==', N'85767001-7980-4ae6-9008-3c3983fccd3f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f300b692-5994-4884-a27b-4ce2e5833298', N'guest@vidly.com', 0, N'ADuNjyFWffYBdamiNL742PUwEC4HyQNibV+gNqXTDsUEfvqtIGpnLuVTKXgp/x0WnQ==', N'c319a283-9cba-4730-98fa-c085aa043739', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e83dab27-0be8-4de1-899b-133d7959028f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7c891971-4578-4511-b603-d776adbac485', N'e83dab27-0be8-4de1-899b-133d7959028f')

");
        }
        
        public override void Down()
        {
        }
    }
}
