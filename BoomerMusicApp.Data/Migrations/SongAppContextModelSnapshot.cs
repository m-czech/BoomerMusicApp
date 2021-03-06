// <auto-generated />
using System;
using BoomerMusicApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoomerMusicApp.Data.Migrations
{
    [DbContext(typeof(SongAppContext))]
    partial class SongAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BoomerMusicApp.Data.Entities.Song", b =>
                {
                    b.Property<Guid>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Lenght")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = new Guid("8b650b0b-c0f8-4a17-a49c-3d6702633a3e"),
                            AlbumName = "Lost & Found",
                            Author = "Jorja Smith",
                            Lenght = 4.0999999999999996,
                            Title = "Blue lights"
                        },
                        new
                        {
                            SongId = new Guid("83cb8a03-5fab-48a9-8dba-bb69b2909b82"),
                            AlbumName = "Best Things in Life",
                            Author = "Dreamliners",
                            Lenght = 2.23,
                            Title = "Best things in life"
                        },
                        new
                        {
                            SongId = new Guid("880f21f5-3529-45fb-bf7e-97433cd03713"),
                            AlbumName = "Nase male spiwanie",
                            Author = "Siklawa",
                            Lenght = 3.4300000000000002,
                            Title = "Takiego Janicka"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
