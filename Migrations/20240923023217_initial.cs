using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_curriculo.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AProfesional",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_programa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    a_profesional = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AProfesional", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ATProfesionales",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_programa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    areas_profesionales = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tareas_profesionales = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    poblaciones_actuacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATProfesionales", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Competencias",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_programa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    verbo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    objeto_conceptual = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    finalidad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    condicion_contexto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    competencia = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PActuacion",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_programa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    p_actuacion = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PActuacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Res_aprendizaje",
                columns: table => new
                {
                    id_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    competencia = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    tipo_saber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    saber_asociado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    taxonomia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    dominio_tratar = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    nivel_dominio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    verbo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    resultado_ap = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Res_aprendizaje", x => x.id_resultado);
                });

            migrationBuilder.CreateTable(
                name: "Saber",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_programa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    saber = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    saber_hacer = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    saber_ser = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saber", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VAgregado",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_programa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    v_agregado = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VAgregado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil_egreso",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_programa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    nombre_programa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nmodalidad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    perfil_profesional = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    perfil_ocupacional = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    ATProfesionalesid = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AProfesionalid = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PActuacionid = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    VAgregadoid = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Competenciasid = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Res_aprendizajeid_resultado = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfil_egreso", x => x.id);
                    table.ForeignKey(
                        name: "FK_perfil_egreso_AProfesional_AProfesionalid",
                        column: x => x.AProfesionalid,
                        principalTable: "AProfesional",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_perfil_egreso_ATProfesionales_ATProfesionalesid",
                        column: x => x.ATProfesionalesid,
                        principalTable: "ATProfesionales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_perfil_egreso_Competencias_Competenciasid",
                        column: x => x.Competenciasid,
                        principalTable: "Competencias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_perfil_egreso_PActuacion_PActuacionid",
                        column: x => x.PActuacionid,
                        principalTable: "PActuacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_perfil_egreso_Res_aprendizaje_Res_aprendizajeid_resultado",
                        column: x => x.Res_aprendizajeid_resultado,
                        principalTable: "Res_aprendizaje",
                        principalColumn: "id_resultado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_perfil_egreso_Saber_id",
                        column: x => x.id,
                        principalTable: "Saber",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_perfil_egreso_VAgregado_VAgregadoid",
                        column: x => x.VAgregadoid,
                        principalTable: "VAgregado",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_perfil_egreso_AProfesionalid",
                table: "perfil_egreso",
                column: "AProfesionalid");

            migrationBuilder.CreateIndex(
                name: "IX_perfil_egreso_ATProfesionalesid",
                table: "perfil_egreso",
                column: "ATProfesionalesid");

            migrationBuilder.CreateIndex(
                name: "IX_perfil_egreso_Competenciasid",
                table: "perfil_egreso",
                column: "Competenciasid");

            migrationBuilder.CreateIndex(
                name: "IX_perfil_egreso_PActuacionid",
                table: "perfil_egreso",
                column: "PActuacionid");

            migrationBuilder.CreateIndex(
                name: "IX_perfil_egreso_Res_aprendizajeid_resultado",
                table: "perfil_egreso",
                column: "Res_aprendizajeid_resultado");

            migrationBuilder.CreateIndex(
                name: "IX_perfil_egreso_VAgregadoid",
                table: "perfil_egreso",
                column: "VAgregadoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfil_egreso");

            migrationBuilder.DropTable(
                name: "AProfesional");

            migrationBuilder.DropTable(
                name: "ATProfesionales");

            migrationBuilder.DropTable(
                name: "Competencias");

            migrationBuilder.DropTable(
                name: "PActuacion");

            migrationBuilder.DropTable(
                name: "Res_aprendizaje");

            migrationBuilder.DropTable(
                name: "Saber");

            migrationBuilder.DropTable(
                name: "VAgregado");
        }
    }
}
