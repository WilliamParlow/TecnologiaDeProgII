namespace RentalAgency.Migrations {
   using System;
   using System.Data.Entity.Migrations;

   public partial class addusers : DbMigration {
      public override void Up() {

         Sql(@"
         
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'604f84ed-f669-4c73-a78f-594029012fdf', N'root@root.com', 0, N'AB+8dmWU+7/PFcYd1jCi6Ig04jx5E9DiPD8veERdoIMeWQh/tIHKRQkjvqwzLb1byw==', N'dd9e6b7c-a90c-4ea4-b8d8-8a931a8b1b14', NULL, 0, 0, NULL, 1, 0, N'root@root.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7b36bd94-12ff-48da-86c7-1573b671c8e7', N'williamparlow@gmail.com', 0, N'ADLXHXvwkIbXHyq5qNS0dXYTroH5f9rtXXQaQwGJLiG5gpqEdIeh53NHvt5In4Vymw==', N'edec0c50-2c55-4af3-a79f-69d9c64b1c01', NULL, 0, 0, NULL, 1, 0, N'williamparlow@gmail.com')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'604f84ed-f669-4c73-a78f-594029012fdf', N'34e21b25-379d-4bd0-8ac6-25789a1a3077')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'34e21b25-379d-4bd0-8ac6-25789a1a3077', N'CanManageCustomers')
         ");

      }

      public override void Down() {
      }
   }
}
