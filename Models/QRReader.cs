namespace MOS.Models
{
    class QRReader
    {
        #region Fields
        private bool m_isBusy = false;
        #endregion


        #region Properties
        public bool IsBusy
        {
            get => m_isBusy;
        }
        #endregion


        #region Constructors
        public QRReader()
        {
            
        }
        #endregion


        #region Public Methods
        public string TryReadQR()
        {
            m_isBusy = true;
            //Reader Logic here
            return "010415003419461217250630102139485";
        }
        #endregion


        #region Private Methods

        #endregion
    }
}
