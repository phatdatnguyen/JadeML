using System.Data;

namespace JadeChem.CustomEventArgs
{
    public class DataTableEventArgs : EventArgs
    {
        #region Property
        public DataTable Dataset { get; set; }
        #endregion
    }
}
