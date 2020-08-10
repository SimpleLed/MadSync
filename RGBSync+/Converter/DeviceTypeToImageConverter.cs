﻿using RGB.NET.Core;
using RGBSyncPlus.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace RGBSyncPlus.Converter
{
    public class DeviceTypeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var type = (RGBDeviceType)value;
            switch (type)
            {
                case RGBDeviceType.DRAM:
                    return new BitmapImage(new Uri("pack://application:,,,/RGBSync+;component/Resources/DevImg/DRAM.png", UriKind.Absolute));
                default:
                    return new BitmapImage(new Uri("pack://application:,,,/RGBSync+;component/Resources/DevImg/Unknown.png", UriKind.Absolute));
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
