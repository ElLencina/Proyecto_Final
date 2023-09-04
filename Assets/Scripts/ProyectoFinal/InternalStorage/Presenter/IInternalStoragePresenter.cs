namespace Storage.Presenter
{
    public interface IInternalStoragePresenter
    {
        void SaveLatitude(float latitude);
        void SaveLongitude(float longitude);
        float GetLatitude();
        float GetLongitude();
        void DeleteLatitudeAndLongitude();
    }

}