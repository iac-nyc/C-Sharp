namespace ChowdhuryDefense
{
    class ChowdhuryDefenseException : System.Exception
    {
        public ChowdhuryDefenseException()
        {
        }
        
        public ChowdhuryDefenseException(string message) : base(message)
        {
        }
    }
    
    class OutOfBoundsException : ChowdhuryDefenseException
    {
        public OutOfBoundsException()
        {
        }
        
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}