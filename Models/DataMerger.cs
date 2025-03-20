using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFancyTool.Models
{
    public class DataMerger
    {
        private readonly TimeSpan _mergeInterval;
        private MemoryStream _buffer = new MemoryStream();
        private DateTime _lastReceiveTime = DateTime.MinValue;

        public DataMerger(TimeSpan mergeInterval)
        {
            _mergeInterval = mergeInterval;
        }

        public void ProcessData(ReadOnlyMemory<byte> data, Action<ReadOnlyMemory<byte>> onComplete)
        {
            lock (_buffer)
            {
                var now = DateTime.Now;
                if (_lastReceiveTime != DateTime.MinValue &&
                    (now - _lastReceiveTime) > _mergeInterval)
                {
                    // 触发数据处理
                    if (_buffer.Length > 0)
                    {
                        var completeData = _buffer.ToArray();
                        onComplete(completeData.AsMemory());
                        _buffer.Dispose();
                        _buffer = new MemoryStream();
                    }
                }

                _buffer.Write(data.Span);
                _lastReceiveTime = now;
            }
        }

        public void Dispose()
        {
            lock (_buffer)
            {
                _buffer.Dispose();
            }
        }
    }
}
