using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
//    [DbContext(typeof(AppDbContext))]
//    partial class AppDbContextModelSnapshot : ModelSnapshot
//    {
//        protected override void BuildModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "8.0.13")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128);

//            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

//            modelBuilder.Entity("EF_Core_Session01_Demo.Entities.Department", b =>
//            {
//                b.Property<int>("Id")
//                    .ValueGeneratedOnAdd()
//                    .HasColumnType("int");

//                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                b.Property<DateTime>("DateOfCreation")
//                    .HasColumnType("datetime2");

//                b.Property<string>("Name")
//                    .IsRequired()
//                    .HasColumnType("nvarchar(max)");

//                b.HasKey("Id");

//                b.ToTable("Departments");
//            });

//            modelBuilder.Entity("EF_Core_Session01_Demo.Entities.Employee", b =>
//            {
//                b.Property<string>("EmpId")
//                    .HasColumnType("nvarchar(450)");

//                b.Property<int?>("Age")
//                    .HasColumnType("int");

//                b.Property<DateTime>("DateOfCreation")
//                    .ValueGeneratedOnAdd()
//                    .HasColumnType("datetime2")
//                    .HasDefaultValueSql("GETDATE()");

//                b.Property<string>("Email")
//                    .IsRequired()
//                    .HasColumnType("nvarchar(max)");

//                b.Property<string>("Name")
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .HasColumnType("varchar")
//                    .HasColumnName("EmployeeName");

//                b.Property<decimal>("Salary")
//                    .HasColumnType("money");

//                b.HasKey("EmpId");

//                b.ToTable("Employees");
//            });
//#pragma warning restore 612, 618
//        }
   }
