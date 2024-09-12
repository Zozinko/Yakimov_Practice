using Console;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppi.Entities
{
    public class DefaultPreset
    {
        [Key]
        public int Id { get; set; }

        public int ZolaOfCocsickId { get; set; }

        [ForeignKey(nameof(ZolaOfCocsickId))]
        public ZolaOfCocsickDB ZolaOfCocksick { get; set; }

        public int CocksickId {  get; set; }

        [ForeignKey(nameof(CocksickId))]
        public CocksickDB Cocksick { get; set; }

        public int FluxAdditionsId { get; set; }

        [ForeignKey(nameof(FluxAdditionsId))]
        public FluxAdditionsDB FluxAdditions { get; set; }

        public int MmkCoefId { get; set; }

        [ForeignKey(nameof(MmkCoefId))]
        public MmkCoefDB MmkCoef { get; set; }
        public List<ShihtaComponentsDB> ShihtaComponents { get; set; }

        public int StartEnterId { get; set; }

        [ForeignKey(nameof(StartEnterId))]
        public StartEnterDB StartEnter { get; set; }
    }
}
