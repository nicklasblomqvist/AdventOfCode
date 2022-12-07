using System;

namespace AdventOfCode2022.Day6;

public interface IDay6
{
    public int GetStartPositionAfterUniqueSequence(Stream stream, int sequenceSize);
}

public class Day6ListImplementation : IDay6
{
    public int GetStartPositionAfterUniqueSequence(Stream stream, int sequenceSize)
    {
        var sequence = new List<int>(sequenceSize);
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

            if (sequence.Count == sequenceSize) { return potentialStartPosition + sequenceSize; }
        }

        return potentialStartPosition;
    }

}

