namespace MVVM_Essentials_Lib.Camera
{
    public class CameraControlEventArgs
    {
        public string Photo { get; set; }

        public CameraControlEventArgs(string photo)
        {
            Photo = photo;
        }
    }
}
