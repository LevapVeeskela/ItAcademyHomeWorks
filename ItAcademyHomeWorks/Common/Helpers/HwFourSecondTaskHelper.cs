using Common.Constants;
using Common.Enums;
using static Common.Enums.HwFourCommandsEnum;

namespace Common.Helpers
{
    public static class HwFourSecondTaskHelper
    {
        public static string GetProcessMoving(string command) => command switch
        {
            HomeWorkFour.TextCommandMoveUpInfo => HomeWorkFour.TextMoveUpInfo,
            HomeWorkFour.TextAlternativeCommandMoveUpInfo => HomeWorkFour.TextMoveUpInfo,
            HomeWorkFour.TextCommandMoveDownInfo => HomeWorkFour.TextMoveDownInfo,
            HomeWorkFour.TextAlternativeCommandMoveDownInfo => HomeWorkFour.TextMoveDownInfo,
            HomeWorkFour.TextCommandMoveRightInfo => HomeWorkFour.TextMoveRightInfo,
            HomeWorkFour.TextAlternativeCommandMoveRightInfo => HomeWorkFour.TextMoveDownInfo,
            HomeWorkFour.TextCommandMoveLeftInfo => HomeWorkFour.TextMoveLeftInfo,
            HomeWorkFour.TextAlternativeCommandMoveLeftInfo => HomeWorkFour.TextMoveLeftInfo,
            _ => HomeWorkFour.TextWrongCommandInfo
        };

        public static string GetProcessMoving(HwFourCommandsEnum command) => command switch
        {
            Up => HomeWorkFour.TextMoveUpInfo,
            Down => HomeWorkFour.TextMoveDownInfo,
            Right => HomeWorkFour.TextMoveRightInfo,
            Left => HomeWorkFour.TextMoveLeftInfo,
            _ => HomeWorkFour.TextWrongCommandInfo
        };
    }
}
