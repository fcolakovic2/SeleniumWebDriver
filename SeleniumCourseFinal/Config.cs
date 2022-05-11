namespace SeleniumCourseFinal
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "http://testing.todorvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "example@example.com";
                public static string Username = "Username";
                public static string Password = "password123!";
            }

            public static class Invalid
            {
                public static class Email
                {
                    public static string NoUser = "@example.com";
                    public static string NoAt = "exampleexample.com";
                    public static string NoDomain = "example@";
                    public static string NoExtension = "example@example";
                }

                public static class Username
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }

                public static class Password
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }
            }
        }

        public static class MenuElements
        {
            public static string Introduction = "Introduction";
            public static string Selectors = "Selectors";
            public static string SpecialElements = "Special Elements";
            public static string TestCases = "Test Cases";
            public static string TestScenarios = "Test Scenarios";
            public static string About = "About";
        }

        public static class TestMessages
        {

        }

        public static class AlertsTexts
        {
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
            public static string SuccessfulLogin = "Succesful login!";
            public static string IdOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordOutOfRange = "Password should not be empty / length be between 7 to 12";
            public static string InvalidUsername = "Username must have alphabet characters only";
            public static string InvalidAddress = "User address must have alphanumeric characters only";
            public static string InvalidCountry = "Select your country from the list";
            public static string InvalidZIP = "ZIP code must have numeric characters only";
            public static string InvalidEmail = "Select your country from the list";
            public static string InvalidGender = "You must choose your gender";
        }
    }

}

