namespace App.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ProfilePicturePath = c.String(),
                        Location = c.String(),
                        Alias = c.String(),
                        DateOfBrith = c.String(),
                        PhoneNumber = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDateTime = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedUsedId = c.Guid(nullable: false),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedUserId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
