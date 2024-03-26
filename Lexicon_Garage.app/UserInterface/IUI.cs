namespace Lexicon_Garage.app.UserInterface
{
    public interface IUI
    {
        string GetInput();

        void Clean();

        void Print(string message);
    }
}