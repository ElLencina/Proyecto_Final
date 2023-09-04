using UnityEngine;
using UnityEngine.UI;

namespace CheckCoordinates
{
    public class CheckInputs : MonoBehaviour
    {
        public InputField inputFieldLatitude, inputFieldLongitude, inputFieldHeight, inputFieldWidth;
        public Button buttonLoadingHouse, buttonLoadingPlane;
        private bool inputFieldSizePlane = false;

        // Update is called once per frame
        void Update()
        {
            //Si las coordenadas geográficas estan vacío o es negativo o empieza con punto o empieza con menos y punto o termina con punto, no habilito el botón
            //de cargar el objeto 3D y el frag para habilitar el botón de crear la casa a través de una imagen es falso
            if (inputFieldLatitude.text.Equals("") || inputFieldLongitude.text.Equals("") || inputFieldLatitude.text.Equals("-") || 
                inputFieldLongitude.text.Equals("-") || inputFieldLatitude.text.StartsWith(".") || inputFieldLongitude.text.StartsWith(".") ||
                inputFieldLatitude.text.StartsWith("-.") || inputFieldLongitude.text.StartsWith("-.") || inputFieldLatitude.text.EndsWith(".") || 
                inputFieldLongitude.text.EndsWith(".")
                )
            {
                buttonLoadingHouse.interactable = false;
                inputFieldSizePlane = false;
                //buttonLoadingPlane.interactable = false;
            }
            else
            {
                buttonLoadingHouse.interactable = true;
                inputFieldSizePlane = true;
            }

            //Si no ingresaron las coordenadas geográficas o los inputs de tamaño de la casa esta vacío o es negativo o empieza con punto o
            //empieza con menos y punto o termina con punto, no habilito el botón de crear la casa a través de la imagen de un plano
            if (!inputFieldSizePlane || 
                (
                inputFieldHeight.text.Equals("") || inputFieldHeight.text.Contains("-") || inputFieldHeight.text.StartsWith(".") ||
                inputFieldHeight.text.StartsWith("-.") || inputFieldHeight.text.EndsWith(".")
                )|| 
                (
                inputFieldWidth.text.Equals("")|| inputFieldWidth.text.Contains("-")  || inputFieldWidth.text.StartsWith(".") ||
                inputFieldWidth.text.StartsWith("-.") || inputFieldHeight.text.EndsWith(".") || inputFieldWidth.text.EndsWith(".")
                )   
               )
            {
                buttonLoadingPlane.interactable = false;
            }
            else
            {
                buttonLoadingPlane.interactable = true;
            }
        }
    }
}