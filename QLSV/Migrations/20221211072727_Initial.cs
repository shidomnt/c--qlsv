using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLSV.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    MAKHOA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENKHOA = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Khoa__22F41770E09FAFA8", x => x.MAKHOA);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    MAMON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENMON = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MonHoc__7B73E9850C403AF5", x => x.MAMON);
                });

            migrationBuilder.CreateTable(
                name: "Nganh",
                columns: table => new
                {
                    MANGANH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENNGANH = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MAKHOA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Nganh__934F1CE20A24836A", x => x.MANGANH);
                    table.ForeignKey(
                        name: "FK__Nganh__MAKHOA__398D8EEE",
                        column: x => x.MAKHOA,
                        principalTable: "Khoa",
                        principalColumn: "MAKHOA");
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MASV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    HOSV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TENSV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DIACHI = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NOISINH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GIOITINH = table.Column<byte>(type: "tinyint", nullable: false),
                    NGAYSINH = table.Column<DateTime>(type: "date", nullable: false),
                    MANGANH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SinhVien__60228A28A9D66813", x => x.MASV);
                    table.ForeignKey(
                        name: "FK__SinhVien__MANGAN__3C69FB99",
                        column: x => x.MANGANH,
                        principalTable: "Nganh",
                        principalColumn: "MANGANH");
                });

            migrationBuilder.CreateTable(
                name: "KetQua",
                columns: table => new
                {
                    MAMON = table.Column<int>(type: "int", nullable: false),
                    MASV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DIEM = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KetQua__ED71C127844DD13D", x => new { x.MAMON, x.MASV });
                    table.ForeignKey(
                        name: "FK__KetQua__MAMON__4222D4EF",
                        column: x => x.MAMON,
                        principalTable: "MonHoc",
                        principalColumn: "MAMON");
                    table.ForeignKey(
                        name: "FK__KetQua__MASV__4316F928",
                        column: x => x.MASV,
                        principalTable: "SinhVien",
                        principalColumn: "MASV");
                });

            migrationBuilder.CreateIndex(
                name: "IX_KetQua_MASV",
                table: "KetQua",
                column: "MASV");

            migrationBuilder.CreateIndex(
                name: "IX_Nganh_MAKHOA",
                table: "Nganh",
                column: "MAKHOA");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_MANGANH",
                table: "SinhVien",
                column: "MANGANH");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KetQua");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "Nganh");

            migrationBuilder.DropTable(
                name: "Khoa");
        }
    }
}
