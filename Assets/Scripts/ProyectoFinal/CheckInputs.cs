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
            //Si las coordenadas geogr�ficas estan vac�o o es negativo o empieza con punto o empieza con menos y punto o termina con punto, no habilito el bot�n
            //de cargar el objeto 3D y el frag para habilitar el bot�n de crear la casa a trav�s de una imagen es falso
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

            //Si no ingresaron las coordenadas geogr�ficas o los inputs de tama�o de la casa esta vac�o o es negativo o empieza con punto o
            //empieza con menos y punto o termina con punto, no habilito el bot�n de crear la casa a trav�s de la imagen de un plano
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