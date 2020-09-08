namespace DesignPattern.NormalMethod
{
    //请求管道
    public class HttpApplication
    {
        //处理请求信息
        public void Request(){}
        //处理路由
        public void Routing(){}
        //执行方法
        public void Execute(){}
    }

    //自己处理请求授权和数据授权
    public class CustomApplication
    {
        public bool Authenticate(){}
        public void Authorize(){}
    }

    public class Program
    {
        public void Main()
        {
            //整个HttpApplication管道的算法流程
            HttpApplication httpApplication = new HttpApplication();
            CustomApplication customApplication = new CustomApplication();

            httpApplication.Request();
            httpApplication.Routing();
            if(customApplication.Authenticate() && customApplication.Authorize())
            {
                httpApplication.Execute();
            }
        }
    }

}
