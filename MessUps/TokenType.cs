namespace File_Destruture_sanwix.MessUps
{
    public class TokenType : ITokenType
    {
        string sKey ,eKey;
        public TokenType(string startKey,string endKey)
        {
            sKey = startKey;
            eKey = endKey;
        }

        public string StartKey => sKey;

        public string EndKey => eKey;
    }

    public interface ITokenType
    {
        string StartKey { get; }    
        string EndKey { get; }  
    }
}