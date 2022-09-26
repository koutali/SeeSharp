namespace LemonadeChallenge
{
    public class Change
    {
        public static bool LemonadeChange(int[] bills)
        {
            var countFive = 0;
            var countTen = 0;

            for (var i = 0; i < bills.Length; i++)
            {
                var bill = bills[i];
                switch (bill)
                {
                    case 5:
                        countFive++;
                        break;

                    case 10:
                        if (countFive > 0)
                        {
                            countFive--;
                            countTen++;
                            break;
                        }
                        else
                            return false;

                    case 20:
                        if (countFive >= 1 && countTen >= 1)
                        {
                            countFive--;
                            countTen--;
                            break;
                        }
                        else if (countFive >= 3)
                        {
                            countFive -= 3;
                            break;
                        }
                        else
                        {
                            return false;
                        }

                    default:
                        return false;
                }
            }

            return true;
        }
    }
}
