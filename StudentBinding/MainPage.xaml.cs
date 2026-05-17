using StudentBinding.Models;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        Student StudentNumber0;
        Student StudentNumber1;
        Student StudentNumber2;

        private Student _displayedStudent;
        public Student DisplayedStudent
        {
            get { return _displayedStudent; }
            set
            {
                _displayedStudent = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();

            StudentNumber0 = new Student();
            StudentNumber1 = new Student();
            StudentNumber2 = new Student();

            StudentNumber0.ProfilePicture = "dotnet_bot.png";
            StudentNumber0.FullName = "ישראל ישראלי";
            StudentNumber0.Birthday = new DateTime(2000, 1, 1);
            StudentNumber0.Age = 26;
            StudentNumber0.EmailAddress = "joe@gmail.com";
            StudentNumber0.PhoneNumber = "050-1234567";

            StudentNumber1.ProfilePicture = "daniel.png";
            StudentNumber1.FullName = "daniel";
            StudentNumber1.Birthday = new DateTime(2006, 7, 9);
            StudentNumber1.Age = 20;
            StudentNumber1.EmailAddress = "daniel@Gmail.com";
            StudentNumber1.PhoneNumber = "123-456-7890";

            StudentNumber2.ProfilePicture = "noa.png";
            StudentNumber2.FullName = "noa";
            StudentNumber2.Birthday = new DateTime(2004, 3, 15); 
            StudentNumber2.Age = 22;
            StudentNumber2.EmailAddress = "noa@Gmail.com";
            StudentNumber2.PhoneNumber = "098-765-4321";

            DisplayedStudent = StudentNumber0;

            this.BindingContext = this;
        }

        private void OnClickedChangeButton(object sender, EventArgs e)
        {
            if (DisplayedStudent == StudentNumber0) { DisplayedStudent = StudentNumber1; }

            if (DisplayedStudent == StudentNumber1) { DisplayedStudent = StudentNumber2; }

            if (DisplayedStudent == StudentNumber2) { DisplayedStudent = StudentNumber0; }
        }
    }
}
