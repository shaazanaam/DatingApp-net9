using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        /// 
        /// // this provides two methods  the Up method and the down method . The upmethod is whats going to happen when we use this migration class
        /// what this means is that its going to create the table named Users with the Property of the entities as the columns of that table
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usersssses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usersssses", x => x.Id);
                });
        }

        /// <inheritdoc />
        /// When we use the remove the migration or try to roll  back then it simply used the down method to roll back the   changes
        ///  and then it simply used the down method to do this 
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usersssses");
        }
    }
}
