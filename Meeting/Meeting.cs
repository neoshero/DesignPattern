namespace designpattern
{
    /** 一般模式 
        一场国际会议,会有不同的人进行说话
        当国际会议的不同国家 参加的人越多,那么将会添加一个新的国家语言
        高层对象(Meeting)与底层对象(Person)高度耦合
        缺点:
            当会议的国家发生变化时,需要创建一种新的语言,需要极高的维护成本对会议(Meeting)进行修改
            没有任何拓展性,不利于需求的变化
    **/
    public class Meeting
    {
        private readonly Chinese _chinese;
        private readonly Korean _korean;
        public Meeting ()
        {
            _chinese = new Chinese();
            _korean = new Korean();
        }

        
        public void Say(string lang)
        {
            if(lang == "Chinese")
            {
                _chinese.Say();
            }
            else if(lang == "Korean")
            {
                _korean.Say();
            }
        }
    }

    
}