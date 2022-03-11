using System;
using System.Collections.Generic;

using System.IO;
using Newtonsoft.Json;


namespace Wordle_Tuga
{
    public class Player
    {
        public string nickname;
        public int gamesPlayed = 0;
        public int gamesWon = 0;
        public int totalAmountTries = 0;
        public int gamesLost = 0;

        public Player (string nickname)
        {
            this.nickname = nickname;
        }
    }

    internal class Statistics
    {
        List<Player> playerList = new List<Player>();

        private string _currentNickname;
        public string CurrentNickname { 
            get => _currentNickname;
            set
            {
                _currentNickname = value;
                if (!playerList.Exists(player => player.nickname == value))
                {
                    playerList.Add(new Player(value));
                }

                currentPlayer = playerList.Find(player => player.nickname == value);
            }
        }

        public Player currentPlayer;

        public Statistics ()
        {
            try
            {
                playerList = JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText(@"./statistics.json"));
            } catch { /* nothing to do, just ignore */ }
        }

        public void storeGame (bool win, int amountOfTries)
        {
            currentPlayer.gamesPlayed++;
            currentPlayer.totalAmountTries += amountOfTries;

            if (win) currentPlayer.gamesWon++;
            else currentPlayer.gamesLost++;

            File.WriteAllText("./statistics.json", JsonConvert.SerializeObject(playerList));
        }
    }
}
