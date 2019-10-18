using Common.Constants;
using Common.Enums;
using static Common.Enums.HwFourCommandsEnum;

namespace Common.Helpers
{
    public static class HwFourSecondTaskHelper
    {
        public static string GetProcessMoving(string command) => command switch
        {
            Constants.Constants.HomeWorkFour.TextCommandMoveUpInfo => Constants.Constants.HomeWorkFour.TextMoveUpInfo,
            Constants.Constants.HomeWorkFour.TextAlternativeCommandMoveUpInfo => Constants.Constants.HomeWorkFour.TextMoveUpInfo,
            Constants.Constants.HomeWorkFour.TextCommandMoveDownInfo => Constants.Constants.HomeWorkFour.TextMoveDownInfo,
            Constants.Constants.HomeWorkFour.TextAlternativeCommandMoveDownInfo => Constants.Constants.HomeWorkFour.TextMoveDownInfo,
            Constants.Constants.HomeWorkFour.TextCommandMoveRightInfo => Constants.Constants.HomeWorkFour.TextMoveRightInfo,
            Constants.Constants.HomeWorkFour.TextAlternativeCommandMoveRightInfo => Constants.Constants.HomeWorkFour.TextMoveDownInfo,
            Constants.Constants.HomeWorkFour.TextCommandMoveLeftInfo => Constants.Constants.HomeWorkFour.TextMoveLeftInfo,
            Constants.Constants.HomeWorkFour.TextAlternativeCommandMoveLeftInfo => Constants.Constants.HomeWorkFour.TextMoveLeftInfo,
            _ => Constants.Constants.HomeWorkFour.TextWrongCommandInfo
        };

        public static string GetProcessMoving(HwFourCommandsEnum command) => command switch
        {
            Up => Constants.Constants.HomeWorkFour.TextMoveUpInfo,
            Down => Constants.Constants.HomeWorkFour.TextMoveDownInfo,
            Right => Constants.Constants.HomeWorkFour.TextMoveRightInfo,
            Left => Constants.Constants.HomeWorkFour.TextMoveLeftInfo,
            _ => Constants.Constants.HomeWorkFour.TextWrongCommandInfo
        };
    }
}
