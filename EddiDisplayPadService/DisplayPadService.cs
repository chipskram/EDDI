using DisplayPad.SDK;
using System;

namespace EddiDisplayPadService
{
    public class DisplayPadService
    {
        private DisplayPadHelper helper;

        public DisplayPadService()
        {
            helper = new DisplayPadHelper();
            //Event will fire when the device is connected or disconnected
            DisplayPadHelper.DisplayPadPlugCallBack += DisplayPadHelper_DisplayPadPlugCallBack;

            //Event will fire when any key is pressed on the device
            DisplayPadHelper.DisplayPadKeyCallBack += DisplayPadHelper_DisplayPadKeyCallBack;

            //Event will fire when updating the firmware and uploading the images
            DisplayPadHelper.DisplayPadProgressCallBack += DisplayPadHelper_DisplayPadProgressCallBack;
        }

        public void SetButtonIcon(int id, string path, int index)
        {
            helper.UploadImage( id, path, index );
        }

        void DisplayPadHelper_DisplayPadPlugCallBack ( int Status, int DeviceId )
        {
            Console.WriteLine( "Device status: " + Status + " for Device Id: " + DeviceId );

            bool PlugSatus = helper.DisplayPadIsDevicePlug(DeviceId);
        }

        void DisplayPadHelper_DisplayPadKeyCallBack ( int KeyMatrix, int iPressed, int DeviceID )
        {
            Console.WriteLine( "Key status: " + iPressed + " for Device Id: " + DeviceID );
        }

        void DisplayPadHelper_DisplayPadProgressCallBack ( int Percentage )
        {
            Console.WriteLine( "Device firmware update Progress status: " + Percentage );
        }
    }
}
