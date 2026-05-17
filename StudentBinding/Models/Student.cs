using System;
using System.ComponentModel;

namespace StudentBinding.Models;



public class Student : ObservableObject
{
    private string _profilePicture;
    public string ProfilePicture
    {
        get { return _profilePicture; }

        set
        {
            if (_profilePicture != value)
            {
                _profilePicture = value;
                OnPropertyChanged(nameof(ProfilePicture));
            }
        }
    }

    private string _fullName;
    public string FullName
    {
        get => _fullName;
        set
        {
            if (_fullName != value)
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }
    }

    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (_age != value)
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
    }

    private DateTime _birthday;
    public DateTime Birthday
    {
        get => _birthday;
        set
        {
            if (_birthday != value)
            {
                _birthday = value;
                OnPropertyChanged(nameof(Birthday));
            }
        }
    }

    private string _emailAddress;
    public string EmailAddress
    {
        get => _emailAddress;
        set
        {
            if (_emailAddress != value)
            {
                _emailAddress = value;
                OnPropertyChanged(nameof(EmailAddress));
            }
        }
    }

    private string _phoneNumber;
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (_phoneNumber != value)
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
    }
}