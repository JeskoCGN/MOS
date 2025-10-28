namespace MOS.Models
{
    /// <summary>
    /// This Class represents the informations coming from GS1 QR Codes aggregated into a class object.
    /// </summary>
    class GS1_DataAsset
    {
        #region Fields
        private string m_gtin;
        private DateTime m_expDate;
        private string m_lot;
        #endregion

        #region Properties
        public string GTIN
        {
            get => m_gtin;
            set => m_gtin = value;
        }

        public DateTime ExpDate
        {
            get => m_expDate;
            set => m_expDate = value;
        }

        public string LOT
        {
            get => m_lot;
            set => m_lot = value;
        }
        #endregion

        #region Constructors
        public GS1_DataAsset()
        {
            
        }

        public GS1_DataAsset(string _gtin, DateTime _expDate, string _lot)
        {
            m_gtin = _gtin;
            m_expDate = _expDate;
            m_lot = _lot;
        }
        #endregion
    }
}
