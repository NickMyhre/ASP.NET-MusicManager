using AutoMapper;
using MusicManager.Models;
using MusicManager.ViewModels.Artist;
using MusicManager.ViewModels.Song;

namespace MusicManager.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Artist, ArtistDto>().ReverseMap();
            CreateMap<Artist, ArtistDetailsDto>().ReverseMap();
            CreateMap<Artist, CreateArtistDto>().ReverseMap();
            CreateMap<Artist, UpdateArtistDto>().ReverseMap();

            CreateMap<Song, SongDto>().ReverseMap();
        }
    }
}
