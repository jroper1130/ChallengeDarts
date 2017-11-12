using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        //initialize players
        private Player _player1;
        private Player _player2;
        //initialize random number
        private Random _random;
        //initializes the actual game/main function 
        public Game(string player1Name, string player2Name)
        {
            //use player to make their names
            _player1 = new Player();
            _player1.Name = player1Name;

            _player2 = new Player();
            _player2.Name = player2Name;

            _random = new Random();
        }

        //keep playing until someone exceeds 300
        public string Play()
        {
            while (_player1.Score < 300 && _player2.Score < 300)
            {
                playRound(_player1);
                playRound(_player2);
            }
            return displayResults();
        }
        //print results and winner
        private string displayResults()
        {
            string result = String.Format("{0}: {1}<br />{2}: {3}",
                _player1.Name, _player1.Score, _player2.Name, _player2.Score);
            //show winner; logic= if P1 > P2 then print P1 else do P2
            return result += "<br />Winner: " + (_player1.Score > _player2.Score 
                ? _player1.Name : _player2.Name);
        }

        //generate 3 dart throws per round
        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                //generates random dart throw
                Dart dart = new Dart(_random);
                //score throws by calling Throw()
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }

    }

}