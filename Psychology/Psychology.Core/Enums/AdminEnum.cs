using System.ComponentModel;

namespace Psychology.Core.Enums
{
    public enum AdminStatusEnum
    {
        [Description("Aktiv")]
        Active = 1, 
        [Description("Deaktiv")]
        Deactive = 2,
        [Description("Gözləmədə")]
        OnHold = 3
    }
}
