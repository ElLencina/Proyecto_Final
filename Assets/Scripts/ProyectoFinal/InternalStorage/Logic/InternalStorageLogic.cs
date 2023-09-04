using UnityEngine;

namespace Storage.Logic
{
    public class InternalStorageLogic : IInternalStorageLogic
    {
        private const string KEYLATITUDE = "latitude";
        private const string KEYLONGITUDE = "longitude";

        public void SaveLatitudeInternalStorage(float latitude)
        {
            PlayerPrefs.SetFloat(KEYLATITUDE, latitude);
        }

        public void SaveLongitudeInternalStorage(float longitude)
        {
            PlayerPrefs.SetFloat(KEYLONGITUDE, longitude);
        }

        public float GetLatitudeInternalStorage()
        {
            if (PlayerPrefs.HasKey(KEYLATITUDE))
                return PlayerPrefs.GetFloat(KEYLATITUDE);
            else
                return 0;
        }

        public float GetLongitudeInternalStorage()
        {
            if (PlayerPrefs.HasKey(KEYLATITUDE))
                return PlayerPrefs.GetFloat(KEYLONGITUDE);
            else
                return 0;
        }

        public void DeleteLatitudeAndLongitudeInternalStorage()
        {
            PlayerPrefs.DeleteAll();
        }

    }
}