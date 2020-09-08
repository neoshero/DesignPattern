namespace DesignPattern.TemplateMethod
{
    public class HttpApplication
    {
        private void Request(){}
        private void Routing(){}
        private void Execute(){}

        protected virtual void Authenticate(){}
        protected virtual void Authorize(){}
        public void Main()
        {
            Request();
            Routing();
            if(Authenticate() && Authorize())
            {
                Execute();
            }
        }
    }

    public class CustomApplication:HttpApplication
    {
        protected override bool Authenticate(){return true;}
        protected override void Authorize(){}
    }

    public class Program
    {
        public void Main()
        {
            CustomApplication builder = new CustomApplication();
            builder.Main();
        }
    }
}
