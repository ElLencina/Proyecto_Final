using Storage.View;
using System.Globalization;
using TriLibCore;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LoadingObject
{
    public class LoadingHouse : MonoBehaviour
    {

        private GameObject loadedGameObject;
        public Button loadModelButton;
        public Button createHouseButton;
        public InputField inputFieldLatitude, inputFieldLongitude;
        public Text progressText;
        private IInternalStorageView internalStorageView;

        // Start is called before the first frame update
        void Start()
        {
            internalStorageView = new InternalStorageView();
        }

        private void MoveToScene()
        {
            float latitude = float.Parse(inputFieldLatitude.text, CultureInfo.InvariantCulture.NumberFormat);
            float longitude = float.Parse(inputFieldLongitude.text, CultureInfo.InvariantCulture.NumberFormat);

            loadedGameObject.transform.position = new Vector3(0, 100000f, 0f);
            loadedGameObject.transform.localScale = new Vector3(0.002865314f, 0.002865314f, 0.002865314f);
            loadedGameObject.tag = "house";
            DontDestroyOnLoad(loadedGameObject);
            internalStorageView.SaveLatitude(latitude);
            internalStorageView.SaveLongitude(longitude);

            SceneManager.LoadScene(1);
        }

        public void LoadModel()
        {
            var assetLoaderOptions = AssetLoader.CreateDefaultLoaderOptions();
            var assetLoaderFilePicker = AssetLoaderFilePicker.Create();
            assetLoaderFilePicker.LoadModelFromFilePickerAsync("Selecciona el modelo de la casa", OnLoad, OnMaterialsLoad, OnProgress, OnBeginLoad, OnError, null, assetLoaderOptions);
        }

        private void OnBeginLoad(bool filesSelected)
        {
            loadModelButton.interactable = !filesSelected;
            createHouseButton.interactable = !filesSelected;
        }

        private void OnError(IContextualizedError obj)
        {

        }

        private void OnProgress(AssetLoaderContext assetLoaderContext, float progress)
        {
            progressText.text = $" Progreso: {progress:P}";
        }

        private void OnMaterialsLoad(AssetLoaderContext assetLoaderContext)
        {
            if (assetLoaderContext.RootGameObject != null)
            {
                MoveToScene();
            }
            else
            {
                progressText.text = "Modelo no puede ser cargado";
            }

            loadModelButton.interactable = true;
            createHouseButton.interactable = true;
        }

        private void OnLoad(AssetLoaderContext assetLoaderContext)
        {
            if (loadedGameObject != null)
            {
                Destroy(loadedGameObject);
            }
            loadedGameObject = assetLoaderContext.RootGameObject;
        }
    }
}