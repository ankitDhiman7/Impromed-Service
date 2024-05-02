using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Model
{
    internal class SPECIES
    {
    public Guid SpeciesGuid { get; set; }
    public string SpeciesName { get; set; }
    public byte[] Icon { get; set; }
    public short WeightUnit { get; set; }
    public int BackgroundColor { get; set; }
    public short PracticeVid { get; set; }
    public DateTime CreateDateTime { get; set; }
    public Guid CreateUserGuid { get; set; }
    public Guid CreateWorkstationGuid { get; set; }
    public Guid DeletedGuid { get; set; }
    public byte[] DeadIcon { get; set; }
    public byte[] InactiveIcon { get; set; }
    public Guid GlobalIconGuid { get; set; }
    public Guid GlobalDeadIconGuid { get; set; }
    public Guid GlobalInactiveIconGuid { get; set; }
    }
}
