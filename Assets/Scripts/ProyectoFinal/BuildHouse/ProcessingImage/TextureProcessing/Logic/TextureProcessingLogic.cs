using System;

namespace OpenCVForUnity.Logic
{
    public class TextureProcessingLogic : ITextureProcessingLogic
    {
        public int[,] ArrayIntTexture(string stringImgen, int rows, int cols){
            char[] separators = new char[] { ' ', ',', ';','[',']','\n' };

            string[] subs = stringImgen.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            int [,] array = new int [rows, cols];

            int k = 0;

            for(int i = 0; i<rows; i++){
                for(int j= 0; j<cols; j++){
                    array[i,j] = short.Parse(subs[k]);
                    k++;
                }

            }

            return array; 
        }
    }
}