namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class book : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.String(nullable: false, maxLength: 128),
                        StudentId = c.Int(nullable: false),
                        StudentName = c.String(),
                        CourseName = c.String(),
                        BookName = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
