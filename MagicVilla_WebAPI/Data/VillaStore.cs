using MagicVilla_WebAPI.Models.Dto;

namespace MagicVilla_WebAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
            new VillaDTO { Id = 1, Name = "Touseef" },
            new VillaDTO { Id = 2, Name = "Aarzoo" }
        };
    }
}
