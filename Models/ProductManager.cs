namespace MOS.Models
{
    class ProductManager
    {
        #region Fields
        private List<Product> m_products = new();
        
        #endregion

        #region Properties
        public List<Product> Products
        {
            get => m_products;
            set => m_products = value;
        }

        #endregion


        #region Constructors
        public ProductManager()
        {
            
        }

        #endregion


        #region Public Methods
        //Add Product
        public void AddProduct(string _name, string _gtin, string _expirationDate, string _serialNumber)
        {
            Product productToAdd = new Product(_name, _gtin, _expirationDate, _serialNumber);
            m_products.Add(productToAdd);
        }

        //Remove Product
        public bool RemoveProduct(string _name)
        {
            try
            {
                m_products.RemoveAll(x => x.Name == _name);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        #endregion



        #region Private Methods 
        //DB Stuff

        #endregion
    }
}
