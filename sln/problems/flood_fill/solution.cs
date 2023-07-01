public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        var intialColor = image[sr][sc];
  
        // base case ( no coloring if it is already set)
        if(intialColor == color)
        {
            return image;
        }
        SetColor(image, sr, sc, color,intialColor);
        return image;
    }

    public void SetColor(int[][] image, int sr, int sc, int color, int intialColor)
    {
        var rows = image.Length;
        var cols = image[0].Length;
        
        if( rows <= sr || cols <= sc || sc < 0 || sr < 0 )
        {
            // out of boundaries
            return;
        }
        var currentColor = image[sr][sc];
        if( currentColor != intialColor)
        { 
            return;

        }
            // set a new color
        image[sr][sc] = color;
        SetColor(image, sr+1, sc, color,intialColor);
        SetColor(image, sr-1, sc,color,intialColor);
        SetColor(image, sr, sc-1, color,intialColor);
        SetColor(image, sr, sc+1, color,intialColor);
        
    }
}