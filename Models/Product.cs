namespace MOS.Models
{
    /// <summary>
    /// This class shall represent a product, kitted with all necessary informations by GS1 Standards, open for further extension
    /// </summary>
    public class Product
    {
        #region Fields
        private string m_gtin;
        private DateTime m_expirationDate;
        private string m_lot;
        private bool m_isFavorite;
        private DateTime m_scanDate;
        #endregion

        #region Properties
        public string GTIN
        {
            get => m_gtin;
            set => m_gtin = value;
        }

        public DateTime ExpirationDate
        {
            get => m_expirationDate;
            set => m_expirationDate = value;
        }

        public string LOT
        {
            get => m_lot; 
            set => m_lot = value;
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
            m_gtin = string.Empty;
            m_expirationDate = DateTime.MinValue;
            m_lot = string.Empty;
            m_scanDate = DateTime.Today;
        }

        /// <summary>
        /// Allows to construct a product object instance with dependency injection of necessary GS1 Data
        /// </summary>
        /// <param name="_gtin"></param>
        /// <param name="_expirationDate"></param>
        /// <param name="_lot"></param>
        public Product(string _gtin, DateTime _expirationDate, string _lot)
        {
            m_gtin = _gtin;
            m_expirationDate = DateTime.MinValue;
            m_lot = _lot;
            m_scanDate = DateTime.Today;
        }

        #endregion 
    }
}