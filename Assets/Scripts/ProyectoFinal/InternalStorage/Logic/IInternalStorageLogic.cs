namespace Storage.Logic
{
    public interface IInternalStorageLogic
    {
        void SaveLatitudeInternalStorage(float latitude);
        void SaveLongitudeInternalStorage(float longitude);
        float GetLatitudeInternalStorage();
        float GetLongitudeInternalStorage();
        void DeleteLatitudeAndLongitudeInternalStorage();
    }
}