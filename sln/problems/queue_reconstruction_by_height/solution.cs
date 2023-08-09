public class Solution {
          public int[][] ReconstructQueue(int[][] people)
        {
            var list = people.OrderByDescending(p => p[0]).ThenBy(p => p[1]);
            var result = new List<int[]>();
            PrintMatrix(list.ToArray());
            foreach (var arr in list)
            {
                result.Insert(arr[1], arr);
            }
            return result.ToArray();
        }
    

    public static void PrintMatrix(int[][] matrix)
{
    for (int row = 0; row < matrix.Length; row++)
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            Console.Write(matrix[row][col] + " ");
        }
        Console.WriteLine();
    }
}
}