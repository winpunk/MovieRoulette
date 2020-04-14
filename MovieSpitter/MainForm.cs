using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace MovieSpitter
{
    public partial class MainForm : Form
    {
        private int movieCount = 0;
        private SearchResults results;

        private static string provider = ConfigurationManager.AppSettings["provider"];
        private string connectionString = ConfigurationManager.AppSettings["connectionString"];

        private const string URL = "http://www.omdbapi.com/";
        private string urlParameters = "?apikey=d4efe28b&type=movie";

        //DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
        public MainForm ()
        {
            InitializeComponent();

            RefreshMovieList();
        }

        private void deleteBtn_Click (object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("ERROR");
                    return;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                //SqlCommand command = factory.CreateCommand();
                SqlCommand command = new SqlCommand();

                if (command == null)
                {
                    Console.WriteLine("ERROR command");
                    return;
                }

                command.Connection = connection;

                command.CommandText = "Delete From Movies WHERE MovieId = @selectedMovie";// '" + MovieList.SelectedItems[0].Text + "'";
                command.Parameters.Add("@selectedMovie", SqlDbType.NVarChar);
                command.Parameters["@selectedMovie"].Value = MovieList.SelectedItems[0].Text;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    RefreshMovieList();
                }
            }
        }

        private void RefreshMovieList ()
        {
            MovieList.Items.Clear();

            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    if (connection == null)
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }

                    connection.ConnectionString = connectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    if (command == null)
                    {
                        Console.WriteLine("ERROR command");
                        return;
                    }

                    command.Connection = connection;

                    command.CommandText = "Select * From Movies";

                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine($"{reader["MovieId"]} " + $"{reader["Name"]} " + $"{reader["Year"]}" + $"{reader["Director"]}" + $"{reader["IMDB_rating"]}");

                            string[] row = new string[] { $"{ reader["MovieId"] }", $"{ reader["Title"] }", $"{ reader["Year"] }", $"{reader["Director"]}", $"{reader["IMDB_rating"]}", $"{reader["Trailer_link"]}" };

                            for (int i = 0; i < row.Length; i++)
                            {
                                row[i] = row[i].TrimEnd(' ');
                            }

                            var listViewItem = new ListViewItem(row);
                            MovieList.Items.Add(listViewItem);
                        }
                    }

                    command.CommandText = "SELECT COUNT(*) FROM Movies";
                    movieCount = (int) command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void RandomBtn_Click (object sender, EventArgs e)
        {
            Random rnd = new Random();
            MessageBox.Show("You have to watch - \"" + MovieList.Items[rnd.Next(0, movieCount)].SubItems[1].Text + "\" !!!");
        }

        public class SearchResults
        {
            public List<MovieData> Search { get; set; }
        }

        public class MovieData
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string imdbID { get; set; }
        }

        public class MovieLong
        {
            public string imdbID { get; set; }
            public string Title { get; set; }
            public string Year { get; set; }
            public string Director { get; set; }

            public string imdbRating { get; set; }
        }

        private void SearchBtn_Click (object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    if (connection == null)
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }

                    connection.ConnectionString = connectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    if (command == null)
                    {
                        Console.WriteLine("ERROR command");
                        return;
                    }

                    command.Connection = connection;

                    if (!string.IsNullOrEmpty(LocTitleBox.Text))
                    {
                        MovieList.Items.Clear();

                        command.CommandText = "Select * From Movies Where (Title Like '%' + @title + '%')";
                        command.Parameters.Add("@title", SqlDbType.NVarChar);
                        command.Parameters["@title"].Value = LocTitleBox.Text;

                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string[] row = new string[] { $"{ reader["MovieId"] }", $"{ reader["Title"] }", $"{ reader["Year"] }", $"{reader["Director"]}", $"{reader["IMDB_rating"]}", $"{reader["Trailer_link"]}" };

                                for (int i = 0; i < row.Length; i++)
                                {
                                    row[i] = row[i].TrimEnd(' ');
                                }

                                var listViewItem = new ListViewItem(row);
                                MovieList.Items.Add(listViewItem);
                            }
                        }
                    }
                    else if (!string.IsNullOrEmpty(LocYearBox.Text))
                    {
                        MovieList.Items.Clear();

                        char evalSymbol = '=';
                        string value = LocYearBox.Text;
                        if (LocYearBox.Text.Contains(">") || LocYearBox.Text.Contains("<"))
                        {
                            evalSymbol = LocYearBox.Text.Substring(0, 1).ToCharArray()[0];
                            value = LocYearBox.Text.Substring(1);
                        }

                        command.CommandText = "Select * From Movies Where Year " + evalSymbol + " @value";
                        command.Parameters.Add("@value", SqlDbType.NVarChar);
                        command.Parameters["@value"].Value = value;

                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string[] row = new string[] { $"{ reader["MovieId"] }", $"{ reader["Title"] }", $"{ reader["Year"] }", $"{reader["Director"]}", $"{reader["IMDB_rating"]}", $"{reader["Trailer_link"]}" };

                                for (int i = 0; i < row.Length; i++)
                                {
                                    row[i] = row[i].TrimEnd(' ');
                                }
                                var listViewItem = new ListViewItem(row);
                                MovieList.Items.Add(listViewItem);
                            }
                        }
                    }
                    else if (!string.IsNullOrEmpty(LocDirectorBox.Text))
                    {
                        MovieList.Items.Clear();

                        command.CommandText = "Select * From Movies Where (Director Like '%' + @director + '%')";
                        command.Parameters.Add("@director", SqlDbType.NVarChar);
                        command.Parameters["@director"].Value = LocDirectorBox.Text;

                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string[] row = new string[] { $"{ reader["MovieId"] }", $"{ reader["Title"] }", $"{ reader["Year"] }", $"{reader["Director"]}", $"{reader["IMDB_rating"]}", $"{reader["Trailer_link"]}" };

                                for (int i = 0; i < row.Length; i++)
                                {
                                    row[i] = row[i].TrimEnd(' ');
                                }
                                var listViewItem = new ListViewItem(row);
                                MovieList.Items.Add(listViewItem);
                            }
                        }
                    }
                    else if (!string.IsNullOrEmpty(LocRatingBox.Text))
                    {
                        MovieList.Items.Clear();

                        char evalSymbol = '=';
                        string value = LocRatingBox.Text;
                        if (LocRatingBox.Text.Contains(">") || LocRatingBox.Text.Contains("<"))
                        {
                            evalSymbol = LocRatingBox.Text.Substring(0, 1).ToCharArray()[0];
                            value = LocRatingBox.Text.Substring(1);
                        }

                        command.CommandText = "Select * From Movies Where IMDB_rating " + evalSymbol + " @value";
                        command.Parameters.Add("@value", SqlDbType.NVarChar);
                        command.Parameters["@value"].Value = value;

                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string[] row = new string[] { $"{ reader["MovieId"] }", $"{ reader["Title"] }", $"{ reader["Year"] }", $"{reader["Director"]}", $"{reader["IMDB_rating"]}", $"{reader["Trailer_link"]}" };

                                for (int i = 0; i < row.Length; i++)
                                {
                                    row[i] = row[i].TrimEnd(' ');
                                }

                                var listViewItem = new ListViewItem(row);
                                MovieList.Items.Add(listViewItem);
                            }
                        }
                    }
                    else
                    {
                        RefreshMovieList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private async void ImdbSearchBtn_Click (object sender, EventArgs e)
        {
            imdbListView.Items.Clear();

            results = new SearchResults();

            if (!String.IsNullOrEmpty(imdbTitleTxt.Text))
            {
                urlParameters += "&s=" + imdbTitleTxt.Text;
            }
            if (!String.IsNullOrEmpty(imdbYearTxt.Text))
            {
                urlParameters += "&y=" + imdbYearTxt.Text;
            }

            imdbTitleTxt.Text = "";
            imdbYearTxt.Text = "";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL);

                    client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync(urlParameters).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        results = await response.Content.ReadAsAsync<SearchResults>();

                        if (results.Search != null)
                        {
                            foreach (var d in results.Search)
                            {
                                string[] row = new string[] { d.imdbID, d.Title, d.Year };
                                var listViewItem = new ListViewItem(row);
                                imdbListView.Items.Add(listViewItem);
                            }
                        }
                        else MessageBox.Show("No results!");
                    }
                    else
                    {
                        Console.WriteLine("{0} ({1})", (int) response.StatusCode, response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                urlParameters = "?apikey=d4efe28b&type=movie";
            }
        }

        private async void addMovieBtn_Click (object sender, EventArgs e)
        {
            MovieLong movie = new MovieLong();

            int selIndex = imdbListView.SelectedIndices[0];

            String link = "https://www.imdb.com/title/" + results.Search[selIndex].imdbID + "/";

            urlParameters += "&i=" + results.Search[selIndex].imdbID;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL);

                    // Add an Accept header for JSON format.
                    client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                    // List data response.
                    HttpResponseMessage response = client.GetAsync(urlParameters).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body.
                        movie = await response.Content.ReadAsAsync<MovieLong>();
                    }
                    else
                    {
                        Console.WriteLine("{0} ({1})", (int) response.StatusCode, response.ReasonPhrase);
                    }
                }

                urlParameters = "?apikey=d4efe28b&type=movie";

                using (SqlConnection connection = new SqlConnection())
                {
                    if (connection == null)
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }

                    connection.ConnectionString = connectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    if (command == null)
                    {
                        Console.WriteLine("ERROR command");
                        return;
                    }

                    command.Connection = connection;

                    //command.CommandText = "INSERT Movies (MovieId, Title, Year, Director, IMDB_rating, Trailer_link) VALUES ('" + movie.imdbID.Trim('\'') + "','" + movie.Title.Trim('\'') + "'," + movie.Year + ", '" + movie.Director.Trim('\'') + "' ," + movie.imdbRating + ", '" + link + "')" ;
                    command.CommandText = "INSERT Movies (MovieId, Title, Year, Director, IMDB_rating, Trailer_link) VALUES (@id, @title, @year, @director, @rating, @link)";
                    command.Parameters.Add("@id", SqlDbType.NVarChar);
                    command.Parameters["@id"].Value = movie.imdbID;
                    command.Parameters.Add("@title", SqlDbType.NVarChar);
                    if (movie.Title.Length > 30) movie.Title = movie.Title.Substring(0, 29);
                    command.Parameters["@title"].Value = movie.Title;
                    command.Parameters.Add("@year", SqlDbType.Int);
                    command.Parameters["@year"].Value = movie.Year;
                    command.Parameters.Add("@director", SqlDbType.NVarChar);
                    if (movie.Director.Length > 30) movie.Director = movie.Director.Substring(0, 29);
                    command.Parameters["@director"].Value = movie.Director;
                    command.Parameters.Add("@rating", SqlDbType.Decimal);
                    command.Parameters["@rating"].Value = movie.imdbRating;
                    command.Parameters.Add("@link", SqlDbType.NVarChar);
                    command.Parameters["@link"].Value = link;

                    command.ExecuteNonQuery();

                    RefreshMovieList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                urlParameters = "?apikey=d4efe28b&type=movie";
            }
        }

        private void MovieList_DoubleClick (object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(MovieList.SelectedItems[0].SubItems[5].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void imdbTitleTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ImdbSearchBtn_Click(sender, e);

            
        }

        private void MovieList_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            MovieList.Sort();
        }
    }
}