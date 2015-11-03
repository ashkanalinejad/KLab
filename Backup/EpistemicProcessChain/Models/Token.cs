namespace EpistemicProcessChain.Models
{
    public class Token
    {
        public string Name = "";

        public Token(string name)
        {
            Name = name;
        }
        
        public bool Equals(Token other)
        {
            return (other!=null) && (Name == other.Name);
        }

        public new string ToString()
        {
            return Name;
        }
        
    }
}
