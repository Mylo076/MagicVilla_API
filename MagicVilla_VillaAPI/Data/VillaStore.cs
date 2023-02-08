using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name = "Villa Florio", Occupancy = 3, Sqft = 100},
                new VillaDTO { Id = 2, Name = "Villa Romita", Occupancy = 5, Sqft = 120}
            };
    }
}
