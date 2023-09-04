using UnityEngine;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.Presenter;

namespace OpenCVForUnity.View
{
    public class TextureProcessingView : MonoBehaviour, ITextureProcessingView
    {
         private ITextureProcessingPresenter textureProcessingPresenter;

         // Use this for initialization
         void Start ()
         {
            textureProcessingPresenter = new TextureProcessingPresenter();
         }
     
         private Mat GetImageHSV(Texture2D imgTexture)
         {
            Mat imgMat = new Mat(imgTexture.height, imgTexture.width, CvType.CV_8UC4);

            Utils.texture2DToMat(imgTexture, imgMat);

            Size size = new Size(256, 256);
            Imgproc.resize(imgMat, imgMat, size);

            Imgproc.cvtColor(imgMat, imgMat, Imgproc.COLOR_RGBA2RGB);
            Imgproc.cvtColor(imgMat, imgMat, Imgproc.COLOR_RGB2HSV);

            return imgMat;
         }

         public int[,] GetArrayWalls(Texture2D imgTexture)
         {
            Mat hsvMat = GetImageHSV(imgTexture);
            
            Scalar humbralBajo = new Scalar(108,0,0);
            Scalar humbralAlto =  new Scalar(189,255,75);
            Core.inRange(hsvMat, humbralBajo, humbralAlto, hsvMat);

            Size kernel = new Size(3, 3);
            Imgproc.GaussianBlur(hsvMat, hsvMat, kernel, 1, 0);
        
            Imgproc.Canny(hsvMat, hsvMat, 260, 270);

            return textureProcessingPresenter.ArrayIntTexture(hsvMat.dump(), hsvMat.rows(), hsvMat.cols());
         }

         public int[,] GetArrayWindows(Texture2D imgTexture)
         { 
            Mat hsvMat = GetImageHSV(imgTexture);

            Scalar humbralBajo = new Scalar(68, 39, 168);
            Scalar humbralAlto = new Scalar(179, 255, 255);
            Core.inRange(hsvMat, humbralBajo, humbralAlto, hsvMat);

            Size kernel = new Size(3, 3);
            Imgproc.GaussianBlur(hsvMat, hsvMat, kernel, 1, 0);

            Imgproc.Canny(hsvMat,hsvMat,240 , 250);

            return textureProcessingPresenter.ArrayIntTexture(hsvMat.dump(), hsvMat.rows(), hsvMat.cols());
         }

         public int[,] GetArrayDoor(Texture2D imgTexture)
         {   
            Mat hsvMat = GetImageHSV(imgTexture);

            Scalar humbralBajo = new Scalar(0, 24, 50);
            Scalar humbralAlto = new Scalar(23, 255, 255);
            Core.inRange(hsvMat, humbralBajo, humbralAlto, hsvMat);
            
            Size kernel = new Size(3, 3);
            Imgproc.GaussianBlur(hsvMat, hsvMat, kernel, 1, 0);
            
            Imgproc.Canny(hsvMat, hsvMat, 240, 250);

            return textureProcessingPresenter.ArrayIntTexture(hsvMat.dump(), hsvMat.rows(), hsvMat.cols());
         }
    }
}