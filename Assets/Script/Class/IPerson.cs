public enum Reaction: int
{
    Null = 0,
    Happy = 4,
    Sad = 1,
    Angry = 2,
    Laugh = 3
}

public interface IPerson
{
    int ID { get; set; }
    string Name { get; set; }
    Reaction Reaction { get; set; }
    bool isSpeaking { get; set; }

    int Allegiance { get; set; }
}
