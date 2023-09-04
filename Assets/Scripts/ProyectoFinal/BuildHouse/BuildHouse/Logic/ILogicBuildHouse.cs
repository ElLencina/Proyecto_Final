using System.Collections.Generic;

namespace CreateHouse.Logic
{
    public interface ILogicBuildHouse
    {
        List<int> TraverseRow(int[,] arrayHouse, int row);
        List<int> TraverseCol(int[,] arrayHouse, int col);
    }
}