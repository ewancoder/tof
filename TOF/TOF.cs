using System.IO.Ports;

namespace TOF
{
    public class TOF
    {
        public static string GetFirstPort()
        {
            try
            {
                return SerialPort.GetPortNames()[0];
            }
            catch { return ""; }
        }

        private SerialPort sp;
        private bool server = false;
        public bool ServerMode
        {
            get { return server; }
            set
            {
                try
                {
                    server = ServerMode;
                    if (server)
                        sp.Write("s");
                    else
                        sp.Write("c");
                }
                catch { }
            }
        }
        public TOF(string portName = "COM1")
        {
            try
            {
                sp = new SerialPort(portName, 115200);
                sp.Open();
            }
            catch { }
        }

        public string Read()
        {
            try
            {
                if (sp.BytesToRead != 0)
                    return sp.ReadExisting();
                else
                    return "";
            }
            catch { return ""; }
        }
    }
}
