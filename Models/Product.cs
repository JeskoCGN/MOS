namespace MOS.Models
{
    public class Product
    {
        #region Fields
        private string m_name;
        private string m_gtin;
        private string m_expirationDate;
        private string m_serialNumber;
        private bool m_isFavorite;
        private DateTime m_scanDate;
        #endregion


        #region Properties
        public string Name
        {
            get => m_name;
            set => m_name = value;
        }

        public string GTIN
        {
            get => m_gtin;
            set => m_gtin = value;
        }

        public string ExpirationDate
        {
            get => m_expirationDate;
            set => m_expirationDate = value;
        }

        public string SerialNumber
        {
            get => m_serialNumber;
            set => m_serialNumber = value;
        }

        public bool IsFavorite
        {
            get => m_isFavorite;
            set => m_isFavorite = value;
        }

        public DateTime ScanDate
        {
            get => m_scanDate;
            set => m_scanDate = value;
        }
        #endregion

        #region Constructors
        public Product()
        {
            m_name = string.Empty;
            m_gtin = string.Empty;
            m_expirationDate = string.Empty;
            m_serialNumber = string.Empty;
            m_scanDate = DateTime.MinValue;
        }

        public Product(string _name, string _gtin, string _expirationDate, string _serialNumber)
        {
            m_name = _name;
            m_gtin = _gtin;
            m_expirationDate = _expirationDate;
            m_serialNumber = _serialNumber;
        }

        #endregion 
    }
}