using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ConsoleApplication1
{
    abstract class ImageState
    {
        public virtual void Paint()
        {
            throw new NotImplementedException();
        }
    }

    class NoImageState : ImageState
    {
        UserImage _userImage;

        public NoImageState(UserImage userImage)
        {
            _userImage = userImage;
        }

        public override void Paint()
        {
            //if(_userImage.Icon!=null)
            //    _userImage.h
            //_userImage.Height=800;
            //_userImage.Width = 600;
        }
    }

    class HasImageState : ImageState
    {
        UserImage _userImage;

        public HasImageState(UserImage userImage)
        {
            _userImage = userImage;
        }

    }

    class UserImage
    {
        Icon iconObj;
        ImageState _currentState;
        ImageState _noImageState;
        ImageState _hasImageState;
        Bitmap _bmp;
        Point _point;
        int _height;
        int _width;

        public UserImage()
        {
            _currentState = _noImageState = new NoImageState(this);
            _hasImageState = new HasImageState(this);
        }

        public void SetState(ImageState state)
        {
            _currentState = state;
        }

        public ImageState GetNoImageState()
        {
            return _noImageState;
        }

        public ImageState GetHasImageState()
        {
            return _hasImageState;
        }

        public int Height
        {
            get { return _height; }
            set { _height=value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Icon Icon
        {
            get
            {
                return iconObj;
            }
        }

        public Bitmap Bitmap
        {
            get
            {
                return _bmp;
            }

            set
            {
                _bmp = value;
            }
        }

        public Point Point
        {
            get
            {
                return _point;
            }

            set
            {
                _point = value;
            }
        }
    }

}
