using Windows.Devices.Gpio;

namespace Win10IoTCore
{
    public class Gpio
    {
        public static GpioController GetGpioController()
        {
            return GpioController.GetDefault();
        }
    }
}
