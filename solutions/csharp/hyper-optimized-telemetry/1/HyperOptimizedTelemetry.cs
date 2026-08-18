public static class TelemetryBuffer {
    public static byte[] ToBuffer(long reading) {
        byte firstByte;
        byte[] payload = BitConverter.GetBytes(reading);
        byte size;
        if (reading >= 0){
            if (reading >= 65536) {
                if (reading >= 2147483648){
                    if (reading >= 4294967296) {firstByte = 256 - 8;}
                    else {firstByte = 4;}
                } else {firstByte = 256 - 4;}
            } else {firstByte = 2;}
        } else {
            if (reading <= -32769) {
                if (reading <= -2147483649){firstByte = 256 - 8;}
                else {firstByte = 256 - 4;}
            } else {firstByte = 256 - 2;}
        }
        size = firstByte switch {
                254 => 2,
                252 => 4,
                248 => 8,
                _ => 0
        };

        if (size > 0) {
            byte i = 0;
            foreach (byte b in payload){
                i++;
                if (i > size){
                    payload[i - 1] = 0;
                }
            }
        }
            
        return [firstByte, ..payload];
    }

    public static long FromBuffer(byte[] buffer) {
        if (buffer[0] <= 8 || buffer[0] == 256 - 8) {return BitConverter.ToInt64(buffer, 1);}
        else if (buffer[0] == 256 - 4) {return BitConverter.ToInt32(buffer, 1);}
        else if (buffer[0] == 256 - 2) {return BitConverter.ToInt16(buffer, 1);}
        else {return 0;}
    }
}
