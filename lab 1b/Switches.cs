using System;

public class Program
{
    public GameStates gameStates;

    public void Main()
    {
        gameStates = new Gamestates();
        gameStates.currentState = GameStates.States.Ending;
        gameStates.CheckState();
    }
}

public class GameStates {
    
    public enum States {
        Starting,
        Playing,
        Ending
    }

    public void CheckState () {
        switch (currentState) {
            case States.Starting:
                Console.WriteLine("Starting");
                break;
            case States.Playing:
                Console.WriteLine("Playing");
                break;
            case States.Ending:
                Console.WriteLine("Ending");
                break;
        }
    }
}