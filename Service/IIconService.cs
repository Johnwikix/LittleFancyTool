using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Service
{
    interface IIconService
    {
        Icon CreateIconFromBitmap(Bitmap bitmap);
    }
}
