namespace designpattern.TemplateMethod
{
    public class Libary
    {
        private void Step1(){}
        protected virtual bool Step2(){ return true;}
        private void Step3(){}
        protected virtual void Step4(){}
        private void Step5(){}

        public void Run()
        {
            Step1();
            if(Step2())
            {
                Step3();
            }
            for(var i=0;i<10;i++)
            {
                Step4();
            }
            Step5();
        }
    }

    public class Application:Libary
    {
        protected override bool Step2(){return true;}
        protected override void Step4(){}
    }

}
