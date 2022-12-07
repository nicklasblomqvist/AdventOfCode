using System;

namespace AdventOfCode2022.Day6;

public interface IDay6
{
    public int GetStartPositionOfMarker(Stream stream);
}

public class Day6ListImplementation : IDay6
{
    public int GetStartPositionOfMarker(Stream stream)
    {
        var sequence = new List<int>(4);
        var potentialStartPosition = 0;
        var current = 0;
        while (stream.CanRead && current != -1)
        {
            current = stream.ReadByte();
            var matchingIndex = sequence.FindIndex(0, sequence.Count, x => x == current);
            if (matchingIndex != -1)
            {
                sequence.RemoveRange(0, matchingIndex+1);
                potentialStartPosition += matchingIndex+1;
            }
            
            sequence.Add(current);

            if (sequence.Count == 4) { return potentialStartPosition + 4; }
        }

        return potentialStartPosition;
    }

}

