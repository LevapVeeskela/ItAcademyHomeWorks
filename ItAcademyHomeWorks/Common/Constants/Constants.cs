using System.IO;

namespace Common.Constants
{
    public static class Constants
    {
        public static class ConfigurationPerson
        {
            public const string TextStageConfigurationPersonInfo = "Этап создания персонажа";
            public const string TextEnterInitialInfo = "Введите Ф.И.О. персонажа";
            public const string PatternTextInitialsAndPassportInfo = "Паспорт, {0}";
            public const string TextConfirmationHaveBaggageInfo = "Имете ли вы багаж?";
            public const string TextWeightBaggageInfo = "Введите вес багажа, максимальный вес 40кг";
            public const string TextConfirmationHaveCarryonInfo = "Имеется ли ручная кладь?";
            public const string TextEnterCountryDestinationInfo = "Введите название страны куда вы хотите политеть";
            public const string TextConfirmationHaveTicketsInfo = "Имеете ли вы заранее распечатанные билеты?";
            public const string TextConfirmationHaveProhibitedItemsInfo = "Имеет ли персонаж запрещённые предметы?";
            public const string TextConfirmationHaveVisaInfo = "Есть ли у вас виза данной страны?";
        }

        public static class CheckIn
        {
            public const string TextStageCheckInInfo = "Этап регистрации";
            public const int ValueLimitWeightBaggage = 40;
            public const string FormatDate = "M-d-yyyy dddd HH:mm:ss";
            public const string PatternTextWelcomeInfo = "Здравствуйте, это аэропорт Минск-2, национальный аэпорт Республики Беларусь, сейчас {0} по местному времени, меня зовут Ерашевич Диана, я буду проводить вашу регистрацию на полёт в {1}, вы проходили регистрацию в интернете?";
            public const string TextGetPassportInfo = "Предоставьте, пожалуйста, ваш паспорт";
            public const string TextGetPassportAndTicketInfo = "Предоставьте, пожалуйста, ваш паспорт и билет";
            public const string TextDutyBaggageInfo = "Вы должны оплатить пошлину за богаж, так как ваш вес богажа превышает допустимый";
        }

        public static class SecurityCheck
        {
            public const string TextStageSecurityCheckInfo = "Этап проверки личных вещей и ручной клади";
            public const string TextCheckCarryonInfo = "Проверька ручной клади на наличие запрещённых предметов.";
            public const string TextCheckPersonInfo = "Проверька ренгеном на наличие у вас посторонних предметов.";
        } 

        public static class PassportControl
        {
            public const string TextStageSPassportControlInfo = "Этап проверки личности и визы";
            public const string TextImitationCheckPassportInBdInfo = "Иммитируется проверка в БД паспартов.";
            public const string TextConfirmationVisaInfo = "Нужна ли виза в {0}";
        }
        
        public static class RegistrationBase
        {
            public const string PatternTextSuccessFlyInfo = "{0} успешно прошёл все тягости регистрации и улетел в {1}, попивать вискарёк в бассейне!";
            public const string PatternTextRejectRegistrationInfo = "{0} не прошёл регистрацию и не улетел в {1}";
        }

        public static class HomeWorkFive
        {
            public const int InitRangeValueDefault = 0;
            public const int FinishRangeValueDefault = 50;
            public const int FinishRangeValueRepeatDefault = 3;
            public const string TextCapacityArrayInfo = "Enter capacity array";
            public const string TextIndexNewValueInfo = "Enter index of array for new value";
            public const string StringPatternNative = "Native for {0} items: {1} mls";
            public const string StringPatternCustom = "Custom for {0} items: {1} mls";
            public static string FiftyLines = new string('-', FinishRangeValueDefault);
        }

        public static class HomeWorkFour
        {
            public const string TextEnglishAlphabetUnicodeInfo = "Английский алфавит из UnicodeTable";
            public const string TextMoveUpInfo = "Move up.";
            public const string TextMoveDownInfo = "Move down.";
            public const string TextMoveRightInfo = "Move right.";
            public const string TextMoveLeftInfo = "Move left.";
            public const string TextWrongCommandInfo = "Wrong command. Please try again.";
            public const string TextEnterCommandInfo = "Please enter command(w,s,d,a or upper case, 2,4,6,8).";
            public const string TextCommandMoveUpInfo = "w";
            public const string TextAlternativeCommandMoveUpInfo = "W";
            public const string TextCommandMoveDownInfo = "s";
            public const string TextAlternativeCommandMoveDownInfo = "S";
            public const string TextCommandMoveLeftInfo = "a";
            public const string TextAlternativeCommandMoveLeftInfo = "A";
            public const string TextCommandMoveRightInfo = "d";
            public const string TextAlternativeCommandMoveRightInfo = "D";
        }

        public static class HomeWorkSix
        {
            public static string PathSolution = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.Parent?.FullName;
            public const char DefaultSeparator = ';';
            public const char DefaultOriginChangeLetter = 'О';
            public const char DefaultChangeLetter = 'А';
            public const char WhiteSpaceSeparator = ' ';
            public const string NameFile = "Hw_6_verse.txt";
            public const string TextConfirmInfo = "Maybe read verse from file";
            public const string TextEnterSeparatorInfo = "Please, enter separator for your verse";
            public const string PatterEnterVerse = "Please, enter the verse into one row dividing it {0}";
            public const string PatternRegexLetter = @"^[a-zA-Z]+$";
            public const string PatterRegexNotLetter = @"[^\w\s]";
            public const string SwapMaxLengthWordString = "MAX";
            public const string TextInfoForEnterRowInfo = "Please, enter row from server words";
            public const string PatterLengthMaxWordRemove = "Remove word with max length, result: {0}";
            public const string PatterSwapMinWithMaxWord = "Swap max with min word, result: {0}";
            public const string PatterResultLetterAndMarksInRow = "Letter in row: {0}, punctuation marks: {1}";
            public const string PatterLengthMinWord = "Length min word: {0}";
            public const string PatterLengthMaxWord = "Length max word: {0}";
        }

        public static class HomeWorkThree
        {
            public const string TextUserResultInfo = "Введите результат";
            public const string TextInfoFirstValueInfo = "Введите значение X";
            public const string TextInfoSecondValueInfo = "Введите значение Y";
            public const string TextResultInfo = "Результат равен";
            public const string TextCorrectlyInfo = "Правильно";
            public const string TextWrongInfo = "Неправильно";
            public const string TextMustBeMoreInfo = "Должно быть больше";
            public const string TextMustBeLessInfo = "Должно быть меньше";
            public const string TextOperatorInfo = "Введите оператор (-, +, /, *)";
            public const string TextNotSupportOperatorInfo = "Данный оператор не поддерживается";
            public const string TextPlusOperatorInfo = "+";
            public const string TextMinusOperatorInfo = "-";
            public const string TextMultiplyOperatorInfo = "*";
            public const string TextDivideOperatorInfo = "/";
            public const string TextExceptionInfo = "Что-то пошло не так, проверьте корректность введённых значений! Текст ошибки: {0}";
        }
    }
}
