public class Solutions
{
    public int ReverseBits(int n)
    {
        uint num = (uint)n;
        uint result = 0;
        for(int i=0; i < 32; i++)
        {
            result = (result << 1) | (num & 1);
            num >>= 1;
        }
        return (int)result;
    }
}