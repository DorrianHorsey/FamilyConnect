namespace FamilyConnectApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConnectionActions",
                c => new
                    {
                        ConnectionActionId = c.Int(nullable: false, identity: true),
                        ConnectionActionDescription = c.String(),
                        PointsEarned = c.Int(nullable: false),
                        ConnectionActionDate = c.DateTime(nullable: false),
                        FamilyMemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConnectionActionId)
                .ForeignKey("dbo.FamilyMembers", t => t.FamilyMemberId, cascadeDelete: true)
                .Index(t => t.FamilyMemberId);
            
            CreateTable(
                "dbo.FamilyMembers",
                c => new
                    {
                        FamilyMemberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MemberDOB = c.DateTime(nullable: false),
                        PathToMemberPhoto = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.FamilyMemberId);
            
            CreateTable(
                "dbo.Milestones",
                c => new
                    {
                        MilestoneId = c.Int(nullable: false, identity: true),
                        MilestoneReward = c.String(),
                        MilestonePointsRequired = c.Int(nullable: false),
                        Accomplished = c.Boolean(nullable: false),
                        PathToMileStonePhoto = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.MilestoneId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConnectionActions", "FamilyMemberId", "dbo.FamilyMembers");
            DropIndex("dbo.ConnectionActions", new[] { "FamilyMemberId" });
            DropTable("dbo.Milestones");
            DropTable("dbo.FamilyMembers");
            DropTable("dbo.ConnectionActions");
        }
    }
}
