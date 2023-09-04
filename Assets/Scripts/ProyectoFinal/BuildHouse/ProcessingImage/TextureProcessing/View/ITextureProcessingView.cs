using UnityEngine;

namespace OpenCVForUnity.View
{
    public interface ITextureProcessingView
    {
        int[,] GetArrayWalls(Texture2D imgTexture2);
        int[,] GetArrayWindows(Texture2D imgTexture);
        int[,] GetArrayDoor(Texture2D imgTexture);
    }
}