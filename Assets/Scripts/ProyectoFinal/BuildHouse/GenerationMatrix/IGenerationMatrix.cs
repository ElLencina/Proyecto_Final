namespace GeneratorMatrix
{
    public interface IGenerationMatrix
    {
        int[,] GetMatrixRow(int[,] matrix);
        int[,] GetMatrixCol(int[,] matrix);
    }
}

