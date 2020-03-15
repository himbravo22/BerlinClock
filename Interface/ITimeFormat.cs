using System;

namespace BerlinClock
{
    public interface ITimeFormat
    {
        //Converts Input String to Time Object
        Time SetInput(String time);

        //Converts Time Object to Given Output Format
        String GetOutput(Time time);
    }
}
