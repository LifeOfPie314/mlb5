using AutoMapper;
using Mlb5.Models;

namespace Mlb5.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Setup()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Game, GamePick>();
                cfg.CreateMap<GameTeam, GamePickTeam>();
            });
        }
    }
}