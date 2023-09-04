using Storage.Logic;

namespace Storage.Presenter
{
    public class InternalStoragePresenter : IInternalStoragePresenter
    {
        private IInternalStorageLogic internalStorageLogic;

        public InternalStoragePresenter()
        {
            internalStorageLogic = new InternalStorageLogic();
        }

        public void SaveLatitude(float latitude)
        {
            internalStorageLogic.SaveLatitudeInternalStorage(latitude);
        }

        public void SaveLongitude(float longitude)
        {
            internalStorageLogic.SaveLongitudeInternalStorage(longitude);
        }

        public float GetLatitude()
        {
            return internalStorageLogic.GetLatitudeInternalStorage();
        }

        public float GetLongitude()
        {
            return internalStorageLogic.GetLongitudeInternalStorage();
        }

        public void DeleteLatitudeAndLongitude()
        {
            internalStorageLogic.DeleteLatitudeAndLongitudeInternalStorage();
        }


    }
}
