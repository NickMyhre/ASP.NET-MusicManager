using MusicManager.Enumerations.Sorting;
using MusicManager.Models;
using MusicManager.ViewModels.Album;
using MusicManager.ViewModels.Artist;
using MusicManager.ViewModels.Song;

namespace MusicManager.Utility
{
    public static class SortingHelper
    {
        public static List<ArtistDto> SortArtists(List<ArtistDto> artists, ArtistOrderBy orderBy)
        {
            switch (orderBy)
            {
                case ArtistOrderBy.LastName_asc:
                    return artists.OrderBy(x => x.GetLastName()).ToList();
                case ArtistOrderBy.Age_asc:
                    return artists.OrderBy(x => x.GetAge()).ToList();
                case ArtistOrderBy.SongAmount_asc:
                    return artists.OrderBy(x => x.Songs.Count()).ToList();
                case ArtistOrderBy.LastName_desc:
                    return artists.OrderByDescending(x => x.GetLastName()).ToList();
                case ArtistOrderBy.Age_desc:
                    return artists.OrderByDescending(x => x.GetAge()).ToList();
                case ArtistOrderBy.SongAmount_desc:
                    return artists.OrderByDescending(x => x.Songs.Count()).ToList();
            }

            return artists;
        }

        public static List<AlbumDto> SortAlbums(List<AlbumDto> albums, AlbumOrderBy orderBy)
        {
            switch (orderBy)
            {
                case AlbumOrderBy.Artist_asc:
                    return albums.OrderBy(x => x.Artists.Select(n => n.BirthName).Aggregate((i, j) => i + ", " + j)).ToList();
                case AlbumOrderBy.Title_asc:
                    return albums.OrderBy(x => x.Title).ToList();
                case AlbumOrderBy.Label_asc:
                    return albums.OrderBy(x => x.Label).ToList();
                case AlbumOrderBy.Genre_asc:
                    return albums.OrderBy(x => x.Genre).ToList();
                case AlbumOrderBy.ReleaseDate_asc:
                    return albums.OrderBy(x => x.ReleaseDate).ToList();
                case AlbumOrderBy.Artist_desc:
                    return albums.OrderByDescending(x => x.Artists.Select(n => n.BirthName).Aggregate((i, j) => i + ", " + j)).ToList();
                case AlbumOrderBy.Title_desc:
                    return albums.OrderByDescending(x => x.Title).ToList();
                case AlbumOrderBy.Label_desc:
                    return albums.OrderByDescending(x => x.Label).ToList();
                case AlbumOrderBy.Genre_desc:
                    return albums.OrderByDescending(x => x.Genre).ToList();
                case AlbumOrderBy.ReleaseDate_desc:
                    return albums.OrderByDescending(x => x.ReleaseDate).ToList();
            }
            return albums;
        }

        public static List<SongDto> SortSongs(List<SongDto> songs, SongOrderBy orderBy)
        {
            switch (orderBy)
            {
                case SongOrderBy.Name_asc:
                    return songs.OrderBy(x => x.Name).ToList();
                case SongOrderBy.Writer_asc:
                    return songs.OrderBy(x => x.Writer).ToList();
                case SongOrderBy.Length_asc:
                    return songs.OrderBy(x => x.Length).ToList();
                case SongOrderBy.Album_asc:
                    return songs.OrderBy(x => x.Album.Title).ToList();
                case SongOrderBy.BillboardRank_asc:
                    return songs.OrderBy(x => x.BillBoardRank).ToList();
                case SongOrderBy.Name_desc:
                    return songs.OrderByDescending(x => x.Name).ToList();
                case SongOrderBy.Writer_desc:
                    return songs.OrderByDescending(x => x.Writer).ToList();
                case SongOrderBy.Length_desc:
                    return songs.OrderByDescending(x => x.Length).ToList();
                case SongOrderBy.Album_desc:
                    return songs.OrderByDescending(x => x.Album.Title).ToList();
                case SongOrderBy.BillboardRank_desc:
                    return songs.OrderByDescending(x => x.BillBoardRank).ToList();
            }
            return songs;
        }
    }
}
