using System;
using System.Linq;

public static class TelemetryBuffer {
    public static byte[] ToBuffer(long reading) {
        IEnumerable<byte> bytes;
        switch (reading) {
            case < Int32.MinValue:
                bytes = BitConverter.GetBytes((long)reading).Prepend((byte)(256 - 8));
                break;
            case < Int16.MinValue:
                bytes = BitConverter.GetBytes((int)reading).Prepend((byte)(256 - 4));
                break;
            case < UInt16.MinValue:
                bytes = BitConverter.GetBytes((short)reading).Prepend((byte)(256 - 2));
                break;
            case <= UInt16.MaxValue:
                bytes = BitConverter.GetBytes((ushort)reading).Prepend((byte)2);
                break;
            case <= Int32.MaxValue:
                bytes = BitConverter.GetBytes((int)reading).Prepend((byte)(256 - 4));
                break;
            case <= UInt32.MaxValue:
                bytes = BitConverter.GetBytes((uint)reading).Prepend((byte)4);
                break;
            default:
                bytes = BitConverter.GetBytes((long)reading).Prepend((byte)(256 - 8));
                break;
        }
    
        return bytes.Concat(new byte[9 - bytes.Count()]).ToArray();
    }
    
    public static long FromBuffer(byte[] buffer) {
        switch (buffer[0]) {
            case 256 - 8:
            case 4:
            case 2:
                return BitConverter.ToInt64(buffer, 1);
            case 256 - 4:
                return BitConverter.ToInt32(buffer, 1);
            case 256 - 2:
                return BitConverter.ToInt16(buffer, 1);
            default:
                return 0;
        }
    }
}