using Storage.Presenter;

namespace Storage.View
{
    public class InternalStorageView : IInternalStorageView
    {
        private IInternalStoragePresenter internalStoragePresenter;

        public InternalStorageView()
        {
            internalStoragePresenter = new InternalStoragePresenter();
        }


        public void SaveLatitude(float latitude)
        {
            internalStoragePresenter.SaveLatitude(latitude);
        }

        public void SaveLongitude(float longitude)
        {
            internalStoragePresenter.SaveLongitude(longitude);
        }

        public float GetLatitude()
        {
            return internalStoragePresenter.GetLatitude();
        }

        public float GetLongitude()
        {
            return internalStoragePresenter.GetLongitude();
        }

        public void DeleteLatitudeAndLongitude()
        {
            internalStoragePresenter.DeleteLatitudeAndLongitude();
        }

        
    }
}