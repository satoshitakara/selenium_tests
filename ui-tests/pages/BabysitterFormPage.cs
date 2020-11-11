using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ui_tests.pages
{
    public partial class BabysitterFormPage : BasePage
    {
        private IWebElement _name => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[2]/div/input[1]"));
        private IWebElement _last => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[2]/div/input[2]"));
        private IWebElement _birthDate => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[3]/input"));
        private IWebElement _drivingLicence => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[4]"));
        private IWebElement _doYouStudy => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[5]"));
        private IWebElement _martialStatus => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[6]"));
        private IWebElement _doYouSmoke => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[7]"));
        private IWebElement _doYouDrink => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[8]"));
        private IWebElement _anyCertificates => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[9]/textarea"));
        private IWebElement _describeYourself => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[10]/textarea"));
        private IWebElement _phone => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[11]/input"));
        private IWebElement _email => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[12]/input"));
        private IWebElement _streetAddress => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[13]/input[1]"));
        private IWebElement _streetAddressLine => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[13]/input[2]"));
        private IWebElement _city => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[13]/div/input[1]"));
        private IWebElement _region => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[13]/div/input[2]"));
        private IWebElement _postalZipCode => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[13]/div/input[3]"));
        private IWebElement _country => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[13]/div/select"));
        private IWebElement _highSchool => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[14]"));
        private IWebElement _college => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[15]"));
        private IWebElement _firstNameEmployer => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[16]/div/input[1]"));
        private IWebElement _lastNameEmployer => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[16]/div/input[2]"));
        private IWebElement _employerPhone => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[17]/input"));
        private IWebElement _ageOfChildren => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[18]/input"));
        private IWebElement _submit => _driver.FindElement(By.XPath("/html/body/app-root/body/div/app-babysitter-form/html/body/div/form/div[19]/button"));
    }
    public partial class BabysitterFormPage : BasePage
    {

        public BabysitterFormPage() : base("http://localhost:4200/babysitter")
        {

        }

        public BabysitterFormPage(IWebDriver driver) : base(driver)
        {

        }

        public string Name
        {
            get => _name.GetAttribute("value");
            set => FillField(_name, value);
        }
        public string Last
        {
            get => _last.GetAttribute("value");
            set => FillField(_last, value);
        }
        public DateTime BirthDate
        {
            get => Convert.ToDateTime(_birthDate.GetAttribute("value"));
            set => FillField(_birthDate, value);
        }
        public string AnyCertificates
        {
            get => _anyCertificates.GetAttribute("value");
            set => FillField(_anyCertificates, value);
        }
        public string DescribeYourself
        {
            get => _describeYourself.GetAttribute("value");
            set => FillField(_describeYourself, value);
        }
        public string Phone
        {
            get => _phone.GetAttribute("value");
            set => FillField(_phone, value);
        }
        public string Email
        {
            get => _email.GetAttribute("value");
            set => FillField(_email, value);
        }
        public string StreetAddress
        {
            get => _streetAddress.GetAttribute("value");
            set => FillField(_streetAddress, value);
        }
        public string StreetAddressLine
        {
            get => _streetAddressLine.GetAttribute("value");
            set => FillField(_streetAddressLine, value);
        }
        public string City
        {
            get => _city.GetAttribute("value");
            set => FillField(_city, value);
        }
        public string Region
        {
            get => _region.GetAttribute("value");
            set => FillField(_region, value);
        }
        public string PostalZipCode
        {
            get => _postalZipCode.GetAttribute("value");
            set => FillField(_postalZipCode, value);
        }
        public CountryEnum Country
        {
            get => (CountryEnum)GetSelectionFieldSelected(_country);
            set => FillSelectField(_country, value);
        }

        public string FirstNameEmployer
        {
            get => _firstNameEmployer.GetAttribute("value");
            set => FillField(_firstNameEmployer, value);
        }
        public string LastNameEmployer
        {
            get => _lastNameEmployer.GetAttribute("value");
            set => FillField(_lastNameEmployer, value);
        }
        public string EmployerPhone
        {
            get => _employerPhone.GetAttribute("value");
            set => FillField(_employerPhone, value);
        }
        public string AgeOfChildren
        {
            get => _ageOfChildren.GetAttribute("value");
            set => FillField(_ageOfChildren, value);
        }
        public string MartialStatus
        {
            get => GetRadioFieldSelected(_martialStatus);
            set => FillRadioField(_martialStatus, value);
        }
        public string DrivingLicence
        {
            get => GetRadioFieldSelected(_drivingLicence);
            set => FillRadioField(_drivingLicence, value);
        }
        public string DoYouStudy
        {
            get => GetRadioFieldSelected(_doYouStudy);
            set => FillRadioField(_doYouStudy, value);
        }
        public string DoYouSmoke
        {
            get => GetRadioFieldSelected(_doYouSmoke);
            set => FillRadioField(_doYouSmoke, value);
        }
        public string DoYouDrink
        {
            get => GetRadioFieldSelected(_doYouDrink);
            set => FillRadioField(_doYouDrink, value);
        }
        public string HighSchool
        {
            get => GetRadioFieldSelected(_highSchool);
            set => FillRadioField(_highSchool, value);
        }
        public string College
        {
            get => GetRadioFieldSelected(_college);
            set => FillRadioField(_college, value);
        }

        public void FillFields(string name = "First", string last = "Last",
            DateTime birthDate = default,
            string drivingLicence = "Yes",
            string doYouStudy = "No",
            string martialStatus = "Married",
            string doYouSmoke = "No",
            string doYouDrink = "Every once in a while",
            string anyCertificates = "Certificates",
            string describeYourself = "describe yourself",
            string phone = "1231231",
            string email = "email@email.com",
            string streetAddress = "street address",
            string streetAddressLine = "street line",
            string city = "city",
            string region = "region",
            string postalZipCode = "123123",
            CountryEnum country = CountryEnum.USA,
            string highSchool = "Yes",
            string college = "No",
            string firstNameEmployer = "Employer",
            string lastNameEmployer = "LastName",
            string employerPhone = "2131232",
            string ageOfChildren = "3")
        {
            Name = name;
            Last = last;
            BirthDate = birthDate;
            DrivingLicence = drivingLicence;
            DoYouStudy = doYouStudy;
            MartialStatus = martialStatus;
            DoYouSmoke = doYouSmoke;
            DoYouDrink = doYouDrink;
            AnyCertificates = anyCertificates;
            DescribeYourself = describeYourself;
            Phone = phone;
            Email = email;
            StreetAddress = streetAddress;
            StreetAddressLine = streetAddressLine;
            City = city;
            Region = region;
            PostalZipCode = postalZipCode;
            Country = country;
            HighSchool = highSchool;
            College = college;
            FirstNameEmployer = firstNameEmployer;
            LastNameEmployer = lastNameEmployer;
            EmployerPhone = employerPhone;
            AgeOfChildren = ageOfChildren;


            if (!Name.Equals(name)) throw new Exception();
            if (!Last.Equals(last)) throw new Exception();
            if (!BirthDate.Equals(birthDate)) throw new Exception();
            if (!DrivingLicence.Equals(drivingLicence)) throw new Exception();
            if (!DoYouStudy.Equals(doYouStudy)) throw new Exception();
            if (!MartialStatus.Equals(martialStatus)) throw new Exception();
            if (!DoYouSmoke.Equals(doYouSmoke)) throw new Exception();
            if (!DoYouDrink.Equals(doYouDrink)) throw new Exception();
            if (!AnyCertificates.Equals(anyCertificates)) throw new Exception();
            if (!DescribeYourself.Equals(describeYourself)) throw new Exception();
            if (!Phone.Equals(phone)) throw new Exception();
            if (!Email.Equals(email)) throw new Exception();
            if (!StreetAddress.Equals(streetAddress)) throw new Exception();
            if (!StreetAddressLine.Equals(streetAddressLine)) throw new Exception();
            if (!City.Equals(city)) throw new Exception();
            if (!Region.Equals(region)) throw new Exception();
            if (!PostalZipCode.Equals(postalZipCode)) throw new Exception();
            if (!Country.Equals(country)) throw new Exception();
            if (!HighSchool.Equals(highSchool)) throw new Exception();
            if (!College.Equals(college)) throw new Exception();
            if (!FirstNameEmployer.Equals(firstNameEmployer)) throw new Exception();
            if (!LastNameEmployer.Equals(lastNameEmployer)) throw new Exception();
            if (!EmployerPhone.Equals(employerPhone)) throw new Exception();
            if (!AgeOfChildren.Equals(ageOfChildren)) throw new Exception();
        }
        public void ClickSubmit()
        {
            _submit.Click();
        }
        public List<string> GetFields()
        {
            return _driver.FindElements(By.XPath("//*[@class='item'] | //*[@class='question']"))
                .ToList().Select(e => e.Text).ToList();
        }
    }
    public enum CountryEnum
    {
        Russia = 1,
        Germany = 2,
        France = 3,
        Armenia = 4,
        USA = 5
    }
}
