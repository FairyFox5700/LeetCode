public class Solution
{
    public IList<string> RemoveComments(string[] source)
    {
        var sb = new StringBuilder();
        var result = new List<string>();
        bool blockComment = false; // Corrected the spelling

        foreach (var line in source)
        {
            if (!blockComment)
                sb = new StringBuilder();
            int i = 0;

            while (i < line.Length)
            {
                if (!blockComment && i + 1 < line.Length && line[i] == '/' && line[i + 1] == '/')
                {
                    break; // Skip the rest of the line since it's a line comment
                }
                else if (blockComment && i + 1 < line.Length && line[i] == '*' && line[i + 1] == '/')
                {
                    blockComment = false;
                    i += 2; // Skip past the end of the block comment
                    continue; // Continue to process the rest of the line
                }
                else if (!blockComment && i + 1 < line.Length && line[i] == '/' && line[i + 1] == '*')
                {
                    blockComment = true;
                    i += 2; // Skip past the start of the block comment
                    continue; // Continue to check the rest of the line
                }
                else if (!blockComment)
                {
                    sb.Append(line[i]); // Append non-comment characters
                }

                i++;
            }
            if (sb.Length > 0 && !blockComment) // Check if there's any code to add
            {
                result.Add(sb.ToString());
            }
        }

        return result;
    }
}
