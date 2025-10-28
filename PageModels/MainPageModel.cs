using MOS.Models;
using System.ComponentModel;
using System.Diagnostics;

namespace MOS.PageModels
{
    public class MainPageModel : INotifyPropertyChanged
    {
        #region Fields
        private ProductManager m_productManager;
        private string m_log;
        #endregion

        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Properties
        // Commands
        public DelegateCommand ButtonClick_TestButton { get; set; }

        // other Properties
        public string Log
        {
            get => m_log;
            set
            {
                m_log = value;
                PropertyChanged?.Invoke("Log", new PropertyChangedEventArgs(m_log));
            }
        }
        #endregion

        #region Constructors
        public MainPageModel()
        {
            m_productManager = new ProductManager();
            OnInitialize();
        }

        #endregion

        #region Initializers
        private void OnInitialize()
        {
            ButtonClick_TestButton = new DelegateCommand(
                _ => OnButtonClick_AddProduct(),
                _ => true
                );
        }
        #endregion 


        #region Private Methods
        public void OnButtonClick_AddProduct()
        {
            m_productManager.AddProduct();
        }
        #endregion
    }
}