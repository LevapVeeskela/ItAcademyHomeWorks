using System;

namespace Common.Constants
{
    public static class CheckInConstants
    {
        public static string Now = DateTime.Now.ToString("M-d-yyyy dddd HH:mm:ss");
        public const string PatternTextWelcomeInfo = "Здравствуйте, это аэропорт Минск-2, национальный аэпорт Республики Беларусь, сейчас {0} по местному времени, меня зовут Ерашевич Диана, я буду проводить вашу регистрацию, вы проходили регистрацию в интернете?";
        public const string TextGetPassportInfo = "Предоставьте, пожалуйста, ваш паспорт";
        public const string TextGetPassportAndTicketInfo = "Предоставьте, пожалуйста, ваш паспорт и билет";
    }
}