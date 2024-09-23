using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egz1kons
{
    public class Methods
    {
        string path = "C:\\Users\\patryk.labuz\\Desktop\\egz1kons\\Data.txt";

        public List<FilmData> GetDataFromTxt()
        {
            List<FilmData> filmDatas = new List<FilmData>();
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                List<string> updatedLines = new List<string>();

                foreach (var line in lines)
                {
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        updatedLines.Add(line);
                    }
                }

                for (int i = 0; i < updatedLines.Count; i += 5)
                {
                    try
                    {
                        FilmData newFilmData = new FilmData
                        {
                            artist = updatedLines[i],
                            album = updatedLines[i + 1],
                            songsNumber = int.Parse(updatedLines[i + 2]),
                            year = int.Parse(updatedLines[i + 3]),
                            downloadNumber = int.Parse(updatedLines[i + 4])
                        };
                        filmDatas.Add(newFilmData);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Błąd podczas przetwarzania danych: {ex.Message}");
                    }
                }
            }
            return filmDatas;

        }

        public void DisplayData(List<FilmData> data)
        {
            foreach (var film in data)
            {
                Console.WriteLine($"\nArtysta: {film.artist}, \nAlbum: {film.album}, \nLiczba utworów: {film.songsNumber}, \nRok: {film.year}, \nLiczba pobrań: {film.downloadNumber}");
            }
        }

        /**********************************************
        nazwa funkcji: GetDataFromTxt
        opis funkcji: Funkcja pobiera dane z pliku tekstowego, dodaje je do struktury oraz do listy struktur
        parametry: Brak
        zwracany typ i opis: Zwraca listę z elementami struktury FilmData
        autor: Patryk Łabuz
        ***********************************************/

    }
}
