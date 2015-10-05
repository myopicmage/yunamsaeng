using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace SRS.Migrations
{
    public partial class initial : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.CreateTable(
                name: "History",
                columns: table => new
                {
                    id = table.Column(type: "int", nullable: false),
                    created = table.Column(type: "datetime2", nullable: false),
                    createdby = table.Column(type: "nvarchar(max)", nullable: true),
                    operation = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.id);
                });
            migration.CreateTable(
                name: "Level",
                columns: table => new
                {
                    id = table.Column(type: "int", nullable: false),
                    name = table.Column(type: "nvarchar(max)", nullable: true),
                    nextdays = table.Column(type: "int", nullable: false),
                    nexthours = table.Column(type: "int", nullable: false),
                    nextminutes = table.Column(type: "int", nullable: false),
                    nextmonths = table.Column(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.id);
                });
            migration.CreateTable(
                name: "Sentence",
                columns: table => new
                {
                    id = table.Column(type: "int", nullable: false),
                    english = table.Column(type: "nvarchar(max)", nullable: true),
                    hangeul = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentence", x => x.id);
                });
            migration.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column(type: "int", nullable: false),
                    lastreview = table.Column(type: "datetime2", nullable: false),
                    level = table.Column(type: "int", nullable: false),
                    username = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });
            migration.CreateTable(
                name: "Word",
                columns: table => new
                {
                    id = table.Column(type: "int", nullable: false),
                    definition = table.Column(type: "nvarchar(max)", nullable: true),
                    english = table.Column(type: "nvarchar(max)", nullable: true),
                    hangeul = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.id);
                });
            migration.CreateTable(
                name: "Conjugation",
                columns: table => new
                {
                    id = table.Column(type: "int", nullable: false),
                    english = table.Column(type: "nvarchar(max)", nullable: true),
                    hangeul = table.Column(type: "nvarchar(max)", nullable: true),
                    politeness = table.Column(type: "nvarchar(max)", nullable: true),
                    tense = table.Column(type: "nvarchar(max)", nullable: true),
                    wordid = table.Column(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjugation", x => x.id);
                    table.ForeignKey(
                        name: "FK_Conjugation_Word_wordid",
                        columns: x => x.wordid,
                        referencedTable: "Word",
                        referencedColumn: "id");
                });
            migration.CreateTable(
                name: "Review",
                columns: table => new
                {
                    id = table.Column(type: "int", nullable: false),
                    pass = table.Column(type: "bit", nullable: false),
                    time = table.Column(type: "datetime2", nullable: false),
                    wordid = table.Column(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.id);
                    table.ForeignKey(
                        name: "FK_Review_Word_wordid",
                        columns: x => x.wordid,
                        referencedTable: "Word",
                        referencedColumn: "id");
                });
            migration.CreateTable(
                name: "Queue",
                columns: table => new
                {
                    id = table.Column(type: "int", nullable: false),
                    level = table.Column(type: "int", nullable: false),
                    nextreview = table.Column(type: "datetime2", nullable: false),
                    userid = table.Column(type: "int", nullable: true),
                    wordid = table.Column(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queue", x => x.id);
                    table.ForeignKey(
                        name: "FK_Queue_User_userid",
                        columns: x => x.userid,
                        referencedTable: "User",
                        referencedColumn: "id");
                    table.ForeignKey(
                        name: "FK_Queue_Word_wordid",
                        columns: x => x.wordid,
                        referencedTable: "Word",
                        referencedColumn: "id");
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.DropTable("Conjugation");
            migration.DropTable("History");
            migration.DropTable("Level");
            migration.DropTable("Review");
            migration.DropTable("Sentence");
            migration.DropTable("Queue");
            migration.DropTable("User");
            migration.DropTable("Word");
        }
    }
}
