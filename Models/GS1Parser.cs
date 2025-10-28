using System.Diagnostics;

namespace MOS.Models
{
    /// <summary>
    /// This class is intended to Parse GS1 QR Code Input into a GS1 DataAsset with the following Informations:
    /// GTIN (Global Trade Item Number), Expiration Date and LOT
    /// </summary>
    class GS1Parser
    {
        #region Fields
        private string m_testInput = "010415003419461217250630102139485";
        private string m_input;
        #endregion


        #region Properties

        #endregion


        #region Constructors
        public GS1Parser()
        {
            m_input = m_testInput;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// By passing the complete Data String of a GS1 QRCode into this Method, it returns a GS1_DataAsset as wrapper object for the input given.
        /// </summary>
        /// <param name="_input"></param>
        /// <returns></returns>
        public GS1_DataAsset ParseInputToGS1(string _input)
        {
            if (m_input == null)
                return null;

            m_input = _input;
            var output = new GS1_DataAsset(ExtractGTIN(), ExtractExpDate(), ExtractLOT());
            m_input = "";
            return output;
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Extracts the Global Trade Item Number and returns it as string.
        /// </summary>
        /// <returns></returns>
        private string ExtractGTIN()
        {
            string output = "";
            for (int i = 2; i < 16; i++)
            {
                var tmp = m_input[i];
                output += tmp;
            }
            return output;
        }

        /// <summary>
        /// Extracts the Expiration Date from the given Input and returns it as DateTime.
        /// </summary>
        /// <returns></returns>
        private DateTime ExtractExpDate()
        {
            string output = "";
            for (int i = 18; i < 24; i++)
            {
                var tmp = m_input[i];
                output += tmp;
            }
            Debug.Write(output);
            DateTime date;
            DateTime.TryParseExact(output, "yyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date);
            return date;
        }

        /// <summary>
        /// Extracts the Batch Number (max 20 digits) from the given Input and returns it as string.
        /// </summary>
        /// <returns></returns>
        private string ExtractLOT()
        {
            string output = "";
            for (int i = 26; i < 46; i++)
            {
                try
                {
                    if (m_input[i] >= 0)
                    {
                        var tmp = m_input[i];
                        output += tmp;
                    }
                }
                catch (Exception e)
                {
                    break;
                }
            }
            return output;
        }
        #endregion 

    }
}
