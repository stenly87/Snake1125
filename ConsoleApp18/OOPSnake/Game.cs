using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18.OOPSnake
{
    internal class Game
    {
        private Direction direction;
        public Direction Direction
        {
            get => direction;
            set
            {
                if (_gameField.Snake.Length > 1 &&
                    direction != value &&
                    (int)direction % 2 == (int)value % 2) // если направление было изменено на противоположное
                {
                    GameOver(); // закончить игру
                }
                direction = value;
            }
        }
        public Status Status { get; private set; }
        GameField _gameField;
        Scores _scores;
        Control _control;
        DrawGame _drawGame;

        public int Speed { get; set; } = 250;

        public Game(GameField gameField, Scores scores, DrawGame drawGame)
        {
            _gameField = gameField;
            _scores = scores;
            _drawGame = drawGame;

            Direction = Direction.Right;
            _control = new Control(this);
            
            var threadSnake = new Thread(RunGame); // создание потока для движения змейки
            threadSnake.Start(); // запуск потока
            
            _control.RunControl();


        }

        private void RunGame()
        {
            Status = Status.Running;
            while (Status != Status.GameOver)
            {
                Thread.Sleep(Speed);
                _control.FreeBlock();
                if (Status == Status.Pause)
                    continue;
                var result = _gameField.CalculateGameStep(Direction);
                if (result == StepResult.GameOver)
                {
                    GameOver();
                    break;
                }
                else if (result == StepResult.EatApple)
                {
                    _scores.Increase();
                    _drawGame.DrawScores(_scores.Amount);
                    IncreaseGameSpeed();
                }
            }
        }
        private void IncreaseGameSpeed()
        {
            // уменьшить speed на 10
            // добавить проверку, чтобы значение speed не опускалось ниже 10
            Speed -= 10;
            if (Speed < 10)
                Speed = 10;
        }
        internal void ChangeGamePause()
        {
            if (Status == Status.GameOver)
                return;
            if (Status != Status.Pause)
                Status = Status.Pause;
            else
                Status = Status.Running;
        }

        internal void GameOver()
        {
            Status = Status.GameOver;
            _drawGame.GameOver();
            _drawGame.DrawScores(_scores.Amount);
        }
    }
}
