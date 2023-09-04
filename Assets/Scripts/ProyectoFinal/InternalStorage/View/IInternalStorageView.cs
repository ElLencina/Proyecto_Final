namespace Storage.View
{
    public interface IInternalStorageView
    {
        void SaveLatitude(float latitude);
        void SaveLongitude(float longitude);
        float GetLatitude();
        float GetLongitude();
        void DeleteLatitudeAndLongitude();
    }
}