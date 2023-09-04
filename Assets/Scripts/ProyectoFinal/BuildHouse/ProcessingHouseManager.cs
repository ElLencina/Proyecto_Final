using HouseFactory;
using CreateHouse.View;
using OpenCVForUnity.View;
using Storage.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using LengthHouse;
using GeneratorMatrix;

namespace ProcessingHouseManager
{
    public class ProcessingHouseManager : MonoBehaviour
    {
        private Texture2D texture;

        public GameObject TextureProcessingView;
        private ITextureProcessingView textureProcessing;

        public GameObject ViewBuildHouse;
        private IViewBuildHouse viewBuildHouse;

        private int[,] array1, array2, array3, array4, array5, array6, array7, array8, array9;

        public GameObject house;

        public InputField inputFieldLatitude, inputFieldLongitude, inputFieldHeight, inputFieldWidth;
        private IInternalStorageView internalStorageView;

        public Text informationText;

        private IGenerationMatrix generationMatrix;
        private ISizeHouse sizeHouse;

        // Start is called before the first frame update
        void Start()
        {
            informationText.text = "";
            internalStorageView = new InternalStorageView();
            generationMatrix = new GenerationMatrix();
            sizeHouse = new SizeHouse();
        }

        private void MoveToScene()
        {
            float latitude = float.Parse(inputFieldLatitude.text, CultureInfo.InvariantCulture.NumberFormat);
            float longitude = float.Parse(inputFieldLongitude.text, CultureInfo.InvariantCulture.NumberFormat);

            house.tag = "house";
            //Para que no aparezca enfrente de la UI
            house.transform.position = new Vector3(0, 100000f, 0f);
            DontDestroyOnLoad(house);
            internalStorageView.SaveLatitude(latitude);
            internalStorageView.SaveLongitude(longitude);

            SceneManager.LoadScene(1);
        }

        public void TaskOnClick()
        {
            textureProcessing = TextureProcessingView.GetComponent<ITextureProcessingView>();
            try
            {
                NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
                {

                    int maxSize = 256;
                    texture = NativeGallery.LoadImageAtPath(path, maxSize, false);

                    if (texture == null)
                    {
                        informationText.text = "No se puede cargar la imagen";
                        return;
                    }
                    else
                    {
                        //inputFieldHeight, inputFieldWidth
                        float height = float.Parse(inputFieldHeight.text, CultureInfo.InvariantCulture.NumberFormat);
                        float width = float.Parse(inputFieldWidth.text, CultureInfo.InvariantCulture.NumberFormat);

                        array1 = textureProcessing.GetArrayWalls(texture);
                        array2 = textureProcessing.GetArrayDoor(texture);
                        array3 = textureProcessing.GetArrayWindows(texture);
                        
                        //Matriz de la casa con una sola pared
                        //paredes
                        array4 = generationMatrix.GetMatrixRow(array1);
                        array5 = generationMatrix.GetMatrixCol(array1);
                        ////puertas
                        array6 = generationMatrix.GetMatrixRow(array2);
                        array7 = generationMatrix.GetMatrixCol(array2);
                        ////ventanas
                        array8 = generationMatrix.GetMatrixRow(array3);
                        array9 = generationMatrix.GetMatrixCol(array3);

                        viewBuildHouse = ViewBuildHouse.GetComponent<IViewBuildHouse>();
                        viewBuildHouse.BuildRow(array4, "Wall", house);
                        viewBuildHouse.BuildCol(array5, "Wall", house);
                        viewBuildHouse.BuildRow(array6, "Door", house);
                        viewBuildHouse.BuildCol(array7, "Door", house);
                        viewBuildHouse.BuildRow(array8, "Window", house);
                        viewBuildHouse.BuildCol(array9, "Window", house);
                
                        int sizeRowWall = sizeHouse.GetSizeMatrixRow(array4);
                        int sizeColWall = sizeHouse.GetSizeMatrixCol(array5);

                        int sizeRowDoor = sizeHouse.GetSizeMatrixRow(array6);
                        int sizeColDoor = sizeHouse.GetSizeMatrixCol(array7);

                        int sizeRowWindows = sizeHouse.GetSizeMatrixRow(array8);
                        int sizeColWindows = sizeHouse.GetSizeMatrixCol(array9);

                        int maxRow = Math.Max(Math.Max(sizeRowWall, sizeRowDoor), sizeRowWindows);
                        int maxCol = Math.Max(Math.Max(sizeColWall, sizeColDoor), sizeColWindows);

                        //Redondeo a dos decimales
                        width = Mathf.Round(width * 100) / 100;
                        height = Mathf.Round(height * 100) / 100;

                        width = (float)maxRow / width;
                        height = (float)maxCol / height;

                        float heigthHouse = (float)1 / height;
                        float widthHouse = (float)1 / width;

                        house.transform.localScale = new Vector3(widthHouse, 1, heigthHouse);

                        MoveToScene();
                    }
                    return;
                });

            }
            catch (ArgumentException e)
            {
                informationText.text = "Operacion cancelada";
            }

        }
    }
}