namespace Lab6Lib
{
    public class Publisher
    {
        private readonly string massege;
        delegate void PublisherHandler(string massege);
        event PublisherHandler Notifyer;

        public Publisher(string massege)
        {
            this.massege = massege;
        }
        public void Subscribe(ISubscriber publisher)
        {
            Notifyer += publisher.Update;
        }
        public void UnSubcribe(ISubscriber publisher)
        {
            Notifyer -= publisher.Update;
        }
        public int Notify()
        {
            if(Notifyer != null)
            {   
                Notifyer.Invoke(massege);
                return Notifyer.GetInvocationList().Count();
            }
            return 0;
        }
    }
}
