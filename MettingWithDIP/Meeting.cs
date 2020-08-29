namespace designpattern.MettingWithDIP
{
    public class Meeting
    {
        private  IPerson _person;

        public Meeting(IPerson person)
        {
            _person = person;
        }

        public void Say(string lang)
        {
            if(lang == "Italy")
            {
                _person = new Italy();
            }
            if(lang == "American")
            {
                _person = new American();
            }
            _person.Say();
        }
    }
}