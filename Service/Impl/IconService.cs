using System.Drawing.Imaging;

namespace LittleFancyTool.Service.Impl
{
    class IconService : IIconService
    {
        struct IconDir
        {
            public ushort Reserved;
            public ushort Type;
            public ushort Count;
        }

        struct IconDirEntry
        {
            public byte Width;
            public byte Height;
            public byte ColorCount;
            public byte Reserved;
            public ushort Planes;
            public ushort BitCount;
            public int BytesInRes;
            public int ImageOffset;
        }
        public Icon CreateIconFromBitmap(Bitmap bitmap)
        {
            // 使用内存流来创建图标
            using (MemoryStream iconStream = new MemoryStream())
            {
                // 创建ICO格式的头部信息
                IconDir iconDir = new IconDir();
                iconDir.Reserved = 0;
                iconDir.Type = 1;
                iconDir.Count = 1;

                // 写入ICO头部
                BinaryWriter writer = new BinaryWriter(iconStream);
                writer.Write(iconDir.Reserved);
                writer.Write(iconDir.Type);
                writer.Write(iconDir.Count);

                // 位图数据
                MemoryStream bitmapStream = new MemoryStream();
                bitmap.Save(bitmapStream, ImageFormat.Png);
                byte[] bitmapData = bitmapStream.ToArray();
                // 创建条目
                IconDirEntry entry = new IconDirEntry();
                entry.Width = (byte)bitmap.Width;
                entry.Height = (byte)bitmap.Height;
                entry.ColorCount = 0;
                entry.Reserved = 0;
                entry.Planes = 1;
                entry.BitCount = 32;
                entry.BytesInRes = bitmapData.Length;
                entry.ImageOffset = 22; // 头部大小 + 条目大小
                // 写入条目
                writer.Write(entry.Width);
                writer.Write(entry.Height);
                writer.Write(entry.ColorCount);
                writer.Write(entry.Reserved);
                writer.Write(entry.Planes);
                writer.Write(entry.BitCount);
                writer.Write(entry.BytesInRes);
                writer.Write(entry.ImageOffset);
                // 写入位图数据
                writer.Write(bitmapData);
                // 从内存流创建图标
                iconStream.Position = 0;
                return new Icon(iconStream);
            }
        }
    }
}
