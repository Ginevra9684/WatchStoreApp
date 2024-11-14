using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStoreApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class nuoviModelli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordini_AspNetUsers_ClienteId",
                table: "Ordini");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordini_Prodotti_OrologioId",
                table: "Ordini");

            migrationBuilder.DropForeignKey(
                name: "FK_Prodotti_Categorie_CategoriaId",
                table: "Prodotti");

            migrationBuilder.DropForeignKey(
                name: "FK_Prodotti_Marche_MarcaId",
                table: "Prodotti");

            migrationBuilder.DropIndex(
                name: "IX_Ordini_ClienteId",
                table: "Ordini");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImmagineProfiloURL",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "MarcaId",
                table: "Prodotti",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Prodotti",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiametroId",
                table: "Prodotti",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlImmagine",
                table: "Prodotti",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "OrologioId",
                table: "Ordini",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Ordini",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienteId1",
                table: "Ordini",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlImmagine",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ordini_ClienteId1",
                table: "Ordini",
                column: "ClienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordini_AspNetUsers_ClienteId1",
                table: "Ordini",
                column: "ClienteId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordini_Prodotti_OrologioId",
                table: "Ordini",
                column: "OrologioId",
                principalTable: "Prodotti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prodotti_Categorie_CategoriaId",
                table: "Prodotti",
                column: "CategoriaId",
                principalTable: "Categorie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prodotti_Marche_MarcaId",
                table: "Prodotti",
                column: "MarcaId",
                principalTable: "Marche",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordini_AspNetUsers_ClienteId1",
                table: "Ordini");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordini_Prodotti_OrologioId",
                table: "Ordini");

            migrationBuilder.DropForeignKey(
                name: "FK_Prodotti_Categorie_CategoriaId",
                table: "Prodotti");

            migrationBuilder.DropForeignKey(
                name: "FK_Prodotti_Marche_MarcaId",
                table: "Prodotti");

            migrationBuilder.DropIndex(
                name: "IX_Ordini_ClienteId1",
                table: "Ordini");

            migrationBuilder.DropColumn(
                name: "DiametroId",
                table: "Prodotti");

            migrationBuilder.DropColumn(
                name: "UrlImmagine",
                table: "Prodotti");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Ordini");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UrlImmagine",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "MarcaId",
                table: "Prodotti",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Prodotti",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "OrologioId",
                table: "Ordini",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Ordini",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImmagineProfiloURL",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Ordini_ClienteId",
                table: "Ordini",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordini_AspNetUsers_ClienteId",
                table: "Ordini",
                column: "ClienteId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordini_Prodotti_OrologioId",
                table: "Ordini",
                column: "OrologioId",
                principalTable: "Prodotti",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prodotti_Categorie_CategoriaId",
                table: "Prodotti",
                column: "CategoriaId",
                principalTable: "Categorie",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prodotti_Marche_MarcaId",
                table: "Prodotti",
                column: "MarcaId",
                principalTable: "Marche",
                principalColumn: "Id");
        }
    }
}
