using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIPAddrTool
{
    public class Settings
    {
        private string _proxy_address;
        private string _port_number;

        public string proxy_address
        {
            get { return _proxy_address; }
            set { _proxy_address = value; }
        }

        public string port_number
        {
            get { return _port_number; }
            set { _port_number = value; }
        }

        //コンストラクタ
        public Settings()
        {
            _proxy_address = "";
            _port_number = "";
        }

    }
}
