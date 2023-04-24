using WhatsAppMAUI.ViewModels;

namespace WhatsAppMAUI.ViewModels
{
    public class CameraViewModel : BaseViewModel
    {
      

        public Command TakePhotoCommand { get; private set; }
        public CameraViewModel()
        {
            Title = "camera.png";
            
            //TakePhotoCommand = new Command(async () => await PickIamge());
        }

       
        async Task PickIamge()
        {
            FileResult photo = await MediaPicker.PickPhotoAsync();
            if (photo == null)
            {
               
                return;
            }
            // save the file into local storage
            var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            {
                using (var newStream = File.OpenWrite(newFile))
                {
                    await stream.CopyToAsync(newStream);
                    ImageSelected = ImageSource.FromFile(newFile);


                }
            }


        }


        private ImageSource _imageSelected;
        public ImageSource ImageSelected
        {
            get { return _imageSelected; }
            set { SetProperty(ref _imageSelected, value); }
        }
    }
}
