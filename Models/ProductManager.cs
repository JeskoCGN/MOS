using System.ComponentModel;
using System.Diagnostics;

namespace MOS.Models
{
    class ProductManager
    {
        #region Fields
        private GS1Parser m_gs1Parser;
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
            m_gs1Parser = new GS1Parser();
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Adds Product to List as type Product and returns adding success
        /// </summary>
        public bool AddProduct(out GS1_DataAsset _dataAsset)
        {
            try
            {
                QRReader reader = new QRReader();
                var gs1_data = m_gs1Parser.ParseInputToGS1(reader.TryReadQR());
                Product productToAdd = new Product(gs1_data.GTIN, gs1_data.ExpDate, gs1_data.LOT);
                m_products.Add(productToAdd);
                _dataAsset = gs1_data;
                return true;
            }
            catch (Exception _ex)
            {
                Debug.WriteLine(_ex);
                _dataAsset = null;
                return false;
            }
        }

        /// <summary>
        /// Removes ALL Products from Product List by GTIN and returns removal success
        /// </summary>
        /// <param name="_gtin"></param>
        /// <returns></returns>
        public bool RemoveAllProductsGTIN(string _gtin)
        {
            try
            {
                m_products.RemoveAll(x => x.GTIN == _gtin);
                return true;
            }
            catch (Exception _ex)
            {
                return false;
                throw _ex;
            }
        }

        /// <summary>
        /// Removes ALL Products from Product List by LOT and returns removal success
        /// </summary>
        /// <param name="_lot"></param>
        /// <returns></returns>
        public bool RemoveAllProductsLot(string _lot)
        {
            try
            {
                m_products.RemoveAll(x => x.LOT == _lot);
                return true;
            }
            catch (Exception _ex)
            {
                return false;
                throw _ex;
            }
        }

        /// <summary>
        /// Removes ALL Products from Product List by Expiration Date and returns removal success
        /// </summary>
        /// <param name="_dateTime"></param>
        /// <returns></returns>
        public bool RemoveAllProductsDateTime(DateTime _dateTime)
        {
            try
            {
                m_products.RemoveAll(x => x.ExpirationDate == _dateTime);
                return true;
            }
            catch (Exception _ex)
            {
                return false;
                throw _ex;
            }
        }

        /// <summary>
        /// Removes a certain product from the Product List and returns removal success
        /// </summary>
        /// <param name="_product"></param>
        /// <returns></returns>
        public bool RemoveProduct(Product _product)
        {
            try
            {
                m_products.Remove(_product);
                return true;
            }
            catch (Exception _ex)
            {
                return false;
                throw _ex;
            }
        }
        #endregion



        #region Private Methods 
        //DB Stuff

        private void DEBUG_Output(GS1_DataAsset _dataAsset)
        {
            Console.WriteLine(_dataAsset.GTIN.ToString());
            Console.WriteLine(_dataAsset.ExpDate.ToString());
            Console.WriteLine(_dataAsset.LOT.ToString());
        }
        #endregion
    }
}
