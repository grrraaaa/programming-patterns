

namespace lab1
{

    public interface I1
    {
        public int PublicProperty { get; set; }
        public void PublicMethod();
        event EventHandler InfoDisplayed;
        string this[int index] { get; }
    }
    
}
