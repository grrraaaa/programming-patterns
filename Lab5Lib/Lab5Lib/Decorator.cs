namespace Lab5Lib
{
    public class Decorator : IWriter
    {
        protected IWriter? writer;
        public Decorator(IWriter? writer) 
        {
            this.writer = writer;
        }
        public virtual string? Save(string massage)
        {
            return writer.Save(massage);
        }
    }
}
