namespace designpattern.MettingWithDIP
{
    /** 依赖倒置原则(DIP) 原则
        > 高层模块(稳定)不依赖于底层模块(变化),两者都依赖于抽象(稳定)
        > 抽象不依赖于细节,细节应该依赖于抽象
    **/
    public class Meeting
    {
        
        private  IPerson _person;
        //高层模块不依赖于底层模块,他们都依赖于抽象
        //他们将统一的标准抽离出来形成接口
        public Meeting(IPerson person)
        {
            _person = person;
        }

        //抽象不依赖于细节,细节应该依赖于抽象
        //当新的国家参与到会议中来,我们只需要添加一个语言对象应对需求的变化
        //它对于IPerson来说只是一个新的派生类,不需要关注具体的细节
        public void Say(string lang)
        {
            if(lang == "Italy")
            {
                _person = new Italy();
            }
            else if(lang == "American")
            {
                _person = new American();
            }
            //拓展一种新的国家语言
            // else if (lang == "NewLanguage")
            // {
            //     _person = new NewLanguage();
            // }
            _person.Say();
        }
    }
}