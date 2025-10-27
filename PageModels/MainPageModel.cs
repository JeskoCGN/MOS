using MOS.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MOS.PageModels
{
    public class MainPageModel : INotifyPropertyChanged
    {
        #region Fields
        private ProductManager m_productManager;
        public Label Testtext;
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        public DelegateCommand ButtonClick_OpenProductManager { get; set; }


        public MainPageModel()
        {
            OnInitialize();
        }

        private void OnInitialize()
        {
            m_productManager = new ProductManager();

            ButtonClick_OpenProductManager = new DelegateCommand(
                _ => OnButton_Clicked(),
                _ => true
                );
        }

        #region Private Methods
        public void OnButton_Clicked()
        {
        }
        #endregion
    }
}