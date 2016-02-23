using Windows.Devices.Gpio;

namespace PoshWin10IoTCore
{
    public class Gpio
    {
        public static GpioController GetGpioController()
        {
            return GpioController.GetDefault();
        }
    }
}
