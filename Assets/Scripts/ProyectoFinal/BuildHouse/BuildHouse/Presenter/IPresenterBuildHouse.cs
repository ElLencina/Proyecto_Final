using System.Collections.Generic;
namespace CreateHouse.Presenter
{
    public interface IPresenterBuildHouse
    {
        List<int> TraverseRow(int[,] arrayHouse, int row);
        List<int> TraverseCol(int[,] arrayHouse, int col);
    }
}