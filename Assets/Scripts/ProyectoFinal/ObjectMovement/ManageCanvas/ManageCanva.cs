using UnityEngine;
using UnityEngine.UI;

namespace SwapCanva
{
    public class ManageCanva : MonoBehaviour
    {
        private const string TEXTMOVE = "Cambiar a Movimiento";
        private const string TEXTROTATE = "Cambiar a Rotación";

        public GameObject canvasMove;
        public GameObject canvasRotate;
        public Button btnViewAction;
        private bool activeCanvasMove;

        // Start is called before the first frame update
        void Start()
        {
            activeCanvasMove = false;
        }

        public void VisibleCanva()
        {
            if (!activeCanvasMove)
                btnViewAction.GetComponentInChildren<Text>().text = TEXTMOVE;
            else
                btnViewAction.GetComponentInChildren<Text>().text = TEXTROTATE;

            canvasRotate.SetActive(!activeCanvasMove);
            canvasMove.SetActive(activeCanvasMove);
            activeCanvasMove = !activeCanvasMove;
        }

    }
}