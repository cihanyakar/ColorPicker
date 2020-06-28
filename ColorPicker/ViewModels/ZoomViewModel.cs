﻿using ColorPicker.Common;
using ColorPicker.ViewModelContracts;
using System.ComponentModel.Composition;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Media.Imaging;

namespace ColorPicker.ViewModels
{
    [Export(typeof(IZoomViewModel))]
    public class ZoomViewModel : ViewModelBase, IZoomViewModel
    {
        private BitmapSource _zoomArea;
        private double _zoomFactor = 1;
        private double _desiredWidth;
        private double _desiredHeight;
        private double _width;
        private double _height;

        [ImportingConstructor]
        public ZoomViewModel()
        {
        }

        public BitmapSource ZoomArea
        {
            get
            {
                return _zoomArea;
            }
            set
            {
                _zoomArea = value;
                OnPropertyChanged();
            }
        }

        public double ZoomFactor
        {
            get
            {
                return _zoomFactor;
            }
            set
            {
                _zoomFactor = value;
                OnPropertyChanged();
            }
        }

        public double DesiredWidth
        {
            get
            {
                return _desiredWidth;
            }
            set
            {
                _desiredWidth = value;
                OnPropertyChanged();
            }
        }

        public double DesiredHeight
        {
            get
            {
                return _desiredHeight;
            }
            set
            {
                _desiredHeight = value;
                OnPropertyChanged();
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                OnPropertyChanged();
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                OnPropertyChanged();
            }
        }
    }
}
