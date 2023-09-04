using OpenCVForUnity.Logic;

namespace OpenCVForUnity.Presenter
{
    public class TextureProcessingPresenter : ITextureProcessingPresenter
    {
        private ITextureProcessingLogic textureProcessingLogic;

        public TextureProcessingPresenter(){
            textureProcessingLogic = new TextureProcessingLogic();
        }

        public int[,] ArrayIntTexture(string stringImgen, int rows, int cols){
              return textureProcessingLogic.ArrayIntTexture(stringImgen, rows, cols);
        }
    }
}