using ARLocation;
using Control.Manage;
using Storage.View;
using UnityEngine;

namespace GPS
{
    public class HouseGPS : MonoBehaviour
    {
        private GameObject house;

        private IInternalStorageView internalStorageView;

        public GameObject ControlObjectManage;
        private ControlObjectManage controlObjectManage;

        // Start is called before the first frame update
        void Start()
        {
            internalStorageView = new InternalStorageView();

            house = GameObject.FindWithTag("house");
            house.transform.position = Vector3.zero;
            GameObject LocationRoot = GameObject.FindWithTag("root");
            house.transform.SetParent(LocationRoot.transform);

            var loc = new Location()
            {
                Latitude = internalStorageView.GetLatitude(),
                Longitude = internalStorageView.GetLongitude(),

                Altitude = 0,
                AltitudeMode = AltitudeMode.Ignore
            };

            var opts = new PlaceAtLocation.PlaceAtOptions()
            {
                HideObjectUntilItIsPlaced = true,
                MaxNumberOfLocationUpdates = 1,
                MovementSmoothing = 0,
                UseMovingAverage = false
            };

            PlaceAtLocation.AddPlaceAtComponent(house, loc, opts);

            internalStorageView.DeleteLatitudeAndLongitude();

            controlObjectManage = ControlObjectManage.GetComponent<ControlObjectManage>();
            controlObjectManage.SetHouse(house);
        }

    }
}