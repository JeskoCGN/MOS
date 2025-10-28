using MOS.Models;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MOS.PageModels
{
    public class MainPageModel : INotifyPropertyChanged
    {
        #region Fields
        private ProductManager m_productManager;
        private string m_log;
        private GS1_DataAsset m_lastProductEntry;
        #endregion

        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        public event Action<string, string, string>? OnProductEntryReceived;
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
                OnPropertyChanged();
            }
        }

        public GS1_DataAsset LastProductEntry
        {
            get => m_lastProductEntry;
            set
            {
                if (m_lastProductEntry != value)
                {
                    OnPropertyChanged();
                    m_lastProductEntry = value;
                }
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

        #region Public Methods
        public void OnButtonClick_AddProduct()
        {
            LastProductEntry = null;
            m_productManager.AddProduct(out m_lastProductEntry);
        }
        #endregion

        #region Private & Protected Methods
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        #endregion
    }
}