using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleApplications.Models
{
    public class Customer
    {
        public int Id { get; set; }        
        public int JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Status { get; set; } //Aktivan ili neaktivan
        public int TeorijskaObuka { get; set; }
        public int TeorijskiIspit { get; set; }
        public int PrakticnaObuka { get; set; }
        public int PrakticanIspit { get; set; }
        public int BrojDodatnihCasova { get; set; }
        public int PlacenoZaDodatneCasove { get; set; }
        public bool DaLiKoristiAkciju { get; set; }
        public int AkcijskaCena { get; set; }
        public bool PlacenoSve { get; set; }
    }
}


//Sql(@"
//INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a8f216e0-c4d5-400e-95d7-fe686b2e4c54', N'lukadevic88@gmail.com', 0, N'AB0ovo+i8atgaWCQEPWwHfC4O9GXvTz+LuWu1q2ZWZwGvhb57TPe7Bvq56bLuH6t3w==', N'490b101a-8c5d-44e1-bcc5-6414cccf5830', NULL, 0, 0, NULL, 1, 0, N'lukadevic88@gmail.com')
//INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e90e6a99-05bd-458a-832f-a2b4c75ed4f7', N'raskovlj@gmail.com', 0, N'AKm/t9aIj0hn6wLFczaTXk/FPmyDd7xgL3YXQUbOZwOTL4xD+QvDGMhqtRGdokGj3Q==', N'd5eded0d-1593-4d84-a571-ee7a8552d81c', NULL, 0, 0, NULL, 1, 0, N'raskovlj@gmail.com')

//INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9d814741-88a4-45be-866b-369f3c20ba87', N'CanUseTheApplication')

//INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a8f216e0-c4d5-400e-95d7-fe686b2e4c54', N'9d814741-88a4-45be-866b-369f3c20ba87')
//INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e90e6a99-05bd-458a-832f-a2b4c75ed4f7', N'9d814741-88a4-45be-866b-369f3c20ba87')

//");