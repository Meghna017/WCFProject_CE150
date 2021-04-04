namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                {
                    StudentId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    CourseName = c.String(),
                    Contact = c.String(),

                }
                )

                .PrimaryKey(t => t.StudentId);

        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
