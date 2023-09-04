using CreateHouse.Logic;
using System.Collections.Generic;

namespace CreateHouse.Presenter
{
    public class PresenterBuildHouse : IPresenterBuildHouse
    {
        private ILogicBuildHouse logicBuildHouse;

        public PresenterBuildHouse()
        {
            logicBuildHouse = new LogicBuildHouse();
        }

        public List<int> TraverseRow(int[,] arrayHouse, int row)
        {
            return logicBuildHouse.TraverseRow(arrayHouse, row);
        }

        public List<int> TraverseCol(int[,] arrayHouse, int col)
        {
            return logicBuildHouse.TraverseCol(arrayHouse, col);
        }
    }
}