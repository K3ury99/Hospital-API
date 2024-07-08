using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Laboratorios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SeguroMedico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumeroSeguroSocial = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tratamientos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamientos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DepartamentoID = table.Column<int>(type: "int", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Empleados_Departamentos_DepartamentoID",
                        column: x => x.DepartamentoID,
                        principalTable: "Departamentos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cirugias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoCirugia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cirugias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cirugias_Medicos_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medicos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cirugias_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Pacientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Citas_Medicos_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medicos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Pacientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Facturas_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Pacientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hospitalizaciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitalizaciones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hospitalizaciones_Medicos_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medicos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitalizaciones_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Pacientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultadosLaboratorio",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
                    LaboratorioID = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoPrueba = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Resultados = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadosLaboratorio", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ResultadosLaboratorio_Laboratorios_LaboratorioID",
                        column: x => x.LaboratorioID,
                        principalTable: "Laboratorios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultadosLaboratorio_Medicos_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medicos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultadosLaboratorio_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Pacientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescripciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitaID = table.Column<int>(type: "int", nullable: false),
                    MedicamentoID = table.Column<int>(type: "int", nullable: false),
                    Dosis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    Instrucciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescripciones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prescripciones_Citas_CitaID",
                        column: x => x.CitaID,
                        principalTable: "Citas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescripciones_Medicamentos_MedicamentoID",
                        column: x => x.MedicamentoID,
                        principalTable: "Medicamentos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacturaID = table.Column<int>(type: "int", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoPagado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MetodoPago = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pagos_Facturas_FacturaID",
                        column: x => x.FacturaID,
                        principalTable: "Facturas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cirugias_MedicoID",
                table: "Cirugias",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Cirugias_PacienteID",
                table: "Cirugias",
                column: "PacienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_MedicoID",
                table: "Citas",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_PacienteID",
                table: "Citas",
                column: "PacienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamentoID",
                table: "Empleados",
                column: "DepartamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_PacienteID",
                table: "Facturas",
                column: "PacienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalizaciones_MedicoID",
                table: "Hospitalizaciones",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalizaciones_PacienteID",
                table: "Hospitalizaciones",
                column: "PacienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_FacturaID",
                table: "Pagos",
                column: "FacturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescripciones_CitaID",
                table: "Prescripciones",
                column: "CitaID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescripciones_MedicamentoID",
                table: "Prescripciones",
                column: "MedicamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadosLaboratorio_LaboratorioID",
                table: "ResultadosLaboratorio",
                column: "LaboratorioID");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadosLaboratorio_MedicoID",
                table: "ResultadosLaboratorio",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadosLaboratorio_PacienteID",
                table: "ResultadosLaboratorio",
                column: "PacienteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cirugias");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Hospitalizaciones");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Prescripciones");

            migrationBuilder.DropTable(
                name: "ResultadosLaboratorio");

            migrationBuilder.DropTable(
                name: "Tratamientos");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Laboratorios");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
