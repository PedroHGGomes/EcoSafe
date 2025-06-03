using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoSafe.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABRIGO",
                columns: table => new
                {
                    ID_ABRIGO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CAPACIDADE = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    OCUPACAO_ATUAL = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABRIGO", x => x.ID_ABRIGO);
                });

            migrationBuilder.CreateTable(
                name: "APPUSER",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EMAIL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CPF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LOCALIZACAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPUSER", x => x.ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "ALERTA",
                columns: table => new
                {
                    ID_ALERTA = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TIPO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ID_ABRIGO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ABRIGOID_ABRIGO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALERTA", x => x.ID_ALERTA);
                    table.ForeignKey(
                        name: "FK_ALERTA_ABRIGO_ABRIGOID_ABRIGO",
                        column: x => x.ABRIGOID_ABRIGO,
                        principalTable: "ABRIGO",
                        principalColumn: "ID_ABRIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SENSOR",
                columns: table => new
                {
                    ID_SENSOR = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TIPO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ID_ABRIGO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ABRIGOID_ABRIGO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SENSOR", x => x.ID_SENSOR);
                    table.ForeignKey(
                        name: "FK_SENSOR_ABRIGO_ABRIGOID_ABRIGO",
                        column: x => x.ABRIGOID_ABRIGO,
                        principalTable: "ABRIGO",
                        principalColumn: "ID_ABRIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LEITURA_SENSOR",
                columns: table => new
                {
                    ID_LEITURA_SENSOR = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ID_SENSOR = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SENSORID_SENSOR = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    VALOR = table.Column<decimal>(type: "NUMBER(10,2)", nullable: false),
                    DATA_LEITURA = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEITURA_SENSOR", x => x.ID_LEITURA_SENSOR);
                    table.ForeignKey(
                        name: "FK_LEITURA_SENSOR_SENSOR_SENSORID_SENSOR",
                        column: x => x.SENSORID_SENSOR,
                        principalTable: "SENSOR",
                        principalColumn: "ID_SENSOR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ALERTA_ABRIGOID_ABRIGO",
                table: "ALERTA",
                column: "ABRIGOID_ABRIGO");

            migrationBuilder.CreateIndex(
                name: "IX_LEITURA_SENSOR_SENSORID_SENSOR",
                table: "LEITURA_SENSOR",
                column: "SENSORID_SENSOR");

            migrationBuilder.CreateIndex(
                name: "IX_SENSOR_ABRIGOID_ABRIGO",
                table: "SENSOR",
                column: "ABRIGOID_ABRIGO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ALERTA");

            migrationBuilder.DropTable(
                name: "APPUSER");

            migrationBuilder.DropTable(
                name: "LEITURA_SENSOR");

            migrationBuilder.DropTable(
                name: "SENSOR");

            migrationBuilder.DropTable(
                name: "ABRIGO");
        }
    }
}
