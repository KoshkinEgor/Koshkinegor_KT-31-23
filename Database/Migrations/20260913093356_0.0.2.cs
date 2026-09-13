using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koshkinegor_WebApplication.Migrations
{
    /// <inheritdoc />
    public partial class _002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Disciplines_DisciplineId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Specialtys_SpecialtyId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialtys",
                table: "Specialtys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Disciplines",
                table: "Disciplines");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Students",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Students",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "student_id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "idx_student_fk_group_id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Specialtys",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Specialtys",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "SpecialtyId",
                table: "Specialtys",
                newName: "specialty_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Groups",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Course",
                table: "Groups",
                newName: "course");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Groups",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "SpecialtyId",
                table: "Groups",
                newName: "specialty_id");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Groups",
                newName: "group_id");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_SpecialtyId",
                table: "Groups",
                newName: "idx_group_fk_specialty_id");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Grades",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Grades",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Grades",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "DisciplineId",
                table: "Grades",
                newName: "discipline_id");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "Grades",
                newName: "grade_id");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                newName: "idx_grade_fk_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_DisciplineId",
                table: "Grades",
                newName: "idx_grade_fk_discipline_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Disciplines",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Disciplines",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "DisciplineId",
                table: "Disciplines",
                newName: "discipline_id");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "Students",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "Students",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "Students",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Specialtys",
                type: "varchar",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "code",
                table: "Specialtys",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Groups",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "Groups",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "Grades",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Disciplines",
                type: "varchar",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "Disciplines",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddPrimaryKey(
                name: "pk_student_student_id",
                table: "Students",
                column: "student_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_specialty_specialty_id",
                table: "Specialtys",
                column: "specialty_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_group_group_id",
                table: "Groups",
                column: "group_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_grade_grade_id",
                table: "Grades",
                column: "grade_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_discipline_discipline_id",
                table: "Disciplines",
                column: "discipline_id");

            migrationBuilder.AddForeignKey(
                name: "fk_grade_discipline_id",
                table: "Grades",
                column: "discipline_id",
                principalTable: "Disciplines",
                principalColumn: "discipline_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_grade_student_id",
                table: "Grades",
                column: "student_id",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_group_specialty_id",
                table: "Groups",
                column: "specialty_id",
                principalTable: "Specialtys",
                principalColumn: "specialty_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_student_group_id",
                table: "Students",
                column: "group_id",
                principalTable: "Groups",
                principalColumn: "group_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_grade_discipline_id",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "fk_grade_student_id",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "fk_group_specialty_id",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "fk_student_group_id",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "pk_student_student_id",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "pk_specialty_specialty_id",
                table: "Specialtys");

            migrationBuilder.DropPrimaryKey(
                name: "pk_group_group_id",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "pk_grade_grade_id",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "pk_discipline_discipline_id",
                table: "Disciplines");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Students",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Students",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "idx_student_fk_group_id",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Specialtys",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "Specialtys",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "specialty_id",
                table: "Specialtys",
                newName: "SpecialtyId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Groups",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "course",
                table: "Groups",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "specialty_id",
                table: "Groups",
                newName: "SpecialtyId");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Groups",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "Groups",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "idx_group_fk_specialty_id",
                table: "Groups",
                newName: "IX_Groups_SpecialtyId");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "Grades",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Grades",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Grades",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "discipline_id",
                table: "Grades",
                newName: "DisciplineId");

            migrationBuilder.RenameColumn(
                name: "grade_id",
                table: "Grades",
                newName: "GradeId");

            migrationBuilder.RenameIndex(
                name: "idx_grade_fk_student_id",
                table: "Grades",
                newName: "IX_Grades_StudentId");

            migrationBuilder.RenameIndex(
                name: "idx_grade_fk_discipline_id",
                table: "Grades",
                newName: "IX_Grades_DisciplineId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Disciplines",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Disciplines",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "discipline_id",
                table: "Disciplines",
                newName: "DisciplineId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Students",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Specialtys",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Specialtys",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "isDeleted",
                table: "Groups",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Grades",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Disciplines",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Disciplines",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialtys",
                table: "Specialtys",
                column: "SpecialtyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "GradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disciplines",
                table: "Disciplines",
                column: "DisciplineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Disciplines_DisciplineId",
                table: "Grades",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Specialtys_SpecialtyId",
                table: "Groups",
                column: "SpecialtyId",
                principalTable: "Specialtys",
                principalColumn: "SpecialtyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
