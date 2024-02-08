using MagicVilla_WebAPI.Models.Dto;

namespace MagicVilla_WebAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
            new VillaDTO { Id = 1, Name = "Touseef", Occupancy = 100, SqFt = 1 },
            new VillaDTO { Id = 2, Name = "Aarzoo", Occupancy = 300, SqFt = 3 }
        };
    }
}
