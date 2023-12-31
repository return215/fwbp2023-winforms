﻿using DirectShowLib;

namespace WinForms_02
{
    /// <summary>
    /// Enumerates the cameras with the same order as OpenCv does.
    /// With OpenCv you cannot connect to a camera by name, you have to use an index.
    /// The index in OpenCv is based on the connection order to the computer. Neither WMI gives you that information,
    /// so I had to reference DirectShowLib which, luckly, does the same as OpenCv. (As far as I know!)
    /// 
    /// source: https://github.com/FrancescoBonizzi/WebcamControl-WPF-With-OpenCV/blob/master/WebcamWithOpenCV/WebcamWithOpenCV/CameraDevicesEnumerator.cs
    /// </summary>
    public static class CameraDevicesEnumerator
    {
        public static List<CameraDevice> GetAllConnectedCameras()
        {
            var cameras = new List<CameraDevice>();
            var videoInputDevices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            int openCvId = 0;
            return videoInputDevices.Select(v => new CameraDevice()
            {
                DeviceId = v.DevicePath,
                Name = v.Name,
                OpenCvId = openCvId++
            }).ToList();
        }
    }
}
