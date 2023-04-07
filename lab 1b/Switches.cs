using System;

public class Program
{
    public GameStates gameStates;

    public void Main()
    {
        gameStates = new Gamestates();
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
                Console.WriteLine("Startting");
                break;
        }
    }
}