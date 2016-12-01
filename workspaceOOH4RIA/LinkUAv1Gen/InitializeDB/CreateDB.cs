
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LinkUAv1GenNHibernate.EN.LinkUAv1;
using LinkUAv1GenNHibernate.CEN.LinkUAv1;
using LinkUAv1GenNHibernate.CAD.LinkUAv1;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local); database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                /*List<LinkUAv1GenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<LinkUAv1GenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * LinkUAv1GenNHibernate.EN.Mediaplayer.UserEN userEN = new LinkUAv1GenNHibernate.EN.Mediaplayer.UserEN();
                 * LinkUAv1GenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new LinkUAv1GenNHibernate.EN.Mediaplayer.ArtistEN();
                 * LinkUAv1GenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new LinkUAv1GenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * LinkUAv1GenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new LinkUAv1GenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * LinkUAv1GenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new LinkUAv1GenNHibernate.CEN.Mediaplayer.UserCEN();
                 * LinkUAv1GenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new LinkUAv1GenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * LinkUAv1GenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new LinkUAv1GenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Define Album
                 * //LinkUAv1GenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new LinkUAv1GenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/

                //Convert.ToDateTime("05/12/1995")

                TitulacionCEN titu = new TitulacionCEN ();
                AsignaturaCEN asig = new AsignaturaCEN ();

                titu.New_ ("Ingeniería Informática");
                asig.New_ ("PROGRAMACION 1", 1, 1);
                asig.New_ ("MATEMATICAS 1", 1, 1);
                asig.New_ ("FUNDAMENTOS FISICOS DE LA INFORMATICA", 1, 1);
                asig.New_ ("FUNDAMENTOS DE LOS COMPUTADORES", 1, 1);
                asig.New_ ("SISTEMAS Y TECNOLOGÍAS DE INFORMACIÓN", 1, 1);
                asig.New_ ("MATEMATICA DISCRETA", 1, 1);
                asig.New_ ("PROGRAMACION 2", 1, 1);
                asig.New_ ("FUNDAMENTOS DE LAS BASES DE DATOS", 1, 1);
                asig.New_ ("ESTRUCTURA DE LOS COMPUTADORES", 1, 1);
                asig.New_ ("ESTADISTICA", 2, 1);
                asig.New_ ("SISTEMAS OPERATIVOS", 2, 1);
                asig.New_ ("DISEÑO DE BASES DE DATOS", 2, 1);
                asig.New_ ("REDES DE COMPUTADORES", 2, 1);
                asig.New_ ("PROGRAMACION 3", 2, 1);
                asig.New_ ("PROGRAMACION Y ESTRUCTURAS DE DATOS", 2, 1);
                asig.New_ ("LENGUAJES Y PARADIGMAS DE PROGRAMACION", 2, 1);

                titu.New_ ("Ingeniería Química");
                titu.New_ ("Ingeniería Robótica");

                titu.New_ ("Español: Lengua y Literaturas");
                asig.New_ ("DIALECTO ÁRABE MAGREBÍ", 1, 4);
                asig.New_ ("PROGRAMACION 1", 1, 4);

                titu.New_ ("Estudios Árabes e Islámicos");
                titu.New_ ("Estudios Franceses");
                titu.New_ ("Biología");
                titu.New_ ("Ciencias del Mar");
                titu.New_ ("Geología");
                titu.New_ ("Matemáticas");
                titu.New_ ("Química");
                titu.New_ ("Enfermería");

                titu.New_ ("Nutrición Humana y Dietética");
                titu.New_ ("Óptica y Optometría");
                titu.New_ ("Criminología");
                titu.New_ ("Derecho");
                titu.New_ ("Derecho + ADE (DADE)");
                titu.New_ ("Arquitectura Técnica");
                titu.New_ ("Fundamentos de la Arquitectura");

                UsuarioCEN usucen = new UsuarioCEN ();
                usucen.New_ ("admin@alu.ua.es", "admin", "Admin", "Miiiiiiin", new DateTime (2000, 1, 1), "123456789", "admin", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum.administrador, 1);

                usucen.New_ ("ara65@alu.ua.es", "ara65", "Reyes", "Pro", DateTime.Now, "123456789", "ara1995", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum.administrador, 1);
                usucen.New_ ("ast26@alu.ua.es", "Adria", "Segura", "Tarraso", DateTime.Now, "644000000", "1234", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum.activo, 1);
                usucen.New_ ("ajan1@alu.ua.es", "Adry", "Aura", "Nieto", DateTime.Now, "987654321", "adry", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum.activo, 1);
                usucen.New_ ("msp73@alu.ua.es", "Miguel", "Sancho", "Peña", DateTime.Now, "124378102", "admin", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.EstadoEnum.administrador, 1);

                PublicacionCEN publicen = new PublicacionCEN ();
                publicen.New_ ("Hola Mundo", "Esta es la primera publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 12, 57, 5), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Otros);
                publicen.New_ ("Hola, otra vez", "Esta es la segunda publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 14, 10, 2), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Otros);
                publicen.New_ ("Hayyda! HAMIJOS!", "No se komo dar liek :S:S", false, false, DateTime.Now, 0, "ast26@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Social);
                publicen.New_ ("Clase2", "Publis XDXD.", false, false, DateTime.Now, 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Academico);
                publicen.New_ ("Piso1", "Esta es la segunda publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 14, 10, 2), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Piso);
                publicen.New_ ("Piso2", "Esta es la segunda publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 14, 10, 2), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Piso);
                publicen.New_ ("Piso3", "Esta es la segunda publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 14, 10, 2), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Piso);
                publicen.New_ ("Social1", "Esta es la segunda publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 14, 10, 2), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Social);
                publicen.New_ ("Social2", "Esta es la segunda publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 14, 10, 2), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Social);
                publicen.New_ ("Amor1", "Esta es la segunda publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 14, 10, 2), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Amor);
                publicen.New_ ("Amor2", "Esta es la segunda publicación que se realiza de prueba.", false, false, new DateTime (2016, 4, 10, 14, 10, 2), 0, "admin@alu.ua.es", LinkUAv1GenNHibernate.Enumerated.LinkUAv1.CategoriaEnum.Amor);


                publicen.Dar_like (1, "ara65@alu.ua.es");
                publicen.Dar_like (1, "admin@alu.ua.es");
                //publicen.Quitar_like(1, "ara65@alu.ua.es");
                //Console.WriteLine(publicen.Likeado(1, "ara65@alu.ua.es"));
                //Console.WriteLine(publicen.Likeado(1, "admin@alu.ua.es"));

                ComentarioCEN comenCEN = new ComentarioCEN ();
                comenCEN.New_ ("Muy guena, mi like acá se lo dejo", DateTime.Now, 0, "admin@alu.ua.es", 1);
                comenCEN.New_ ("PD: Me gusta el diseño", DateTime.Now, 0, "admin@alu.ua.es", 1);
                comenCEN.New_ ("Jajajaj", DateTime.Now, 0, "ara65@alu.ua.es", 1);
                comenCEN.New_ ("Segunda ya? kual es la 1a xd", DateTime.Now, 0, "ajan1@alu.ua.es", 2);
                comenCEN.New_ ("AJAJAJAJA no t rayes tio... chat ya!", DateTime.Now, 0, "admin@alu.ua.es", 3);
                comenCEN.New_ ("qlokoxd!", DateTime.Now, 0, "ajan1@alu.ua.es", 3);

                comenCEN.Dar_like (1, "ara65@alu.ua.es");
                comenCEN.Dar_like (1, "admin@alu.ua.es");
                //comenCEN.Quitar_like(1, "ara65@alu.ua.es");
                //Console.WriteLine(comenCEN.Likeado(1, "ara65@alu.ua.es"));
                //Console.WriteLine(comenCEN.Likeado(1, "admin@alu.ua.es"));

                MaterialCEN matCEN = new MaterialCEN ();
                matCEN.New_ ("GOOGLE", "El buscador más usado en todo el mundo", "http://www.google.es", 0, 1, "admin@alu.ua.es");
                matCEN.New_ ("Práctica 8", "Esta es la práctica 8 del año en que cursé P1. La llamamos la 'PROCHO'.", "https://drive.google.com/file/d/0B8qsO0HHo8M2UnRtTXVHSXEyUEU/view?usp=sharing", 0, 1, "ast26@alu.ua.es");

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
