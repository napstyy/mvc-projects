using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Configuration
    {
        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 25)
                {
                    throw new ArgumentException("Player name cannot be empty and must not exceed 25 characters.");
                }
                playerName = value;
            }
        }

        public int MonsterBoxes;
        public int HealthkitBoxes;
        public int EmptyBoxes;

        private int startingHP;

        public int HP
        {
            get { return startingHP; }
        }


        public string SetHPFromString(string hpString)
        {
            int hpValue;

            try
            {
                hpValue = int.Parse(hpString);

                if (hpValue >= 15 && hpValue <= 45)
                {
                    startingHP = hpValue;
                    return "HP set.";
                }
                else
                {
                    return "HP must be between 15 and 45.";
                }
            }
            catch (FormatException)
            {
                return "Invalid input. Please enter a valid number.";
            }
            catch (OverflowException)
            {
                return "Number is too large or too small.";
            }
        }

        public enum TimerOutcome
        {
            LoseHalfHP,
            LoseLife
        }

        private TimerOutcome timerOutcome;
        public TimerOutcome TimerOutcomeChoice
        {
            get { return timerOutcome; }
            set { timerOutcome = value; }
        }






    }
}
