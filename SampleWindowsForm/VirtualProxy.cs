using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApplication1;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SampleWindowsForm
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
            Paint();
        }

        public override void Paint()
        {
            _userImage.Height = 800;
            _userImage.Width = 600;
            _userImage.Icon = new Icon(@"C:\Users\Raja\Downloads\Loading.ico");
            _userImage.SetState(_userImage.GetHasImageState);
        }
    }

    class HasImageState : ImageState
    {
        UserImage _userImage;

        public HasImageState(UserImage userImage)
        {
            _userImage = userImage;
            Paint();
        }

        public override void Paint()
        {
            Thread tObj = new Thread(() =>
            {
                WebRequest req = WebRequest.Create(_userImage.ImageUrl);
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();
                Image image = Image.FromStream(stream);
                Bitmap bitmap = new Bitmap(image);
                bitmap.SetResolution(72, 72);
                Icon icon = Icon.FromHandle(bitmap.GetHicon());
                _userImage.Icon = icon;
                stream.Close();
                _userImage.Height = _userImage.Icon.Height;
                _userImage.Width = _userImage.Icon.Width;
                _userImage.PaintEventHandler(_userImage.Object,_userImage.PaintEventArgs);
            });
            tObj.Start();
        }
    }

    class UserImage : ImageState
    {
        Icon iconObj;
        ImageState _currentState;
        ImageState _noImageState;
        ImageState _hasImageState;
        PaintEventHandler _eventHandler;
        int _height;
        int _width;
        string _imageUrl;

        public UserImage(string imageUrl)
        {
            _imageUrl = imageUrl;
            _currentState = _noImageState = new NoImageState(this);
            _hasImageState = new HasImageState(this);
        }

        public void SetState(ImageState state)
        {
            _currentState = state;
        }

        public ImageState GetNoImageState
        {
            get
            {
                return _noImageState;
            }
        }

        public ImageState GetHasImageState
        {
            get
            {
                return _hasImageState;
            }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
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
            set
            {
                iconObj = value;
            }
        }

        public string ImageUrl
        {
            get
            {
                return _imageUrl;
            }
        }

        public PaintEventHandler PaintEventHandler
        {
            get
            {
                return _eventHandler;
            }
            set
            {
                _eventHandler = value;
            }
        }

        public object Object
        {
            get;
            set;
        }

        public PaintEventArgs PaintEventArgs
        {
            get;
            set;
        }
    }
}
